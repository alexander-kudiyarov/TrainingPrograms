using System.Collections.Generic;
using Core.Entities;
using Core.Entities.Enums;

namespace Core.Bll.Interfaces
{
    public interface ITrainingProgramLogic
    {
        IEnumerable<ITrainingProgram> Get();
        ITrainingProgram Get(ProgramType type);
        Session Get(ProgramType type, int day);
    }
}