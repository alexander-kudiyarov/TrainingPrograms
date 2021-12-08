using Kudiyarov.TrainingPrograms.Entities.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Entities.Entities.Exercises;

public sealed class BackSquat : BaseSingleExercise
{
    public BackSquat(ExerciseType type) : base(Stats.BackSquat, type)
    {
    }

    public BackSquat(double weight, ExerciseType type) : base(weight, type)
    {
    }
}