using Kudiyarov.TrainingPrograms.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Entities.Exercises;

public sealed class Deadlift : BaseSingleExercise
{
    public Deadlift(ExerciseType type) : base(Stats.Deadlift, type)
    {
    }

    public Deadlift(double weight, ExerciseType type) : base(weight, type)
    {
    }
}