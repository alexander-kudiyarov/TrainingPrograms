using System.Collections.Generic;
using Kudiyarov.TrainingPrograms.Entities.Entities.Exercises;

namespace Kudiyarov.TrainingPrograms.Entities.Entities
{
    public class Round
    {
        // TODO split to single-multi
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