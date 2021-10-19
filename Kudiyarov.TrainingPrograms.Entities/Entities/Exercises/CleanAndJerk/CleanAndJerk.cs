using Kudiyarov.TrainingPrograms.Entities.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Entities.Entities.Exercises.CleanAndJerk
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