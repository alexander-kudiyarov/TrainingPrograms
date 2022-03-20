using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Requests;
using Kudiyarov.TrainingPrograms.Programs;

namespace Kudiyarov.TrainingPrograms.Dal.Interfaces;

public interface IProgramRepository
{
    IEnumerable<TrainingProgram> Get();
    TrainingProgram Get(ProgramType type);
    Session Get(SessionRequest request);
}