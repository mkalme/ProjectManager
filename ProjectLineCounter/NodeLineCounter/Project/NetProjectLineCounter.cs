using System;

namespace ProjectLineCounter {
    public class NetProjectLineCounter : ProjectLineCounterBase {
        public NetProjectLineCounter() : base() {
            FileValidator = new FileValidator() {
                Framework = FrameworkType.Net
            };
        }
    }
}
