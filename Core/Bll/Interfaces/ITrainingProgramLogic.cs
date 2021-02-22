using System.Collections.Generic;
using Core.Entities;
using Core.Entities.Enums;
using Core.TrainingPrograms;

namespace Core.Bll.Interfaces
{
    public interface ITrainingProgramLogic
    {
        IEnumerable<BaseTrainingProgram> Get();
        BaseTrainingProgram Get(ProgramType type);
        Session Get(ProgramType type, int day);
    }
}