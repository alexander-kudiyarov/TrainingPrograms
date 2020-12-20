using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entities.Exercises.Enums;

namespace Core.Entities.Exercises
{
    public class CleanAndJerk : BaseExercise
    {
        private readonly CleanAndJerkType[] _types;

        public CleanAndJerk(params CleanAndJerkType[] types) : base(Stats.CleanAndJerk)
        {
            _types = types;
        }

        public CleanAndJerk(double baseWeight, params CleanAndJerkType[] types) : base(baseWeight)
        {
            _types = types;
        }

        public override string Name => string.Join(" + ", GetNames(_types));

        public override EquipmentType EquipmentType => EquipmentType.Barbell;

        private static IEnumerable<string> GetNames(IEnumerable<CleanAndJerkType> types)
        {
            var result = types.Select(GetName);
            return result;
        }

        private static string GetName(CleanAndJerkType type)
        {
            var result = type switch
            {
                // Clean
                CleanAndJerkType.Clean => "Clean",
                CleanAndJerkType.PowerClean => "Power Clean",
                CleanAndJerkType.PowerCleanBelowKnee => "Power Clean (Below Knee)",
                CleanAndJerkType.HangClean => "Hang Clean",
                CleanAndJerkType.HangPowerClean => "Hang Power Clean",
                CleanAndJerkType.CleanPull => "Clean Pull",
                CleanAndJerkType.CleanPullTillPowerPosition => "Clean Pull Till Power Position",
                CleanAndJerkType.MuscleSquatClean => "Muscle Squat Clean",
                CleanAndJerkType.DeficitClean => "Deficit Clean",

                // Jerk
                CleanAndJerkType.Jerk => "Jerk",
                CleanAndJerkType.PushPress => "Push Press",

                // Front Squat
                CleanAndJerkType.FrontSquat => "Front Squat",
                _ => throw new ArgumentException("Unsupported Type", nameof(type))
            };

            return result;
        }
    }
}