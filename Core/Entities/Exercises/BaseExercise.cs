using System;
using System.Collections.Generic;
using Core.Entities.Enums;
using Core.Entities.Repeats;

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
        public IReadOnlyList<Repeat> Repeats { get; init; }
        public bool IsWarmupNeeded { get; init; }

        // TODO extract to WebUi
        protected static string GetName(ExerciseType type)
        {
            // Exercises
            const string snatch = "Snatch";
            const string clean = "Clean";
            const string jerk = "Jerk";
            const string benchPress = "Bench Press";

            // Prefixes
            const string hang = "Hang";
            const string power = "Power";

            // Suffixes
            const string block = "(from Blocks)";
            const string aboveKnees = "(above Knees)";
            const string belowKnees = "(below Knees)";
            const string deficit = "(from Deficit)";
            const string pull = "Pull";
            const string pause = "(with Pause)";

            return type switch
            {
                // Snatch
                ExerciseType.Snatch => snatch,
                ExerciseType.DeficitMediumGripPull => $"Medium Grip {pull} {deficit}",
                ExerciseType.DeficitPowerSnatch => $"{power} {snatch} {deficit}",
                ExerciseType.DeficitSnatchPull => $"{snatch} {pull} {deficit}",
                ExerciseType.HangPowerSnatch => $"{hang} {power} {snatch}",
                ExerciseType.HangSnatchAboveKnees => $"{hang} {snatch} {aboveKnees}",
                ExerciseType.HangSnatchBelowKnees => $"{hang} {snatch} {belowKnees}",
                ExerciseType.HangSnatchPullAboveKnees => $"{hang} {snatch} {pull} {aboveKnees}",
                ExerciseType.HangSnatchPullBelowKnees => $"{hang} {snatch} {pull} {belowKnees}",
                ExerciseType.HipSnatch => $"Hip {snatch}",
                ExerciseType.MediumGripPull => $"Medium Grip {pull}",
                ExerciseType.MuscleSnatch => $"Muscle {snatch}",
                ExerciseType.MuscleSquatSnatch => $"Muscle Squat {snatch}",
                ExerciseType.OverheadSquat => "Overhead Squat",
                ExerciseType.PowerSnatch => $"{power} {snatch}",
                ExerciseType.SnatchBalance => $"{snatch} Balance",
                ExerciseType.SnatchFromBlocks => $"{snatch} {block}",
                ExerciseType.SnatchPull => $"{snatch} {pull}",
                ExerciseType.SnatchPushPress => $"{snatch} Push Press",
                ExerciseType.SotsPress => "Sots Press",

                // Clean
                ExerciseType.Clean => clean,
                ExerciseType.CleanFromBlocks => $"{clean} {block}",
                ExerciseType.CleanPull => $"{clean} {pull}",
                ExerciseType.CleanPullFromBlocks => $"{clean} {pull} {block}",
                ExerciseType.CleanPullSlowlyDown => $"{clean} {pull} (Slowly Down)",
                ExerciseType.CleanPullTillPowerPosition => $"{clean} {pull} Till Power Position",
                ExerciseType.DeficitClean => $"Clean {deficit}",
                ExerciseType.DeficitCleanPull => $"Clean {pull} {deficit}",
                ExerciseType.HangCleanBelowKnee => $"Hang {clean} Below Knee",
                ExerciseType.HangPowerClean => $"Hang {power} {clean}",
                ExerciseType.MuscleClean => $"Muscle {clean}",
                ExerciseType.MuscleSquatClean => $"Muscle Squat {clean}",
                ExerciseType.PowerClean => $"{power} {clean}",
                ExerciseType.PowerCleanBelowKnee => $"{power} {clean} Below Knee",

                // Jerk
                ExerciseType.Jerk => jerk,
                ExerciseType.JerkSupport => $"{jerk} Support",
                ExerciseType.PowerJerk => $"{power} {jerk}",
                ExerciseType.PushPress => "Push Press",

                // Front Squat
                ExerciseType.FrontSquat => "Front Squat",

                // Back Squat
                ExerciseType.BackSplitSquat => "Back Split Squat",
                ExerciseType.BackSquat => "Back Squat",
                ExerciseType.BackSquatWithPause => $"Back Squat {pause}",
                ExerciseType.BackSquatNarrowFeet => "Back Squat (Narrow Feet)",
                ExerciseType.BenchBackSquat => "Bench Back Squat",
                ExerciseType.GakkSquat => "Gakk Squat",

                // Deadlift
                ExerciseType.Deadlift => "Deadlift",
                ExerciseType.AsymmetryDeadlift => "Asymmetry Deadlift",
                ExerciseType.DeadliftFromBlocks => $"Deadlift {block}",
                ExerciseType.DeficitDeadlift => $"Deadlift {deficit}",
                ExerciseType.DeficitRomanianDeadlift => $"Romanian Deadlift {deficit}",
                ExerciseType.RomanianDeadlift => "Romanian Deadlift",
                ExerciseType.SnatchDeadlift => $"{snatch} Deadlift",

                // ABS
                ExerciseType.Crunch => "Crunch",
                ExerciseType.KneesToElbows => "Knees to Elbows",
                ExerciseType.MilitaryPlank => "Military Plank",
                ExerciseType.Plank => "Plank",
                ExerciseType.ReversePlank => "Reverse Plank",

                // Accessory
                ExerciseType.DiscFrontRise => "Disc Front Rise",
                ExerciseType.DiscRussianTwist => "Disc Russian Twist",
                ExerciseType.SingleLegReach => "Single Leg Reach",
                ExerciseType.SquatReach => "Squat Reach",

                // Back
                ExerciseType.DiscLateralPull => "Disc Lateral Pull",
                ExerciseType.Hyperextension => "Hyperextension",
                ExerciseType.LateralPull => "Lateral Pull",
                ExerciseType.LateralPullReverseGrip => "Lateral Pull Reverse Grip",
                ExerciseType.ReverseHyperextension => "Reverse Hyperextension",

                // Bench Press
                ExerciseType.AsymmetryBenchPress => $"Asymmetry {benchPress}",
                ExerciseType.BenchPress => benchPress,
                ExerciseType.DeclineBenchPress => $"Decline {benchPress}",
                ExerciseType.DiscBridgePullover => "Disc Bridge Pullover",
                ExerciseType.InclineBenchPress => $"Incline {benchPress}",
                ExerciseType.InclineBenchPressNarrowGrip => $"Incline {benchPress} Narrow Grip",
                ExerciseType.InclineBenchPressWideGrip => $"Incline {benchPress} Wide Grip",
                ExerciseType.SeatedBenchPress => $"Seated {benchPress}",

                // Biceps
                ExerciseType.BicepsCurl => "Biceps Curl",
                ExerciseType.BicepsCurlReverseGrip => "Biceps Curl Reverse Grip",
                ExerciseType.DiscHammerCurls => "Disc Hammer Curl",

                // Calf
                ExerciseType.CalfRise => "Calf Rise",

                // Good Morning
                ExerciseType.GoodMorning => "Good Morning",
                ExerciseType.GoodMorningSquat => "Good Morning + Squat",

                // Jumps
                ExerciseType.BarbellSquatJump => "Barbell Squat Jump",
                ExerciseType.BoxJump => "Box Jump",

                // Lunges
                ExerciseType.BackLunges => "Back Lunges",
                ExerciseType.ForwardLunges => "Forward Lunges",

                // Press
                ExerciseType.AsymmetryPress => "Asymmetry Press",
                ExerciseType.DiscPress => "Disc Press",
                ExerciseType.Press => "Press",
                ExerciseType.PressWithRubberBand => "Press With Rubber Band",
                ExerciseType.SittingPress => "Sitting Press",

                // Pull Up
                ExerciseType.ChinUp => "Chin Up",
                ExerciseType.PullUp => "Pull Up",

                // Push Up
                ExerciseType.PushUp => "Push Up",
                ExerciseType.ReversePushUp => "Reverse Push Up",
                ExerciseType.WidePushUp => "Wide Push Up",

                // Shoulders
                ExerciseType.ReverseFly => "Reverse Fly",
                ExerciseType.Halo => "Halo",
                ExerciseType.LateralRaise => "Lateral Raise",

                // Triceps
                ExerciseType.DumbbellFrenchPress => "Dumbbell French Press",
                ExerciseType.FrenchPress => "French Press",
                ExerciseType.TricepsExtension => "Triceps Extension",

                // Wrists
                ExerciseType.DiscJuggling => "Disc Juggling",
                ExerciseType.WristFlexion => "Wrist Flexion",
                ExerciseType.WristRoll => "Wrist Roll",

                _ => throw new ArgumentOutOfRangeException(nameof(type), "Type is not defined")
            };
        }
    }
}