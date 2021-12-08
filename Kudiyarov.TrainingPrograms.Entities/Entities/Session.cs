namespace Kudiyarov.TrainingPrograms.Entities.Entities;

public class Session
{
    public int Day { get; set; }
    public IReadOnlyList<Round> Rounds { get; init; }
}