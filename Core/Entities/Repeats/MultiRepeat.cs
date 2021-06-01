using System.Collections.Generic;

namespace Core.Entities.Repeats
{
    public class MultiRepeat : Repeat
    {
        public IList<int> Repeats { get; init; }
    }
}