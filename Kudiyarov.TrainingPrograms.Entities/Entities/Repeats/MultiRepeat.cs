using System.Collections.Generic;

namespace Kudiyarov.TrainingPrograms.Core.Common.Entities.Repeats
{
    public class MultiRepeat : Repeat
    {
        public IReadOnlyList<int> Repeats { get; init; }
    }
}