using System;
using System.IO;

namespace ProjectLineCounter {
    public class FileValidator : INodeValidator {
        public FrameworkType Framework { get; set; }

        public bool IsValid(string file) {
            string fileName = Path.GetFileName(file);

            if (Framework == FrameworkType.Framework && fileName == "AssemblyInfo.cs") return false;

            return fileName.EndsWith(".cs") && !fileName.EndsWith(".Designer.cs");
        }
    }
}
