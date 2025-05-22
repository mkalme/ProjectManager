using System;

namespace ProjectLineCounter {
    public interface IProjectTypeDeterminer<TType, TInput> {
        TType DetermineType(TInput input);
    }
}
