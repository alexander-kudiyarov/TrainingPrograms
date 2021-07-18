using System.Collections.Generic;
using Core.Entities;
using Core.Entities.Enums;
using Core.Entities.Requests;
using Core.TrainingPrograms;

namespace Core.Bll.Interfaces
{
    public interface ITrainingProgramLogic
    {
        IEnumerable<BaseTrainingProgram> Get();
        BaseTrainingProgram Get(ProgramType type);
        Session Get(SessionRequest request);
    }
}