using System.Collections.Generic;
using Core.Entities.Exercises;

namespace Core.Entities
{
    public class Round
    {
        public Round(params BaseExercise[] exercises) : this(1, exercises)
        {
        }

        public Round(int rounds, params BaseExercise[] exercises)
        {
            Rounds = rounds;
            Exercises = exercises;
        }

        public int Rounds { get; }
        public IReadOnlyList<BaseExercise> Exercises { get; }
    }
}