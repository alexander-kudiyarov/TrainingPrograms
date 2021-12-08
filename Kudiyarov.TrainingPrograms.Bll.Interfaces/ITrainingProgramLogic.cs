using Kudiyarov.TrainingPrograms.Entities.Entities;
using Kudiyarov.TrainingPrograms.Entities.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Entities.Requests;
using Kudiyarov.TrainingPrograms.Entities.TrainingPrograms;

namespace Kudiyarov.TrainingPrograms.Bll.Interfaces;

public interface ITrainingProgramLogic
{
    IEnumerable<BaseTrainingProgram> Get();
    BaseTrainingProgram Get(ProgramType type);
    Session Get(SessionRequest request);
}