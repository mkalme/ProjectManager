using System;
using System.Text;

namespace ProjectManager {
    public static class StringExtensions {
        public static string FindNearestMatch(this string value, string other) {
            int length = Math.Min(value.Length, other.Length);

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < length; i++) {
                char c1 = value[i];
                char c2 = other[i];

                if (c1 != c2) break;
                builder.Append(c1);
            }

            return builder.ToString();
        }
    }
}
