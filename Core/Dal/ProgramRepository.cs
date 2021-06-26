using System.Collections.Generic;
using System.Linq;
using Core.Dal.Interfaces;
using Core.Entities;
using Core.Entities.Enums;
using Core.TrainingPrograms;
using Core.TrainingPrograms.Strength;

namespace Core.Dal
{
    public class ProgramRepository : IProgramRepository
    {
        private readonly IReadOnlyDictionary<ProgramType, BaseTrainingProgram> _repository;

        public ProgramRepository()
        {
            var programs = new BaseTrainingProgram[]
            {
                new CompetitionProgram(),
                new DeadliftProgram(),
                new LegsProgram(),
                new PullAndSquatProgram(),
                new BodybuildingProgram()
            };

            _repository = programs.ToDictionary(program => program.Type);
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