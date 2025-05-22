using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectLineCounter {
    public class DirectoryLineCount : ItemLineCount {
        public override int LineCount {
            get {
                int count = 0;

                Items.ToList().ForEach(x => count += x.LineCount);

                return count;
            }
        }

        public IList<ItemLineCount> Items { get; set; }

        public DirectoryLineCount(string path, NodeType type) : base(path, type) {
            Items = new List<ItemLineCount>();
        }

        public virtual object CreateShallowCopy() {
            return new DirectoryLineCount(Path, Type) {
                Items = new List<ItemLineCount>(),
                Parent = Parent
            };
        }

        public override object Clone() {
            DirectoryLineCount directory = new DirectoryLineCount(Path, Type);
            directory.Items = directory.Items = ListHelper.CloneList(Items, directory); ;

            return directory;
        }
    }
}
