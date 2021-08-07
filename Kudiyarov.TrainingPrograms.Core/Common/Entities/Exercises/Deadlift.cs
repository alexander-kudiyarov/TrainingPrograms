using Kudiyarov.TrainingPrograms.Core.Common.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Core.Common.Entities.Exercises
{
    public class Deadlift : BaseSingleExercise
    {
        public Deadlift(ExerciseType type) : base(Stats.Deadlift, type)
        {
        }

        public Deadlift(double weight, ExerciseType type) : base(weight, type)
        {
        }
    }
}