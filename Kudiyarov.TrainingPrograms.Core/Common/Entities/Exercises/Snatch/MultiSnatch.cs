using Kudiyarov.TrainingPrograms.Core.Common.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Core.Common.Entities.Exercises.Snatch
{
    public sealed class MultiSnatch : BaseMultiExercise
    {
        public MultiSnatch(params ExerciseType[] types) : base(Stats.Snatch, types)
        {
        }

        public MultiSnatch(double weight, params ExerciseType[] types) : base(weight, types)
        {
        }
    }
}