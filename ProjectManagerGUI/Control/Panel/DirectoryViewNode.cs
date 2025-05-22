using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using ProjectLineCounter;
using CustomDialogs;

namespace ProjectManagerGUI {
    public class DirectoryViewNodeFacade : IViewNode {
        public object Node => Selected.Directory;
        public object Parent => Selected.Directory.Parent;
        public ICollection<object> Items => Selected.Items;

        public int SortedColumnIndex {
            get => Selected.SortedColumnIndex;
            set => Selected.SortedColumnIndex = value;
        }
        public ListSortDirection SortOrder {
            get => Selected.SortOrder;
            set => Selected.SortOrder = value;
        }

        public event EventHandler ContentsChanged;
        public event EventHandler Removed;

        public DirectoryView Selected { get; private set; }
        private DirectoryView _project;
        private DirectoryView _file;

        public DirectoryViewNodeFacade(DirectoryLineCount directory) {
            _project = new DirectoryView(directory, ViewType.Project);
            Selected = _project;
        }

        public void SetType(ViewType viewType) {
            DirectoryView view;

            if (viewType == ViewType.File) {
                if (_file == null) {
                    view = new DirectoryView(Selected.Directory, viewType);
                    _file = view;
                } else {
                    view = _file;
                }
            } else {
                if (_project == null) {
                    view = new DirectoryView(Selected.Directory, viewType);
                    _project = view;
                } else {
                    view = _project;
                }
            }
            Selected = view;

            ContentsChanged?.Invoke(this, EventArgs.Empty);
        }
        public void SetNewView(IList<ItemLineCount> items) {
            _project.Directory.Items = items;
            _project = new DirectoryView(_project.Directory, ViewType.Project) { 
                SortedColumnIndex = -1
            };

            Selected = _project;
            _file = null;

            ContentsChanged?.Invoke(this, EventArgs.Empty);
        }

        public IViewNode CreateNode(object directory) => new DirectoryViewNodeFacade(directory as DirectoryLineCount);
    }

    public class DirectoryView {
        public DirectoryLineCount Directory { get; set; }
        public ICollection<object> Items { get; set; }
        public IList<object> SelectedItems { get; set; } = new List<object>();

        public int SortedColumnIndex { get; set; }
        public ListSortDirection SortOrder { get; set; }

        public ViewType ViewType { get; set; }

        public DirectoryView(DirectoryLineCount directory, ViewType viewType) {
            Directory = directory;
            ViewType = viewType;

            if (ViewType == ViewType.File) {
                SortedColumnIndex = 2;
            }else if (directory.Type == NodeType.Collection) {
                SortedColumnIndex = 4;
            } else {
                SortedColumnIndex = -1;
            }
            SortOrder = ListSortDirection.Descending;

            if (viewType == ViewType.Project) {
                Items = directory.Items.Cast<object>().ToList();
            } else {
                List<ItemLineCount> items = new List<ItemLineCount>();
                ExtractAllFiles(directory, items);

                Items = items.Cast<object>().ToList();
            }
        }

        private static void ExtractAllFiles(DirectoryLineCount source, IList<ItemLineCount> output) {
            foreach (var item in source.Items) {
                if (item.IsFile()) output.Add(item);
                else if (item.IsDirectory()) ExtractAllFiles(item as DirectoryLineCount, output);
            }
        }
    }

    public enum ViewType {
        File,
        Project
    }
}
