using System;
using Core.Entities.Enums;

namespace Core.Entities
{
    public interface ITrainingProgram
    {
        ProgramType Type { get; }
        string Name { get; }
        Lazy<Session>[] Sessions { get; }
    }
}