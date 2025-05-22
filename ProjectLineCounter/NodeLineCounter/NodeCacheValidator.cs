using System;
using System.Collections.Generic;
using System.IO;

namespace ProjectLineCounter {
    public class NodeCacheValidator : INodeValidator {
        public INodeValidator NodeValidator { get; set; }
        public ISet<string> FileCache { get; set; }
        public bool IsDirectory { get; set; }

        public NodeCacheValidator(INodeValidator nodeValidator, ISet<string> fileCache, bool isDirectory) {
            NodeValidator = nodeValidator;
            FileCache = fileCache;
            IsDirectory = isDirectory;
        }

        public bool IsValid(string node) {
            if (IsDirectory) {
                FileCache.ExceptWith(Directory.GetFiles(node, "*.cs", SearchOption.AllDirectories));
            } else {
                FileCache.Remove(node);
            }

            return NodeValidator.IsValid(node);
        }
    }
}
