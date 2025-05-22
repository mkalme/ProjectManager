using System;
using System.Collections.Generic;

namespace ProjectManagerGUI {
    public static class CollectionExtensions {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action) {
            foreach (T value in source) {
                action(value);
            }
        }
        public static void Change<T>(this ICollection<T> source, IEnumerable<T> enumerable) {
            source.Clear();

            foreach (var item in enumerable) {
                source.Add(item);
            }
        }
    }
}
