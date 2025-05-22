using System;
using System.Collections.Generic;
using System.ComponentModel;
using ProjectLineCounter;

namespace ProjectManager {
    public interface IView : IEquatable<DirectoryLineCount> {
        DirectoryLineCount Directory { get; }
        ICollection<ItemLineCount> SelectedItems { get; set; }

        int SortedColumnIndex { get; set; }
        ListSortDirection SortOrder { get; set; }
    }
}
