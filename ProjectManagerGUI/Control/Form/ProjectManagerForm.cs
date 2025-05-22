using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using ProjectLineCounter;
using CustomDialogs;

namespace ProjectManagerGUI {
    public partial class ProjectManagerForm : Form {
        public DirectoryLineCount RootDirectory { get; set; }

        public DirectoryViewNodeFacade CurrentViewNode => CurrentView.ViewNode as DirectoryViewNodeFacade;
        public DirectoryLineCount CurrentDirectory => CurrentView.ViewNode.Node as DirectoryLineCount;
        public IView CurrentView => ViewControl.ViewController.CurrentView;

        public ItemExplorerGridControl GridControl { get; set; }
        public DataGridView GridView {
            get => GridControl.DataGridView;
        }

        public ViewControl ViewControl { get; set; }

        public ProjectManagerForm(DirectoryLineCount directory) {
            InitializeComponent();

            RootDirectory = directory;

            MenuStrip.Renderer = new CustomToolStripRenderer(new CustomMenuStripColors() {
                BackColor = Color.FromArgb(50, 50, 50),
                BorderColor = Color.FromArgb(128, 128, 128),
                InnerBorderColor = Color.FromArgb(50, 50, 50),
                HoverColor = Color.FromArgb(80, 80, 80),
                DisabledHoverColor = Color.FromArgb(80, 80, 80)
            });

            ViewController viewController = new ViewController(new DirectoryViewNodeFacade(RootDirectory));
            GridControl = new ItemExplorerGridControl(viewController);

            ViewControl = new ViewControl() {
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            StandardVerticalViewControl viewControl = new StandardVerticalViewControl(ViewControl, GridControl);
            viewControl.HeaderToolBar.ViewController = viewController;
            viewControl.HeaderToolBar.NodeCreator = item => new DirectoryNode(item as DirectoryLineCount);

            ViewControl.Initialize(viewController, viewControl);
            GlobalContainer.Controls.Add(ViewControl, 0, 0);

            ViewControl.BeginUpdate += ViewControl_BeginUpdate;
            ViewControl.Updated += ViewControl_Updated;

            GridView.SelectionChanged += GridView_SelectionChanged;
            GridView.Sorted += GridView_Sorted;
            GridView.ContextMenuStrip = MenuStrip;
        }

        //Update
        private void ProjectManagerForm_Load(object sender, EventArgs e) {
            ViewControl.UpdateView();
        }

        private bool _inUpdate = false;
        private void ViewControl_BeginUpdate(object sender, EventArgs e) {
            _inUpdate = true;

            CurrentView.SelectedItems.Change(CurrentViewNode.Selected.SelectedItems);

            GridControl.ClosestPath = CurrentDirectory.GetCommonDirectory() + "\\";
        }
        private void ViewControl_Updated(object sender, EventArgs e) {
            _inUpdate = false;
            bool clearSelection = CurrentView.SelectedItems.Count < 1;

            if (CurrentViewNode.SortedColumnIndex > -1) GridView.Sort(GridView.Columns[CurrentViewNode.SortedColumnIndex], CurrentViewNode.SortOrder);
            if (clearSelection) GridView.ClearSelection();

            UpdateInformationLabel();
            UpdateSelectedItemsLabel();
        }

        private void GridView_SelectionChanged(object sender, EventArgs e) {
            if (_inUpdate) return;

            CurrentViewNode.Selected.SelectedItems.Clear();

            List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in GridView.SelectedRows) {
                selectedRows.Add(row);
            }

            foreach (DataGridViewRow row in selectedRows.OrderBy(x => x.Index)) {
                CurrentViewNode.Selected.SelectedItems.Add(row.Tag);
            }

            CurrentView.SelectedItems.Change(CurrentViewNode.Selected.SelectedItems);

            UpdateSelectedItemsLabel();
        }
        private void GridView_Sorted(object sender, EventArgs e) {
            CurrentViewNode.SortedColumnIndex = GridView.SortedColumn.Index;
            CurrentViewNode.SortOrder = GridView.SortOrder == SortOrder.Ascending ? ListSortDirection.Ascending : ListSortDirection.Descending;
        }

        private void UpdateInformationLabel() {
            ItemInformationLabel.Text = $"Items: {CurrentView.ViewNode.Items.Count.ToString("N0")}; Lines of code: {FormatHelper.Format(CurrentDirectory.LineCount)}";
        }
        private void UpdateSelectedItemsLabel() {
            int totalLines = 0;
            CurrentView.SelectedItems.ForEach(x => totalLines += ((ItemLineCount)x).LineCount);

            SelectedItemInformationLabel.Text = $"Selected items: {CurrentView.SelectedItems.Count}; Lines of code: {FormatHelper.Format(totalLines)}";
        }

        //Bottom buttons
        private void CopyButton_Click(object sender, EventArgs e) {
            StringBuilder builder = new StringBuilder();

            foreach (DataGridViewRow row in GridView.Rows) {
                string line = $"{row.Cells[0].Value}\t{((ItemLineCount)row.Tag).LineCount}\t{((DateTime)row.Cells[4].Value).ToString("dd.MM.yyyy")}\n";
                builder.Append(line);
            }

            Clipboard.SetText(builder.ToString());
        }
        private void BrowseButton_Click(object sender, EventArgs e) {
            BrowseForm browseForm = new BrowseForm(CurrentDirectory.Path);
            browseForm.ShowDialog();

            if (browseForm.Directory != null) {
                RootDirectory = browseForm.Directory;

                ViewControl.ViewController.Index = -1;
                ViewControl.ViewController.Views.Clear();

                ViewControl.ViewController.OpenChild(browseForm.Directory);
            } 
        }

        private void ProjectViewButton_Click(object sender, EventArgs e) {
            CurrentViewNode.SetType(ViewType.Project);
        }
        private void FileViewButton_Click(object sender, EventArgs e) {
            CurrentViewNode.SetType(ViewType.File);
        }

        //MenuStrip
        private void MenuStrip_Opening(object sender, CancelEventArgs e) {
            ItemLineCount item = GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as ItemLineCount;

            OpenInProgramMenuItem.Enabled = CurrentView.SelectedItems.Count > 0 && item.IsFile();
            NewViewMenuItem.Enabled = CurrentView.SelectedItems.Count > 0;
        }

        private void OpenInFileExplorerMenuItem_Click(object sender, EventArgs e) {
            ItemLineCount item = GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as ItemLineCount;

            if (item != null) {
                if (item.IsDirectory()) ProcessHelper.OpenFolder(item.Path);
                else if (item.IsFile()) ProcessHelper.SelectFile(item.Path);
            } else {
                ProcessHelper.OpenFolder(CurrentDirectory.Path);
            }
        }
        private void OpenInProgramMenuItem_Click(object sender, EventArgs e) {
            ProcessHelper.OpenInDefaultProgram((GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as ItemLineCount).Path);
        }

        private void NewViewMenuItem_Click(object sender, EventArgs e) {
            CurrentViewNode.SetNewView(CurrentView.SelectedItems.Cast<ItemLineCount>().ToList());
        }
        private void NewWindowMenuItem_Click(object sender, EventArgs e) {
            DirectoryLineCount newDirectory = CurrentDirectory.Clone() as DirectoryLineCount;

            if (CurrentView.SelectedItems.Count > 0) {
                newDirectory.Items.Clear();

                foreach (var item in CurrentView.SelectedItems) {
                    newDirectory.Items.Add((item as ItemLineCount).Clone() as ItemLineCount);
                }
            }

            new ProjectManagerForm(newDirectory).Show();
        }
    }
}
