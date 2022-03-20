using Kudiyarov.TrainingPrograms.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Entities.Requests;

public class SessionRequest
{
    public ProgramType ProgramType { get; init; }
    public int Day { get; init; }

    public override bool Equals(object? other)
    {
        return other is SessionRequest request
               && Equals(request);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(ProgramType, Day);
    }

    private bool Equals(SessionRequest other)
    {
        return ProgramType == other.ProgramType
               && Day == other.Day;
    }
}