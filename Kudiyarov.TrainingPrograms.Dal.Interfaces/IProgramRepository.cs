using Kudiyarov.TrainingPrograms.Entities.Entities;
using Kudiyarov.TrainingPrograms.Entities.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Entities.Requests;
using Kudiyarov.TrainingPrograms.Programs;

namespace Kudiyarov.TrainingPrograms.Dal.Interfaces;

public interface IProgramRepository
{
    IEnumerable<TrainingProgram> Get();
    TrainingProgram Get(ProgramType type);
    Session Get(SessionRequest request);
}