using System.Collections.Generic;
using System.Linq;
using Core.Entities.Enums;

namespace Core.Entities.Exercises
{
    public class Snatch : BaseExercise
    {
        private readonly ExerciseType[] _types;

        public Snatch(params ExerciseType[] types) : base(Stats.Snatch)
        {
            _types = types;
        }

        public Snatch(double weight, params ExerciseType[] types) : base(weight)
        {
            _types = types;
        }

        public override string Name
            => string.Join(" + ", GetNames(_types));

        private static IEnumerable<string> GetNames(IEnumerable<ExerciseType> types)
            => types.Select(GetName);
    }
}