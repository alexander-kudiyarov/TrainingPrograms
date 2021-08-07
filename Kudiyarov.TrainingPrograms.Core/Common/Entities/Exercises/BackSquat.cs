using Kudiyarov.TrainingPrograms.Core.Common.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Core.Common.Entities.Exercises
{
    public class BackSquat : BaseSingleExercise
    {
        public BackSquat(ExerciseType type) : base(Stats.BackSquat, type)
        {
        }

        public BackSquat(double weight, ExerciseType type) : base(weight, type)
        {
        }
    }
}