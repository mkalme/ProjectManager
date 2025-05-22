using System;
using System.Collections.Generic;

namespace ProjectLineCounter {
    static class ListHelper {
        public static IList<ItemLineCount> CloneList(IList<ItemLineCount> source, DirectoryLineCount parent) {
            var newItems = new List<ItemLineCount>(source.Count);
            
            foreach (var item in source) {
                var newItem = item.Clone() as ItemLineCount;
                newItem.Parent = parent;

                newItems.Add(newItem);
            }

            return newItems;
        }
    }
}
