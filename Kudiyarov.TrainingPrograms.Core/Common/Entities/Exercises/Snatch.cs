using System.Linq;
using Kudiyarov.TrainingPrograms.Core.Common.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Core.Common.Entities.Exercises
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
            => string.Join(" + ", _types.Select(GetName));
    }
}