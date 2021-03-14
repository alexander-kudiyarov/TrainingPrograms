using System.Linq;
using Core.Entities.Enums;

namespace Core.Entities.Exercises
{
    public class CleanAndJerk : BaseExercise
    {
        private readonly ExerciseType[] _types;

        public CleanAndJerk(params ExerciseType[] types) : base(Stats.CleanAndJerk)
        {
            _types = types;
        }

        public CleanAndJerk(double weight, params ExerciseType[] types) : base(weight)
        {
            _types = types;
        }

        public override string Name
            => string.Join(" + ", _types.Select(GetName));
    }
}