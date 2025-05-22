using System;
using System.Collections.Generic;
using System.ComponentModel;
using ProjectLineCounter;

namespace ProjectManager {
    public class View : IView {
        public DirectoryLineCount Directory { get; set; }
        public ICollection<ItemLineCount> SelectedItems { get; set; }

        public int SortedColumnIndex { get; set; }
        public ListSortDirection SortOrder { get; set; }

        public View(DirectoryLineCount directory) {
            Directory = directory;
            Directory.Items = Sort(Directory.Items);
            
            SelectedItems = new List<ItemLineCount>();

            if (directory.Type == NodeType.Collection) {
                SortedColumnIndex = 4;
            } else {
                SortedColumnIndex = -1;
            }

            SortOrder = ListSortDirection.Descending;
        }

        private IList<ItemLineCount> Sort(IList<ItemLineCount> items) {
            List<ItemLineCount> output = new List<ItemLineCount>(items.Count);

            if (Directory.Type != NodeType.Solution) {
                items.SortAndAdd(output, item => item.IsDirectory());
                items.SortAndAdd(output, item => item.IsFile());
            } else {
                ProjectType[] projectTypeOrder = {
                    ProjectType.DesktopApplication,
                    ProjectType.ConsoleApplication,
                    ProjectType.Unknown,
                    ProjectType.ClassLibrary };
                
                projectTypeOrder.ForEach(projectType => items.SortAndAdd(output, item => ((ProjectLineCount)item).ProjectType == projectType));
            }

            return output;
        }

        public bool Equals(DirectoryLineCount other) {
            return Directory.Equals(other);
        }
    }
}
