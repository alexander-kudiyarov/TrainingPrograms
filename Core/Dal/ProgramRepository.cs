using System.Collections.Generic;
using Core.Dal.Interfaces;
using Core.Entities;
using Core.Entities.Enums;
using Core.TrainingPrograms;

namespace Core.Dal
{
    public class ProgramRepository : IProgramRepository
    {
        private readonly IDictionary<ProgramType, ITrainingProgram> _repository;

        public ProgramRepository()
        {
            var bodybuildingProgram = new BodybuildingProgram();
            var deadliftProgram = new DeadliftProgram();

            _repository = new Dictionary<ProgramType, ITrainingProgram>
            {
                [bodybuildingProgram.Type] = bodybuildingProgram,
                [deadliftProgram.Type] = deadliftProgram
            };
        }

        public IEnumerable<ITrainingProgram> Get()
        {
            var result = _repository.Values;
            return result;
        }

        public ITrainingProgram Get(ProgramType type)
        {
            var result = _repository[type];
            return result;
        }

        public Session Get(ProgramType type, int day)
        {
            var program = _repository[type];
            var session = program.Sessions[day - 1].Value;
            return session;
        }
    }
}