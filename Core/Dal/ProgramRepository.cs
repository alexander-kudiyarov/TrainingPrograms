using System.Collections.Generic;
using Core.Dal.Interfaces;
using Core.Entities;
using Core.Entities.Enums;
using Core.TrainingPrograms;

namespace Core.Dal
{
    public class ProgramRepository : IProgramRepository
    {
        private readonly IDictionary<ProgramType, BaseTrainingProgram> _repository;

        public ProgramRepository()
        {
            var bodybuildingProgram = new BodybuildingProgram();
            var deadliftProgram = new DeadliftProgram();

            _repository = new Dictionary<ProgramType, BaseTrainingProgram>
            {
                [bodybuildingProgram.Type] = bodybuildingProgram,
                [deadliftProgram.Type] = deadliftProgram
            };
        }

        public IEnumerable<BaseTrainingProgram> Get()
        {
            var result = _repository.Values;
            return result;
        }

        public BaseTrainingProgram Get(ProgramType type)
        {
            var result = _repository[type];
            return result;
        }

        public Session Get(ProgramType type, int day)
        {
            var program = _repository[type];
            var session = program.Get(day);
            return session;
        }
    }
}