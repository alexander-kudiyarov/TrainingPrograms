using System.Collections.Generic;

namespace Kudiyarov.TrainingPrograms.Entities.Entities.Repeats
{
    public class MultiRepeat : Repeat
    {
        public IReadOnlyList<int> Repeats { get; init; }
    }
}