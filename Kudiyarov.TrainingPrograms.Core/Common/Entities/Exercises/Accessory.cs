using Kudiyarov.TrainingPrograms.Core.Common.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Core.Common.Entities.Exercises
{
    public class Accessory : BaseExercise
    {
        private readonly ExerciseType _type;

        public Accessory(ExerciseType type) : base(GetWeight(type))
        {
            _type = type;
        }

        public override string Name => GetName(_type);

        public EquipmentType EquipmentType => _type switch
        {
            ExerciseType.DumbbellFrenchPress => EquipmentType.Dumbbell,
            _ => EquipmentType.Barbell
        };

        private static double? GetWeight(ExerciseType type)
        {
            return type switch
            {
                // Back Squat
                ExerciseType.BackSplitSquat => Stats.BackSplitSquat,

                // Lunges
                ExerciseType.BackLunges => Stats.Lunges,
                ExerciseType.ForwardLunges => Stats.Lunges,

                // Back
                ExerciseType.LateralPull => Stats.LateralPull,
                ExerciseType.LateralPullReverseGrip => Stats.LateralPull,

                // Press
                ExerciseType.Press => Stats.Press,
                ExerciseType.AsymmetryPress => Stats.Press,
                ExerciseType.PressWithRubberBand => Stats.Press,
                ExerciseType.SittingPress => Stats.Press,

                // Bench Press
                ExerciseType.BenchPress => Stats.BenchPress,
                ExerciseType.AsymmetryBenchPress => Stats.BenchPress,
                ExerciseType.InclineBenchPress => Stats.InclineBenchPress,
                ExerciseType.InclineBenchPressNarrowGrip => Stats.BackSquat * 0.54,
                ExerciseType.InclineBenchPressWideGrip => Stats.BackSquat * 0.54,
                ExerciseType.DeclineBenchPress => Stats.BenchPress * 1.1,
                ExerciseType.SeatedBenchPress => Stats.BenchPress,
                ExerciseType.DiscPress => Stats.Press * 0.45,

                // Hands
                ExerciseType.BicepsCurl => Stats.BicepsCurl,
                ExerciseType.DiscHammerCurls => Stats.BicepsCurl,
                ExerciseType.BicepsCurlReverseGrip => Stats.BicepsCurlRg,
                ExerciseType.FrenchPress => Stats.FrenchPress,
                ExerciseType.DumbbellFrenchPress => Stats.FrenchPress * 0.45,

                // Pull Up
                ExerciseType.PullUp => Stats.PullUp,
                ExerciseType.ChinUp => Stats.PullUp,

                // None
                _ => null
            };
        }
    }
}