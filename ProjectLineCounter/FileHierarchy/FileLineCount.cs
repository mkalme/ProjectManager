using System;

namespace ProjectLineCounter {
    public class FileLineCount : ItemLineCount {
        public override int LineCount { get; }

        public FileLineCount(string path, int lineCount) : base(path, NodeType.SourceFile) {
            LineCount = lineCount;
        }

        public override object Clone() {
            return new FileLineCount(Path, LineCount) {
                Parent = Parent
            };
        }
    }
}
