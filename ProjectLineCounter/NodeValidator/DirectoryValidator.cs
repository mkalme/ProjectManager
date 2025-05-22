using System;
using System.IO;

namespace ProjectLineCounter {
    public class DirectoryValidator : INodeValidator {
        public bool IsValid(string directory) {
            string directoryName = Path.GetFileName(directory);

            return directoryName != "bin" && directoryName != "obj";
        }
    }
}
