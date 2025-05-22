using System;
using System.Collections.Generic;

namespace ProjectLineCounter {
    public class ProjectLineCount : DirectoryLineCount {
        public ProjectType ProjectType { get; set; }
        
        public ProjectLineCount(string path, NodeType nodeType) : base(path, nodeType) {

        }

        public override object CreateShallowCopy() {
            return new ProjectLineCount(Path, Type) {
                Items = new List<ItemLineCount>(),
                ProjectType = ProjectType,
                Parent = Parent
            };
        }

        public override object Clone() {
            ProjectLineCount directory = new ProjectLineCount(Path, Type);
            directory.ProjectType = ProjectType;
            directory.Items = ListHelper.CloneList(Items, directory);

            return directory;
        }
    }
}
