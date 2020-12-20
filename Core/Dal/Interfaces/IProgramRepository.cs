using System.Collections.Generic;
using Core.Entities;

namespace Core.Dal.Interfaces
{
    public interface IProgramRepository
    {
        ICollection<ITrainingProgram> Get();

        ITrainingProgram Get(string type);

        Session Get(string type, int day);
    }
}