using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ProjectLineCounter;

namespace ProjectManager {
    public partial class ProjectManagerForm : Form {
        public ViewController ViewController { get; set; }
        public IView CurrentView => ViewController.CurrentView;
        public DirectoryLineCount Directory => CurrentView.Directory;

        public ProjectManagerForm(DirectoryLineCount directory) {
            InitializeComponent();

            LineContextMenuStrip.Renderer = new ToolStripProfessionalRenderer(new CustomColors());

            PathPanel.SetDoubleBuffering();
            LineDataGridView.SetDoubleBuffering();
            new HeightmapSelection(LineDataGridView);

            ViewController = new ViewController(directory);
            ViewController.ViewUpdate += (object sender, EventArgs e) => LoadGrid(sender as IView);

            LoadGrid(CurrentView);
        }

        private void ProjectManagerForm_Load(object sender, EventArgs e) {
            LineDataGridView.ClearSelection();
        }

        //Update
        private bool _isUpdating = false;
        public void LoadGrid(IView view) {
            _isUpdating = true;
            string closestPath = view.Directory.GetCommonDirectory() + "\\";

            LineDataGridView.Rows.Clear();
            for (int i = 0; i < view.Directory.Items.Count; i++) {
                var item = view.Directory.Items[i];

                LineDataGridView.Rows.Add(
                    i,
                    Path.GetFileName(item.Path),
                    item.Path.Substring(closestPath.Length),
                    item.LineCount,
                    item.CreateTypeString(),
                    item.GetCreationDate());
                DisplayImageInCell(i, item.CreateIcon());

                LineDataGridView.Rows[i].Selected = view.SelectedItems.Contains(item);
            }

            if (view.SortedColumnIndex > -1) LineDataGridView.Sort(LineDataGridView.Columns[view.SortedColumnIndex], view.SortOrder);
            if (view.SelectedItems.Count < 1) LineDataGridView.ClearSelection();

            UpdateInformationLabel(view);
            UpdateSelectedItemsLabel();

            PathPanel.Load(view.Directory);
            _isUpdating = false;
        }
        private void DisplayImageInCell(int rowIndex, Image image) {
            ((TextAndImageCell)LineDataGridView.Rows[rowIndex].Cells[1]).Image = image;

            LineDataGridView.Rows[rowIndex].Cells[1].Style.Padding = new Padding(25, 0, 0, 0);
        }

        private void UpdateInformationLabel(IView view) {
            ItemInformationLabel.Text = $"Items: {view.Directory.Items.Count.ToString("N0")}; Lines of code: {FormatHelper.Format(view.Directory.LineCount)}";
        }
        private void UpdateSelectedItemsLabel() {
            int totalLines = 0;
            CurrentView.SelectedItems.ForEach(x => totalLines += x.LineCount);

            SelectedItemInformationLabel.Text = $"Selected items: {LineDataGridView.SelectedRows.Count}; Lines of code: {FormatHelper.Format(totalLines)}";
        }

        private void LineDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;
            var item = GetItem(e.RowIndex);

            if (item.IsDirectory()) {
                ViewController.OpenView(item as DirectoryLineCount);
            } else if (item.IsFile()) {
                ProcessHelper.OpenInDefaultProgram(item.Path);
            }
        }
        private void LineDataGridView_SelectionChanged(object sender, EventArgs e) {
            if (_isUpdating) return;

            List<ItemLineCount> selectedItems = new List<ItemLineCount>(LineDataGridView.SelectedRows.Count);
            foreach (DataGridViewRow row in LineDataGridView.SelectedRows) {
                selectedItems.Add(GetItem(row.Index));
            }

            CurrentView.SelectedItems = selectedItems;
            UpdateSelectedItemsLabel();
        }

        private void LineDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.ColumnIndex != 5) return;
            ShortFormDateFormat(e);
        }
        private static void ShortFormDateFormat(DataGridViewCellFormattingEventArgs formatting) {
            if (formatting.Value != null) {
                DateTime creationDate = DateTime.Parse(formatting.Value.ToString());

                formatting.Value = creationDate.ToString("MMM d, yyyy", CultureInfo.InvariantCulture);
                formatting.FormattingApplied = true;
            }
        }

        private void LineDataGridView_Sorted(object sender, EventArgs e) {
            CurrentView.SortedColumnIndex = LineDataGridView.SortedColumn.Index;
            CurrentView.SortOrder = LineDataGridView.SortOrder == SortOrder.Ascending ? ListSortDirection.Ascending : ListSortDirection.Descending;
        }

        //Helper methods
        private int GetRowIndexFromPoint(Point point) {
            Point rPoint = LineDataGridView.PointToClient(point);
            return LineDataGridView.HitTest(rPoint.X, rPoint.Y).RowIndex;
        }

        private ItemLineCount GetItem(int rowIndex) { 
            return Directory.Items[GetIndex(rowIndex)];
        }
        private int GetIndex(int rowIndex) {
            return (int)LineDataGridView.Rows[rowIndex].Cells[0].Value;
        }

        //Header buttons
        private void PathPanel_ButtonClick(object sender, EventArgs e) {
            ViewController.OpenView(((PathButtonPanel)sender).Directory);
        }

        private void GoBackButton_Click(object sender, EventArgs e) {
            ViewController.SetPreviousView();
        }
        private void GoForwardsButton_Click(object sender, EventArgs e) {
            ViewController.SetNextView();
        }

        //Footer buttons
        private void FileViewButton_Click(object sender, EventArgs e) {
            ViewController.ChangeViewType(ViewType.File);
        }
        private void ProjectViewButton_Click(object sender, EventArgs e) {
            ViewController.ChangeViewType(ViewType.Project);
        }

        private void BrowseButton_Click(object sender, EventArgs e) {
            BrowseForm browseForm = new BrowseForm(Directory.Path);
            browseForm.ShowDialog();

            if (browseForm.Directory != null) ViewController.Reset(browseForm.Directory);
        }
        private void CopyButton_Click(object sender, EventArgs e) {
            StringBuilder builder = new StringBuilder();

            foreach (DataGridViewRow row in LineDataGridView.Rows) {
                string line = $"{row.Cells[1].Value}\t{GetItem(row.Index).LineCount}\t{((DateTime)row.Cells[5].Value).ToString("dd.MM.yyyy")}\n";
                builder.Append(line);
            }

            Clipboard.SetText(builder.ToString());
        }

        //LineContextMenuStrip
        private void LineContextMenuStrip_Opening(object sender, CancelEventArgs e) {
            int rowIndex = GetRowIndexFromPoint(LineContextMenuStrip.Bounds.Location);

            OpenInProgramMenuItem.Enabled = LineDataGridView.SelectedRows.Count > 0 && GetItem(rowIndex).IsFile();
            NewViewMenuItem.Enabled = LineDataGridView.SelectedRows.Count > 0;
        }

        private void OpenInFileExplorerMenuItem_Click(object sender, EventArgs e) {
            int rowIndex = GetRowIndexFromPoint(LineContextMenuStrip.Bounds.Location);

            if (rowIndex >= 0) {
                var item = GetItem(rowIndex);

                if (item.IsDirectory()) ProcessHelper.OpenFolder(item.Path);
                else if (item.IsFile()) ProcessHelper.SelectFile(item.Path);
            } else {
                ProcessHelper.OpenFolder(Directory.Path);
            }
        }
        private void OpenInProgramMenuItem_Click(object sender, EventArgs e) {
            ProcessHelper.OpenInDefaultProgram(GetItem(GetRowIndexFromPoint(LineContextMenuStrip.Bounds.Location)).Path);
        }
        
        private void NewViewMenuItem_Click(object sender, EventArgs e) {
            ViewController.NewView(CurrentView.SelectedItems);
        }
        private void NewWindowMenuItem_Click(object sender, EventArgs e) {
            int rowIndex = GetRowIndexFromPoint(LineContextMenuStrip.Bounds.Location);

            DirectoryLineCount newDirectory;

            if (rowIndex >= 0) {
                ItemLineCount item = GetItem(rowIndex);

                if (item.IsDirectory()) newDirectory = item.Clone() as DirectoryLineCount;
                else if (item.IsFile()) newDirectory = Directory.Clone() as DirectoryLineCount;
                else return;
            } else {
                newDirectory = Directory.Clone() as DirectoryLineCount;
            }

            ProjectManagerForm form = new ProjectManagerForm(newDirectory);
            form.Show();
        }
    }
}
