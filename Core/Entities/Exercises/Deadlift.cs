using Core.Entities.Enums;

namespace Core.Entities.Exercises
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