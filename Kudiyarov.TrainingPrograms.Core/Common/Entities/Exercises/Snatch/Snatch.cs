using Kudiyarov.TrainingPrograms.Core.Common.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Core.Common.Entities.Exercises.Snatch
{
    public sealed class Snatch : BaseSingleExercise
    {
        public Snatch(ExerciseType type) : base(Stats.Snatch, type)
        {
        }

        public Snatch(double? weight, ExerciseType type) : base(weight, type)
        {
        }
    }
}