using Kudiyarov.TrainingPrograms.Entities.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Entities.Entities.Exercises.Snatch;

public sealed class Snatch : BaseSingleExercise
{
    public Snatch(ExerciseType type) : base(Stats.Snatch, type)
    {
    }

    public Snatch(double? weight, ExerciseType type) : base(weight, type)
    {
    }
}