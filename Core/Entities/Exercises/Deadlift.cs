using System;
using Core.Entities.Enums.Exercises;

namespace Core.Entities.Exercises
{
    public class Deadlift : BaseExercise
    {
        private readonly DeadliftType _type;

        public Deadlift(DeadliftType type) : base(Stats.Deadlift)
        {
            _type = type;
        }

        public Deadlift(double baseWeight, DeadliftType type) : base(baseWeight)
        {
            _type = type;
        }

        public override string Name => _type switch
        {
            DeadliftType.BaseDeadlift => "Deadlift",
            DeadliftType.AsymmetryDeadlift => "Asymmetry Deadlift",
            DeadliftType.DeficitDeadlift => "Deficit Deadlift",
            DeadliftType.RomanianDeadlift => "Romanian Deadlift",
            DeadliftType.SnatchDeadlift => "Snatch Deadlift",
            _ => throw new ArgumentOutOfRangeException(nameof(_type), "Type is not defined")
        };
    }
}