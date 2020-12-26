using System;
using Core.Entities.Enums;
using Core.Entities.Enums.Exercises;

namespace Core.Entities.Exercises
{
    public class Accessory : BaseExercise
    {
        private readonly AccessoryType _type;

        public Accessory(AccessoryType type) : base(GetWeight(type))
        {
            _type = type;
        }

        public override string Name => _type switch
        {
            // Back Squat
            AccessoryType.BackSplitSquat => "Back Split Squat",
            AccessoryType.GakkSquat => "Gakk Squat",

            // Lunges
            AccessoryType.BackLunges => "Back Lunges",
            AccessoryType.ForwardLunges => "Forward Lunges",

            // Jumps
            AccessoryType.BoxJump => "Box Jump",

            // Calf
            AccessoryType.CalfRise => "Calf Rise",

            // Shoulders
            AccessoryType.DiscRearDeltFly => "Disc Rear Delt Fly",
            AccessoryType.Halo => "Halo",
            AccessoryType.LateralRaise => "Lateral Raise",

            // Back
            AccessoryType.Hyperextension => "Hyperextension",

            // Lateral
            AccessoryType.LateralPull => "Bar Lateral Pull",
            AccessoryType.LateralPullRg => "Bar Lateral Pull (Reverse Grip)",
            AccessoryType.DiscLateralPull => "Disc Lateral Pull",

            // Press
            AccessoryType.Press => "Press",
            AccessoryType.AsymmetryPress => "Asymmetry Press",
            AccessoryType.DiscPress => "Disc Press",
            AccessoryType.PressWithRubberBand => "Press (with Rubber Band)",
            AccessoryType.SittingPress => "Sitting Press",
            //AccessoryType.DiscBridgePress => "Disc Bridge Press",
            AccessoryType.DiscBridgePullover => "Disc Bridge Pullover",

            // Bench Press
            AccessoryType.BenchPress => "Bench Press",
            AccessoryType.AsymmetryBenchPress => "Asymmetry Bench Press",
            AccessoryType.InclineBenchPress => "Incline Bench Press",
            AccessoryType.InclineBenchPressNg => "Incline Bench Press (Narrow Grip)",
            AccessoryType.InclineBenchPressWg => "Incline Bench Press (Wide Grip)",
            AccessoryType.DeclineBenchPress => "Decline Bench Press",
            AccessoryType.SeatedBenchPress => "Seated Bench Press",

            // Push Up
            AccessoryType.PushUp => "Push Up",
            AccessoryType.ReversePushUp => "Reverse Push Up",
            AccessoryType.WidePushUp => "Wide Push Up",

            // Biceps
            AccessoryType.BicepsCurl => "Biceps Curl",
            AccessoryType.BicepsCurlReverseGrip => "Biceps Curl (Reverse Grip)",
            AccessoryType.DiscHammerCurls => "Disc Hammer Curls",

            // Triceps
            AccessoryType.FrenchPress => "French Press",
            AccessoryType.DumbbellFrenchPress => "Dumbbell French Press",
            AccessoryType.TricepsExtension => "Triceps Extension",

            // Wrists
            AccessoryType.DiscJuggling => "Disc Juggling",
            AccessoryType.WristFlexion => "Wrist Flexion",
            AccessoryType.WristRoll => "Wrist Roll",

            // Pull Up
            AccessoryType.PullUp => "Pull Up",
            AccessoryType.ChinUp => "Chin Up",

            // ABS
            AccessoryType.Crunch => "Crunch",
            AccessoryType.Plank => "Plank",
            AccessoryType.MilitaryPlank => "Military Plank",
            AccessoryType.ReversePlank => "Reverse Plank",

            // Accessory
            AccessoryType.SingleLegReach => "Single Leg Reach",
            AccessoryType.SquatReach => "Squat Reach",
            AccessoryType.DiscFrontRise => "Disc Front Rise",
            AccessoryType.DiscRussianTwist => "Disc Russian Twist",

            // None
            _ => throw new ArgumentException()
        };

        public EquipmentType EquipmentType => _type switch
        {
            AccessoryType.DumbbellFrenchPress => EquipmentType.Dumbbell,
            _ => EquipmentType.Barbell
        };

        private static double? GetWeight(AccessoryType type)
        {
            return type switch
            {
                // Back Squat
                AccessoryType.BackSplitSquat => Stats.BackSplitSquat,

                // Lunges
                AccessoryType.BackLunges => Stats.Lunges,
                AccessoryType.ForwardLunges => Stats.Lunges,

                // Back
                AccessoryType.LateralPull => Stats.LateralPull,
                AccessoryType.LateralPullRg => Stats.LateralPull,

                // Press
                AccessoryType.Press => Stats.Press,
                AccessoryType.AsymmetryPress => Stats.Press,
                AccessoryType.PressWithRubberBand => Stats.Press,
                AccessoryType.SittingPress => Stats.Press,

                // Bench Press
                AccessoryType.BenchPress => Stats.BenchPress,
                AccessoryType.AsymmetryBenchPress => Stats.BenchPress,
                AccessoryType.InclineBenchPress => Stats.InclineBenchPress,
                AccessoryType.InclineBenchPressNg => Stats.BackSquat * 0.54,
                AccessoryType.InclineBenchPressWg => Stats.BackSquat * 0.54,
                AccessoryType.DeclineBenchPress => Stats.BenchPress * 1.1,
                AccessoryType.SeatedBenchPress => Stats.BenchPress,
                AccessoryType.DiscPress => Stats.Press * 0.45,

                // Hands
                AccessoryType.BicepsCurl => Stats.BicepsCurl,
                AccessoryType.DiscHammerCurls => Stats.BicepsCurl,
                AccessoryType.BicepsCurlReverseGrip => Stats.BicepsCurlRg,
                AccessoryType.FrenchPress => Stats.FrenchPress,
                AccessoryType.DumbbellFrenchPress => Stats.FrenchPress * 0.45,

                // Pull Up
                AccessoryType.PullUp => Stats.PullUp,
                AccessoryType.ChinUp => Stats.PullUp,

                // None
                _ => null
            };
        }
    }
}