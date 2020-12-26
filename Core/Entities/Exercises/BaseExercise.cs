using System.Collections.Generic;

namespace Core.Entities.Exercises
{
    public abstract class BaseExercise
    {
        protected BaseExercise(double? weight)
        {
            Weight = weight;
        }

        public abstract string Name { get; }

        public double? Weight { get; }

        public IList<Repeat> Repeats { get; set; }

        public bool IsWarmupNeeded { get; set; }
    }
}