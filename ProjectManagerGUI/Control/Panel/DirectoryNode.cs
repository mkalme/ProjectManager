using System;
using System.IO;
using ProjectLineCounter;
using CustomDialogs;

namespace ProjectManagerGUI {
    public class DirectoryNode : INode {
        public DirectoryLineCount Directory { get; set; }

        public INode Parent {
            get {
                if (_parent == null && Directory.Parent != null) {
                    _parent = new DirectoryNode(Directory.Parent);
                }

                return _parent;
            }
        }
        private INode _parent;

        public object Node => Directory;
        public string DisplayedText => Path.GetFileName(Directory.Path);

        public event EventHandler DisplayedTextChanged;

        public DirectoryNode(DirectoryLineCount directory) {
            Directory = directory;
        }
    }
}
