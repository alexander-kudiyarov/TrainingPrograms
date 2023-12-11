using Kudiyarov.TrainingPrograms.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Entities.Exercises;

public sealed class MultiAccessory : BaseMultiExercise
{
    public MultiAccessory(params ExerciseType[] types) : base(null, types)
    {
    }
}