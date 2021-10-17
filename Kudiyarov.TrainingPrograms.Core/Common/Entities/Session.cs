using System.Collections.Generic;

namespace Kudiyarov.TrainingPrograms.Core.Common.Entities
{
    public class Session
    {
        public int Day { get; set; }
        public IReadOnlyList<Round> Rounds { get; init; }
    }
}