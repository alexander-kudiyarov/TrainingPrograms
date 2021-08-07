using Kudiyarov.TrainingPrograms.Core.Common.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Core.Common.Entities.Exercises
{
    public class Deadlift : BaseExercise
    {
        private readonly ExerciseType _type;

        public Deadlift(ExerciseType type) : base(Stats.Deadlift)
        {
            _type = type;
        }

        public Deadlift(double weight, ExerciseType type) : base(weight)
        {
            _type = type;
        }

        public override string Name => GetName(_type);
    }
}