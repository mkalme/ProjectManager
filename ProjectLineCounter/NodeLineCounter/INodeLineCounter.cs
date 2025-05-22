using System;

namespace ProjectLineCounter {
    public interface INodeLineCounter {
        ItemLineCount Count(string node);
    }
}
