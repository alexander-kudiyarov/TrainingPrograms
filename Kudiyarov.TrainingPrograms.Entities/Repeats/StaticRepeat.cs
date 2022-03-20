using NodaTime;

namespace Kudiyarov.TrainingPrograms.Entities.Repeats;

public class StaticRepeat : Repeat
{
    public Duration Duration { get; init; }
}