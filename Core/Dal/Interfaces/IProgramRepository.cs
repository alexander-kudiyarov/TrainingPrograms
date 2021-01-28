using System.Collections.Generic;
using Core.Entities;
using Core.Entities.Enums;

namespace Core.Dal.Interfaces
{
    public interface IProgramRepository
    {
        IEnumerable<ITrainingProgram> Get();

        ITrainingProgram Get(ProgramType type);

        Session Get(ProgramType type, int day);
    }
}