using System.Collections.Generic;
using Core.Entities.Exercises.Enums;

namespace Core.Entities.Exercises
{
    public abstract class BaseExercise
    {
        protected BaseExercise(double? baseWeight)
        {
            BaseWeight = baseWeight;
        }

        public abstract string Name { get; }

        public abstract EquipmentType EquipmentType { get; }

        public double? BaseWeight { get; }

        public IList<Repeat> Repeats { get; set; }

        public bool IsWarmupNeeded { get; set; }
    }
}