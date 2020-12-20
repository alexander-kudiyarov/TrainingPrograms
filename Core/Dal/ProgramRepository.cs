using System.Collections.Generic;
using Core.Dal.Interfaces;
using Core.Entities;
using Core.TrainingPrograms;

namespace Core.Dal
{
    public class ProgramRepository : IProgramRepository
    {
        private readonly IDictionary<string, ITrainingProgram> _repository;

        public ProgramRepository()
        {
            _repository = new Dictionary<string, ITrainingProgram>
            {
                [BodybuildingProgram.Name] = new BodybuildingProgram(),
                [DeadliftProgram.Name] = new DeadliftProgram()
            };
        }

        public ICollection<ITrainingProgram> Get()
        {
            var result = _repository.Values;
            return result;
        }

        public ITrainingProgram Get(string type)
        {
            var result = _repository[type];
            return result;
        }

        public Session Get(string type, int day)
        {
            var program = _repository[type];
            var session = program.Sessions[day - 1].Value;
            return session;
        }
    }
}