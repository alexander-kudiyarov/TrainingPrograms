using Kudiyarov.TrainingPrograms.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Entities.Exercises.Snatch;

public sealed class MultiSnatch : BaseMultiExercise
{
    public MultiSnatch(params ExerciseType[] types) : base(Stats.Snatch, types)
    {
    }

    public MultiSnatch(double weight, params ExerciseType[] types) : base(weight, types)
    {
    }
}