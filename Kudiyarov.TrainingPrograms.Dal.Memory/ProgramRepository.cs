using System.Collections.Generic;
using System.Linq;
using Kudiyarov.TrainingPrograms.Dal.Interfaces;
using Kudiyarov.TrainingPrograms.Entities.Entities;
using Kudiyarov.TrainingPrograms.Entities.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Entities.Requests;
using Kudiyarov.TrainingPrograms.Entities.TrainingPrograms;
using Kudiyarov.TrainingPrograms.Entities.TrainingPrograms.Strength;

namespace Kudiyarov.TrainingPrograms.Dal.Memory
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

        public Session Get(SessionRequest request)
        {
            var program = _repository[request.ProgramType];
            var session = program.Get(request.Day);
            return session;
        }
    }
}