using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ProjectLineCounter;

namespace ProjectManager {
    public class PathPanel : Panel {
        public event EventHandler ButtonClick;

        private IList<PathButtonPanel> _buttons;

        public PathPanel() {
            BorderStyle = BorderStyle.FixedSingle;

            Margin = new Padding(0);
            Dock = DockStyle.Fill;
        }

        public void Load(DirectoryLineCount directory) {
            AddAllButtons(directory);
        }

        private void AddAllButtons(DirectoryLineCount directory) {
            _buttons = GetAllButtons(directory);

            Controls.Clear();

            int x = 0;
            for (int i = 0; i < _buttons.Count; i++) {
                PathButtonPanel button = _buttons[i];
                button.MouseClick += OnButtonClick;

                if (i == 0) button.Width += 2;

                button.Location = new Point(x, 0);                
                Controls.Add(button);

                x += button.Width;

                if (i < _buttons.Count - 1) {
                    Label label = new Label() {
                        Text = ">",
                        Location = new Point(x - 1, -1),
                        ForeColor = SystemColors.HighlightText,
                        Font = new Font("Segoe UI", 12),
                        AutoSize = true
                    };

                    Controls.Add(label);
                }

                button.BringToFront();

                x += 15;
            }
        }
        private static IList<PathButtonPanel> GetAllButtons(DirectoryLineCount directory) {
            List<PathButtonPanel> buttons = new List<PathButtonPanel>();

            var item = directory;
            while (item != null) {
                buttons.Add(new PathButtonPanel(item));

                item = item.Parent;
            }

            buttons.Reverse();

            return buttons;
        }

        private void OnButtonClick(object sender, EventArgs e) {
            ButtonClick.Invoke(sender, e);
        }
    }
}
