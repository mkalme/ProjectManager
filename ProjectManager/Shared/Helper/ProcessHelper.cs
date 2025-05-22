using System;
using System.Diagnostics;

namespace ProjectManager {
    public static class ProcessHelper {
        public static void OpenInDefaultProgram(string file) {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo(file) {
                UseShellExecute = true
            };

            process.Start();
        }
        public static void OpenFolder(string folder) {
            Process.Start("explorer.exe", folder);
        }
        public static void SelectFile(string file) {
            string argument = "/select, \"" + file + "\"";

            Process.Start("explorer.exe", argument);
        }
    }
}
