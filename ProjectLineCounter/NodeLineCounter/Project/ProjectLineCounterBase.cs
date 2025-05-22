using System;
using System.IO;

namespace ProjectLineCounter {
    public class ProjectLineCounterBase : INodeLineCounter {
        public INodeValidator DirectoryValidator { get; set; }
        public INodeValidator FileValidator { get; set; }
        public INodeLineCounter FileLineCounter { get; set; }

        public ProjectLineCounterBase() {
            DirectoryValidator = new DirectoryValidator();
            FileValidator = new FileValidator();
            FileLineCounter = new FileLineCounter();
        }

        public ItemLineCount Count(string directory) {
            ProjectLineCount output = new ProjectLineCount(directory, NodeType.Project);
            CountDirectory(directory, output, true);

            return output;
        }

        private void CountDirectory(string directory, DirectoryLineCount output, bool isTopDirectory = false) {
            string[] subDirectories = Directory.GetDirectories(directory);
            string[] files = Directory.GetFiles(directory);

            foreach (var subDirectory in subDirectories) {
                if (isTopDirectory && !DirectoryValidator.IsValid(subDirectory)) continue;

                DirectoryLineCount subDirectoryOutput = new DirectoryLineCount(subDirectory, NodeType.Folder);
                CountDirectory(subDirectory, subDirectoryOutput);

                if (subDirectoryOutput.Items.Count > 0) {
                    subDirectoryOutput.Parent = output;
                    output.Items.Add(subDirectoryOutput);
                }
            }

            foreach (var file in files) {
                if (FileValidator.IsValid(file)) {
                    var item = FileLineCounter.Count(file);
                    item.Parent = output;

                    output.Items.Add(item);
                }
            }
        }
    }
}
