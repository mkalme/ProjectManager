using System;

namespace ProjectLineCounter {
    public interface INodeValidator {
        bool IsValid(string node);
    }
}
