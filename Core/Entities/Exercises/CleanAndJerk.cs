using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entities.Enums.Exercises;

namespace Core.Entities.Exercises
{
    public class CleanAndJerk : BaseExercise
    {
        private readonly CleanAndJerkType[] _types;

        public CleanAndJerk(params CleanAndJerkType[] types) : base(Stats.CleanAndJerk)
        {
            _types = types;
        }

        public CleanAndJerk(double weight, params CleanAndJerkType[] types) : base(weight)
        {
            _types = types;
        }

        public override string Name => string.Join(" + ", GetNames(_types));

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
                CleanAndJerkType.HangCleanBelowKnee => "Hang Clean (Below Knee)",
                CleanAndJerkType.HangPowerClean => "Hang Power Clean",
                CleanAndJerkType.CleanPull => "Clean Pull",
                CleanAndJerkType.CleanPullTillPowerPosition => "Clean Pull Till Power Position",
                CleanAndJerkType.MuscleSquatClean => "Muscle Squat Clean",
                CleanAndJerkType.DeficitClean => "Deficit Clean",
                CleanAndJerkType.CleanFromBlocks => "Clean from Blocks",

                // Jerk
                CleanAndJerkType.Jerk => "Jerk",
                CleanAndJerkType.PowerJerk => "Power Jerk",
                CleanAndJerkType.PushPress => "Push Press",

                // Front Squat
                CleanAndJerkType.FrontSquat => "Front Squat",

                // Good Morning
                CleanAndJerkType.GoodMorning => "Good Morning",
                CleanAndJerkType.GoodMorningSquat => "Good Morning + Squat",
                
                // Romanian
                CleanAndJerkType.DeficitRomanianDeadlift => "Deficit Romanian Deadlift",
                
                _ => throw new ArgumentOutOfRangeException(nameof(type), TypeErrorMessage)
            };

            return result;
        }
    }
}