using System.Collections.Generic;

namespace Core.Entities.Repeats
{
    public class MultiRepeat : Repeat
    {
        public IReadOnlyList<int> Repeats { get; init; }
    }
}