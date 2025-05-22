using System;
using System.Threading;
using System.Windows.Forms;
using ProjectLineCounter;

namespace ProjectManager {
    public partial class BrowseForm : Form {
        public DirectoryLineCount Directory { get; set; }
        public bool StartOnShown { get; set; }

        private bool _inProcess = false;

        public BrowseForm(string text = "", bool startOnShown = false) {
            InitializeComponent();

            PathTextBox.Text = text;
            StartOnShown = startOnShown;
        }

        private void BrowseForm_Shown(object sender, EventArgs e) {
            if (StartOnShown) StartScan();
        }

        private void BrowseButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog.ShowDialog();

            PathTextBox.Text = FolderBrowserDialog.SelectedPath;
        }
        private void SelectButton_Click(object sender, EventArgs e) {
            if(!_inProcess) StartScan();
        }

        private void ProjectScanned(object sender, LineCountEventArgs e) {
            Invoke(new Action(() => {
                SetProgressPanelWidth(e);
            }));
        }

        private void StartScan() {
            _inProcess = true;

            SourceLineCounter counter = new SourceLineCounter();
            counter.ProjectScanned += ProjectScanned;

            Height += 5;

            new Thread(() => {
                Directory = counter.Count(PathTextBox.Text) as DirectoryLineCount;

                Invoke(new Action(() => {
                    Close();
                }));
            }).Start();
        }
        private void SetProgressPanelWidth(LineCountEventArgs e) {
            float percentage = (float)e.CurrentScannedProjects / e.TotalProjects;

            ProgressPanel.Width = (int)Math.Ceiling(ProgressContainerPanel.Width * percentage);
        }
    }
}
