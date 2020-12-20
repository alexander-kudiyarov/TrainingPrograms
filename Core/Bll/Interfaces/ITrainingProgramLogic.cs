using System.Collections.Generic;
using Core.Entities;

namespace Core.Bll.Interfaces
{
    public interface ITrainingProgramLogic
    {
        ICollection<ITrainingProgram> Get();
        ITrainingProgram Get(string type);
        Session Get(string type, int day);
    }
}