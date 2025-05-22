using System;
using System.Collections.Generic;

namespace ProjectManager {
    public static class CollectionExtensions {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action) {
            foreach (T value in source) {
                action(value);
            }
        }
        public static void SortAndAdd<T>(this IList<T> source, IList<T> output, Func<T, bool> matcher) {
            foreach (T value in source) {
                if (matcher(value)) output.Add(value);
            }
        }
        public static int IndexOf<T>(this IEnumerable<T> source, Func<T, bool> matcher) {
            int index = 0;

            foreach (T value in source) {
                if (matcher(value)) return index;
                index++;
            }
            
            return -1;
        }
    }
}
