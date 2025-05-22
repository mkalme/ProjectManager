using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectLineCounter;

namespace ProjectManager {
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
