using System;
using System.Windows.Forms;
using System.Drawing;

namespace ProjectManager {
    public class ExtendedToolStripSeparator : ToolStripSeparator {
        public ExtendedToolStripSeparator() {
            Paint += ExtendedToolStripSeparator_Paint;
        }

        private void ExtendedToolStripSeparator_Paint(object sender, PaintEventArgs e) {
            ToolStripSeparator toolStripSeparator = (ToolStripSeparator)sender;
            int width = toolStripSeparator.Width, height = toolStripSeparator.Height;

            Color foreColor = Color.FromArgb(128, 128, 128);
            Color backColor = Color.FromArgb(50, 50, 50);

            e.Graphics.FillRectangle(new SolidBrush(backColor), 0, 0, width, height);
            e.Graphics.DrawLine(new Pen(foreColor), 4, height / 2, width - 4, height / 2);
        }
    }
}
