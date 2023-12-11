using Kudiyarov.TrainingPrograms.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Entities.Requests;

public record SessionRequest
{
    public ProgramType ProgramType { get; init; }
    public int Day { get; init; }
}