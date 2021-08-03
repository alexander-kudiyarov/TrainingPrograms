using Core.Entities.Enums;

namespace Core.Entities.Exercises
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