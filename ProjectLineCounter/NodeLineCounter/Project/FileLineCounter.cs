using System;
using System.IO;

namespace ProjectLineCounter {
    public class FileLineCounter : INodeLineCounter {
        public ItemLineCount Count(string file) {
            return new FileLineCount(file, File.ReadAllLines(file).Length);
        }
    }
}
