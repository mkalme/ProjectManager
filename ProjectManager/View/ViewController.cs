using System;
using System.Collections.Generic;
using ProjectLineCounter;

namespace ProjectManager {
    public class ViewController {
        public List<ViewCollection> Views { get; set; }

        public int CurrentViewIndex {
            get => _currentViewIndex;
            set {
                _currentViewIndex = value;
                ViewUpdate.Invoke(CurrentView, EventArgs.Empty);
            }
        }
        private int _currentViewIndex = 0;

        public ViewCollection CurrentView => Views[_currentViewIndex];

        public event EventHandler ViewUpdate;

        public ViewController(DirectoryLineCount directory) {
            Views = new List<ViewCollection>() { new ViewCollection(directory, ViewType.Project) };
        }

        public void OpenView(DirectoryLineCount directory) {
            int index = Views.IndexOf(x => x.Equals(directory));
            if (index > -1) {
                CurrentViewIndex = index;
                return;
            }

            if (CurrentViewIndex >= Views.Count - 1) {
                Views.Add(new ViewCollection(directory, ViewType.Project));
            } else if (!Views[CurrentViewIndex + 1].Directory.Equals(directory)) {
                Views.RemoveRange(CurrentViewIndex + 1, Views.Count - CurrentViewIndex - 1);
                Views.Add(new ViewCollection(directory, ViewType.Project));
            }

            CurrentViewIndex++;
        }

        public void SetNextView() {
            if (CurrentViewIndex >= Views.Count - 1) return;

            CurrentViewIndex++;
        }
        public void SetPreviousView() {
            if (CurrentViewIndex < 1) return;

            CurrentViewIndex--;
        }

        public void ChangeViewType(ViewType viewType) {
            CurrentView.SetViewType(viewType);

            ViewUpdate(CurrentView, EventArgs.Empty);
        }
        public void NewView(ICollection<ItemLineCount> selectedItems) {
            DirectoryLineCount directory = CurrentView.BaseDirectory;
            directory.Items = new List<ItemLineCount>(selectedItems);

            Views[_currentViewIndex] = new ViewCollection(directory, ViewType.Project);

            ViewUpdate(CurrentView, EventArgs.Empty);
        }

        public void Reset(DirectoryLineCount directory) {
            Views = new List<ViewCollection>() { new ViewCollection(directory, ViewType.Project) };
            CurrentViewIndex = 0;
        }
    }
}
