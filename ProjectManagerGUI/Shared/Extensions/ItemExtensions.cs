using System;
using System.Drawing;
using System.IO;
using ProjectLineCounter;

namespace ProjectManagerGUI {
    public static class ItemExtensions {
        public static Image CreateIcon(this ItemLineCount item) {
            switch (item.Type) {
                case NodeType.SourceFile:
                    return Properties.Resources._16pxTextFile;
                case NodeType.Folder:
                    return Properties.Resources._20pxFolder;
                case NodeType.Project:
                    switch (((ProjectLineCount)item).ProjectType) {
                        case ProjectType.ClassLibrary:
                            return Properties.Resources._16pxLibrary;
                        case ProjectType.ConsoleApplication:
                            return Properties.Resources._16pxConsoleApplication;
                        case ProjectType.DesktopApplication:
                            return Properties.Resources._16pxDesktopApplication;
                        default:
                            return Properties.Resources._16pxCSharpProject;
                    }
                case NodeType.Solution:
                    return Properties.Resources._20pxSolution;
                default:
                    return Properties.Resources._16pxCSharpProject;
            }
        }
        public static string CreateTypeString(this ItemLineCount item) {
            switch (item.Type) {
                case NodeType.SourceFile:
                    return "Source file";
                case NodeType.Folder:
                    return "Folder";
                case NodeType.Project:
                    switch ((item as ProjectLineCount).ProjectType) {
                        case ProjectType.ClassLibrary:
                            return "Class library";
                        case ProjectType.ConsoleApplication:
                            return "Console application";
                        case ProjectType.DesktopApplication:
                            return "Desktop application";
                        default:
                            return "Project";
                    }
                case NodeType.Solution:
                    return "Solution";
                default:
                    return "";
            }
        }
        public static string GetCommonDirectory(this DirectoryLineCount directory) {
            if (directory.Items.Count < 1) return "";
            string output = directory.Items[0].Path;

            foreach (var item in directory.Items) {
                string match = output.FindNearestMatch(item.Path);

                if (match.Length < output.Length) output = match;
            }

            return Path.GetDirectoryName(Path.TrimEndingDirectorySeparator(output));
        }
        public static DateTime GetCreationDate(this ItemLineCount item) {
            DateTime creationDate;

            if (item.GetType() == typeof(FileLineCount)) {
                creationDate = File.GetCreationTime(item.Path);
            } else {
                creationDate = Directory.GetCreationTime(item.Path);
            }

            return creationDate;
        }
        public static bool IsDirectory(this ItemLineCount item) {
            return item.GetType() == typeof(DirectoryLineCount) || item.GetType() == typeof(ProjectLineCount);
        }
        public static bool IsFile(this ItemLineCount item) {
            return item.GetType() == typeof(FileLineCount);
        }
    }
}
