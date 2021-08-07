using Kudiyarov.TrainingPrograms.Core.Common.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Core.Common.Entities.Exercises
{
    public class BackSquat : BaseExercise
    {
        private readonly ExerciseType _type;

        public BackSquat(ExerciseType type) : base(Stats.BackSquat)
        {
            _type = type;
        }

        public BackSquat(double weight, ExerciseType type) : base(weight)
        {
            _type = type;
        }

        public override string Name => GetName(_type);
    }
}