using System;

namespace Core.Entities
{
    public interface ITrainingProgram
    {
        string Name { get; }
        Lazy<Session>[] Sessions { get; }
    }
}