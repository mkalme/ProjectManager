using System;
using System.IO;
using System.Globalization;
using System.Windows.Forms;
using ProjectLineCounter;
using CustomDialogs;

namespace ProjectManagerGUI {
    public class ItemExplorerGridControl : DataGridViewControl {
        public ViewController ViewController { get; set; }

        public string ClosestPath { get; set; }

        public ItemExplorerGridControl(ViewController viewController) {
            ViewController = viewController;

            Initialize();

            DataGridView.CellFormatting += DataGridView_CellFormatting;
        }

        public override DataGridViewColumn[] CreateColumns() {
            return new DataGridViewColumn[] {
                new TextAndImageColumn(){
                    HeaderText = "Name",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet,
                    Width = 190
                },
                new DataGridViewTextBoxColumn(){
                    HeaderText = "Path",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                },
                new DataGridViewTextBoxColumn(){
                    HeaderText = "Lines",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet,
                    Width = 55,
                    DefaultCellStyle = new DataGridViewCellStyle(){
                        Alignment = DataGridViewContentAlignment.MiddleRight,
                        Padding = new Padding(0),
                        Format = "N0"
                    }
                },
                new DataGridViewTextBoxColumn(){
                    HeaderText = "Type",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet,
                    Width = 120,
                    DefaultCellStyle = new DataGridViewCellStyle(){
                        Alignment = DataGridViewContentAlignment.MiddleRight,
                        Padding = new Padding(0)
                    }
                },
                new DataGridViewTextBoxColumn(){
                    HeaderText = "Creation date",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet,
                    Width = 105,
                    DefaultCellStyle = new DataGridViewCellStyle(){
                        Alignment = DataGridViewContentAlignment.MiddleRight,
                        Padding = new Padding(0, 0, 5, 0),
                        Format = "MMM d, yyyy"
                    }
                }
            };
        }
        protected override void GridDoubleClick(DataGridViewCellEventArgs e, object item) {
            if (item is DirectoryLineCount g) {
                ViewController.OpenChild(g);
            } else {
                ProcessHelper.OpenInDefaultProgram((item as ItemLineCount).Path);
            }
        }

        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.ColumnIndex != 4) return;
            ShortFormDateFormat(e);
        }
        private static void ShortFormDateFormat(DataGridViewCellFormattingEventArgs formatting) {
            if (formatting.Value != null) {
                DateTime creationDate = DateTime.Parse(formatting.Value.ToString());

                formatting.Value = creationDate.ToString("MMM d, yyyy", CultureInfo.InvariantCulture);
                formatting.FormattingApplied = true;
            }
        }

        //Update
        protected override bool SetRow(DataGridViewRow row, object obj) {
            ItemLineCount item = obj as ItemLineCount;

            row.Cells[0].Value = Path.GetFileName(item.Path);
            row.Cells[1].Value = item.Path.Substring(ClosestPath.Length);
            row.Cells[2].Value = item.LineCount;
            row.Cells[3].Value = item.CreateTypeString();
            row.Cells[4].Value = item.GetCreationDate();
            
            row.DisplayImage(DataGridView.Columns[0], item.CreateIcon(), 25);

            return true;
        }
    }
}
