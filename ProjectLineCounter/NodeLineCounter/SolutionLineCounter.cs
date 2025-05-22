using System;
using System.IO;

namespace ProjectLineCounter {
    public class SolutionLineCounter : INodeLineCounter {
        public INodeLineCounter ProjectLineCounter { get; set; }
        public INodeValidator ProjectValidator { get; set; }

        public SolutionLineCounter() {
            ProjectLineCounter = new ProjectLineCounter();
            ProjectValidator = new ProjectValidator();
        }

        public ItemLineCount Count(string directory) {
            if (!Directory.Exists($"{directory}\\.vs")) return ProjectLineCounter.Count(directory);

            string[] subDirectories = Directory.GetDirectories(directory);

            DirectoryLineCount directoryLineCount = new DirectoryLineCount(directory, NodeType.Solution);
            foreach (var subDirectory in subDirectories) {
                if (ProjectValidator.IsValid(subDirectory)) {
                    var item = ProjectLineCounter.Count(subDirectory);
                    item.Parent = directoryLineCount;

                    directoryLineCount.Items.Add(item);
                }
            }

            return directoryLineCount;
        }
    }
}
