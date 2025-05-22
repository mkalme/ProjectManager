using System;
using System.Collections.Generic;
using System.ComponentModel;
using ProjectLineCounter;

namespace ProjectManager {
    public class ViewCollection : IView {
        public IDictionary<ViewType, IView> Views { get; set; }
        public ViewType CurrentViewType { get; set; }
        public IView CurrentView => Views[CurrentViewType];

        public DirectoryLineCount BaseDirectory { get; set; }

        public DirectoryLineCount Directory => CurrentView.Directory;
        public ICollection<ItemLineCount> SelectedItems {
            get => CurrentView.SelectedItems;
            set => CurrentView.SelectedItems = value;
        }

        public int SortedColumnIndex {
            get => CurrentView.SortedColumnIndex;
            set => CurrentView.SortedColumnIndex = value;
        }
        public ListSortDirection SortOrder {
            get => CurrentView.SortOrder;
            set => CurrentView.SortOrder = value;
        }

        public ViewCollection(DirectoryLineCount directory, ViewType viewType) {
            BaseDirectory = directory;
            CurrentViewType = viewType;

            Views = new Dictionary<ViewType, IView>() {
                { viewType, CreateView(directory, viewType) }
            };
        }

        public void SetViewType(ViewType viewType) {
            CurrentViewType = viewType;

            if (!Views.ContainsKey(viewType)) {
                Views.Add(viewType, CreateView(BaseDirectory, viewType));
            }
        }

        private static IView CreateView(DirectoryLineCount directory, ViewType viewType) {
            if (viewType == ViewType.Project) {
                return new View(directory);
            } else {
                List<ItemLineCount> items = new List<ItemLineCount>();
                ExtractAllFiles(directory, items);

                DirectoryLineCount fileDirectory = directory.CreateShallowCopy() as DirectoryLineCount;
                fileDirectory.Items = items;
                fileDirectory.Type = NodeType.Collection;

                return new View(fileDirectory) {
                    SortedColumnIndex = 3
                };
            }
        }
        private static void ExtractAllFiles(DirectoryLineCount source, IList<ItemLineCount> output) {
            foreach (var item in source.Items) {
                if (item.IsFile()) output.Add(item);
                else if (item.IsDirectory()) ExtractAllFiles(item as DirectoryLineCount, output);
            }
        }

        public bool Equals(DirectoryLineCount other) {
            return BaseDirectory.Equals(other);
        }
    }
}
