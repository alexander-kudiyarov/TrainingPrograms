using System.Collections.Generic;

namespace Core.Entities.Repeats
{
    public class MultiRepeat : WeightedRepeat
    {
        public IList<int> Repeats { get; init; }
    }
}