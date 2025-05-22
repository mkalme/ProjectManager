using System;

namespace ProjectLineCounter {
    public abstract class ItemLineCount : ICloneable {
        public DirectoryLineCount Parent { get; set; }

        public string Path { get; }
        public NodeType Type { get; set; }

        public abstract int LineCount { get; }

        public ItemLineCount(string path, NodeType type) {
            Path = path;
            Type = type;
        }

        public abstract object Clone();
    }
}
