using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectManager {
    public class HeightmapSelection {

        public Color RowBackColor { get; set; } = Color.FromArgb(45, 45, 45);
        public Color RowSelectionColor { get; set; } = Color.FromArgb(70, 70, 70);

        public Color RowHoverColor { get; set; } = Color.FromArgb(55, 55, 55);
        public Color RowSecondHoverColor { get; set; } = Color.FromArgb(80, 80, 80);

        private DataGridView _dataGridView;

        public HeightmapSelection(DataGridView dataGridView) {
            _dataGridView = dataGridView;

            _dataGridView.RowsDefaultCellStyle.BackColor = RowBackColor;
            _dataGridView.DefaultCellStyle.SelectionBackColor = RowSelectionColor;

            _dataGridView.MouseDown += DataGridView_MouseDown;
            _dataGridView.CellMouseMove += DataGridView_CellMouseMove;
            _dataGridView.CellMouseLeave += DataGridView_CellMouseLeave;
            _dataGridView.CellMouseEnter += DataGridView_CellMouseEnter;
            _dataGridView.RowStateChanged += DataGridView_RowStateChanged;
        }

        private void DataGridView_MouseDown(object sender, MouseEventArgs e) {
            DataGridView.HitTestInfo hitTest = _dataGridView.HitTest(e.X, e.Y);

            if (hitTest.RowIndex == -1) {
                _dataGridView.ClearSelection();
                return;
            }

            if (e.Button == MouseButtons.Right && !_dataGridView.Rows[hitTest.RowIndex].Selected) {
                _dataGridView.ClearSelection();
                _dataGridView.Rows[hitTest.RowIndex].Selected = true;
            }
        }

        private void DataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.RowIndex < 0) return;

            if (_dataGridView.Rows[e.RowIndex].Selected) {
                _dataGridView.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = RowSecondHoverColor;
            } else {
                _dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = RowHoverColor;
            }
        }
        private void DataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;

            if (_dataGridView.Rows[e.RowIndex].Selected) {
                _dataGridView.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = RowSelectionColor;
            } else {
                _dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = RowBackColor;
            }
        }
        private void DataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;

            if (_dataGridView.Rows[e.RowIndex].Selected) {
                _dataGridView.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = RowSecondHoverColor;
            } else {
                _dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = RowHoverColor;
            }
        }

        private void DataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e) {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            e.Row.DefaultCellStyle.BackColor = RowBackColor;
        }
    }
}
