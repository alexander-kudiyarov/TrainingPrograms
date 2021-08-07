using Kudiyarov.TrainingPrograms.Core.Common.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Core.Common.Entities.Exercises.CleanAndJerk
{
    public class MultiCleanAndJerk : BaseMultiExercise
    {
        public MultiCleanAndJerk(params ExerciseType[] types) : base(Stats.CleanAndJerk, types)
        {
        }

        public MultiCleanAndJerk(double weight, params ExerciseType[] types) : base(weight, types)
        {
        }
    }
}