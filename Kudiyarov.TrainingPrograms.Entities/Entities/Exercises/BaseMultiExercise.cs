using System.Linq;
using Kudiyarov.TrainingPrograms.Entities.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Entities.Entities.Exercises;

public abstract class BaseMultiExercise : BaseExercise
{
    private readonly ExerciseType[] _types;

    protected BaseMultiExercise(double? weight, ExerciseType[] types) : base(weight)
    {
        _types = types;
    }

    public override string Name => string.Join(" + ", _types.Select(GetName));
}