using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectManager {
    public class CustomColors : ProfessionalColorTable {
        public Color BackColor { get; set; } = Color.FromArgb(50, 50, 50);
        public Color HoverColor { get; set; } = Color.FromArgb(80, 80, 80);

        public override Color ImageMarginGradientBegin => BackColor;
        public override Color ImageMarginGradientMiddle => BackColor;
        public override Color ImageMarginGradientEnd => BackColor;

        public override Color MenuItemBorder => HoverColor;

        public override Color MenuItemSelectedGradientBegin => HoverColor;
        public override Color MenuItemSelectedGradientEnd => HoverColor;
    }
}
