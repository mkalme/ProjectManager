using System;
using System.Windows.Forms;

namespace ProjectManagerGUI {
    static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string source;

            if (args == null || args.Length == 0) source = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\source";
            else source = args[0];

            BrowseForm browseForm = new BrowseForm(source, args != null && args.Length > 0);
            browseForm.ShowDialog();

            if (browseForm.Directory != null) {
                Application.Run(new ProjectManagerForm(browseForm.Directory));
            }
        }
    }
}
