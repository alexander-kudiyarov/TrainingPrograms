using Kudiyarov.TrainingPrograms.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Entities.Exercises.CleanAndJerk;

public sealed class MultiCleanAndJerk : BaseMultiExercise
{
    public MultiCleanAndJerk(params ExerciseType[] types) : base(Stats.CleanAndJerk, types)
    {
    }

    public MultiCleanAndJerk(double weight, params ExerciseType[] types) : base(weight, types)
    {
    }
}