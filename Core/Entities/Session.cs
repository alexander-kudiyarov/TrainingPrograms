using System.Collections.Generic;

namespace Core.Entities
{
    public class Session
    {
        public int Day { get; set; }
        public IReadOnlyList<Round> Rounds { get; init; }
    }
}