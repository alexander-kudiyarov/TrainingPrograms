using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entities.Enums.Exercises;

namespace Core.Entities.Exercises
{
    public class Snatch : BaseExercise
    {
        private readonly SnatchType[] _types;

        public Snatch(params SnatchType[] types) : base(Stats.Snatch)
        {
            _types = types;
        }

        public Snatch(double weight, params SnatchType[] types) : base(weight)
        {
            _types = types;
        }

        public override string Name => string.Join(" + ", GetNames(_types));

        private static IEnumerable<string> GetNames(IEnumerable<SnatchType> types)
        {
            var result = types.Select(GetName);
            return result;
        }

        private static string GetName(SnatchType type)
        {
            var result = type switch
            {
                SnatchType.HangPowerSnatch => "Hang Power Snatch",
                SnatchType.HangSnatch => "Hang Snatch",
                SnatchType.OverheadSquat => "Overhead Squat",
                SnatchType.PowerSnatch => "Power Snatch",
                SnatchType.HipSnatch => "Hip Snatch",
                SnatchType.BaseSnatch => "Snatch",
                SnatchType.SnatchBalance => "Snatch Balance",
                SnatchType.SnatchPull => "Snatch Pull",
                SnatchType.SnatchPushPress => "Snatch Push Press",
                SnatchType.MediumGripPull => "Medium Grip Pull",
                SnatchType.DeficitMediumGripPull => "Medium Grip Pull (from Deficit)",
                SnatchType.DeficitPowerSnatch => "Deficit Power Snatch",
                SnatchType.SotsPress => "Sots Press",
                SnatchType.MuscleSquatSnatch => "Muscle Squat Snatch",
                _ => throw new ArgumentOutOfRangeException(nameof(type), TypeErrorMessage)
            };

            return result;
        }
    }
}