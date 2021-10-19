using Kudiyarov.TrainingPrograms.Core.Common.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Core.Common.Entities.Exercises.CleanAndJerk
{
    public sealed class CleanAndJerk : BaseSingleExercise
    {
        public CleanAndJerk(ExerciseType type) : base(Stats.CleanAndJerk, type)
        {
        }

        public CleanAndJerk(double weight, ExerciseType type) : base(weight, type)
        {
        }
    }
}