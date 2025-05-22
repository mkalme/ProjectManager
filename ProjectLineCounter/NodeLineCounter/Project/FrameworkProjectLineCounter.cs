using System;

namespace ProjectLineCounter {
    public class FrameworkProjectLineCounter : ProjectLineCounterBase {
        public FrameworkProjectLineCounter() : base() {
            FileValidator = new FileValidator() {
                Framework = FrameworkType.Framework
            };
        }
    }
}
