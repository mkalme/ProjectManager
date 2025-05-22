using System;
using System.IO;
using System.Linq;

namespace ProjectLineCounter {
    public class ProjectValidator : INodeValidator {
        public bool IsValid(string projectDirectory) {
            if (projectDirectory.EndsWith(".vs")) return false;

            return Directory.GetFiles(projectDirectory).Where(x => x.EndsWith(".csproj")).Count() > 0;
        }
    }
}
