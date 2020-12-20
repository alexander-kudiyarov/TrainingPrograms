using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entities.Exercises.Enums;

namespace Core.Entities.Exercises
{
    public class Snatch : BaseExercise
    {
        private readonly SnatchType[] _types;

        public Snatch(params SnatchType[] types) : base(Stats.Snatch)
        {
            _types = types;
        }

        public Snatch(double baseWeight, params SnatchType[] types) : base(baseWeight)
        {
            _types = types;
        }

        public override string Name => string.Join(" + ", GetNames(_types));

        public override EquipmentType EquipmentType => EquipmentType.Barbell;

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
                SnatchType.BaseSnatch => "Snatch",
                SnatchType.SnatchBalance => "Snatch Balance",
                SnatchType.SnatchPull => "Snatch Pull",
                SnatchType.SnatchPushPress => "Snatch Push Press",
                SnatchType.MediumGripPull => "Medium Grip Pull",
                SnatchType.DeficitMediumGripPull => "Medium Grip Pull (from Deficit)",
                _ => throw new ArgumentException()
            };

            return result;
        }
    }
}