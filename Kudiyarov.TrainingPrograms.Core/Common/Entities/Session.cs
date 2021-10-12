using System;
using System.Collections.Generic;

namespace Kudiyarov.TrainingPrograms.Core.Common.Entities
{
    public class Session
    {
        public static Session Empty => new()
        {
            Rounds = Array.Empty<Round>()
        };
        
        public int Day { get; set; }
        public IReadOnlyList<Round> Rounds { get; init; }
    }
}