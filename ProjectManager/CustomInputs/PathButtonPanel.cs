using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using ProjectLineCounter;

namespace ProjectManager {
    public class PathButtonPanel : Panel {
        public DirectoryLineCount Directory { get; set; }

        public new event EventHandler MouseClick {
            add {
                base.MouseClick += Control_MouseClick;
                _label.MouseClick += Control_MouseClick;

                _mouseClick += value;
            }
            remove {
                base.MouseClick -= Control_MouseClick;
                _label.MouseClick -= Control_MouseClick;

                _mouseClick -= value;

            }
        }
        private event EventHandler _mouseClick;

        private Label _label;

        public Color PanelBackColor { get; set; } = Color.FromArgb(35, 35, 35);
        public Color PanelHoverColor { get; set; } = Color.FromArgb(48, 48, 48);
        public Color PanelMouseDownColor { get; set; } = Color.FromArgb(110, 110, 110);

        public PathButtonPanel(DirectoryLineCount directory) {
            Directory = directory;

            BackColor = PanelBackColor;
            ForeColor = SystemColors.HighlightText;

            _label = new Label();
            _label.Text = Path.GetFileName(directory.Path);
            _label.AutoSize = true;
            _label.Location = new Point(2, 4);
            _label.Anchor = AnchorStyles.Right;

            _label.MouseDown += Control_MouseDown;
            _label.MouseUp += Control_MouseUp;
            _label.MouseEnter += Control_MouseEnter;
            _label.MouseLeave += Control_MouseLeave;

            MouseDown += Control_MouseDown;
            MouseUp += Control_MouseUp;
            MouseEnter += Control_MouseEnter;
            MouseLeave += Control_MouseLeave;

            SizeF textSize = TextRenderer.MeasureText(_label.Text, Font);
            Width = (int)textSize.Width + 4;

            Controls.Add(_label);
        }

        private void Control_MouseDown(object sender, EventArgs e) {
            BackColor = PanelMouseDownColor;
            _label.BackColor = PanelMouseDownColor;
        }
        private void Control_MouseUp(object sender, EventArgs e) {
            BackColor = PanelBackColor;
            _label.BackColor = PanelBackColor;
        }

        private void Control_MouseEnter(object sender, EventArgs e) {
            BackColor = PanelHoverColor;
            _label.BackColor = PanelHoverColor;
        }
        private void Control_MouseLeave(object sender, EventArgs e) {
            BackColor = PanelBackColor;
            _label.BackColor = PanelBackColor;
        }

        private void Control_MouseClick(object sender, EventArgs e) {
            _mouseClick(this, e);
        }
    }
}
