using System.Collections.Generic;
using System.Linq;
using Kudiyarov.TrainingPrograms.Core.Common.Entities;
using Kudiyarov.TrainingPrograms.Core.Common.Entities.Enums;
using Kudiyarov.TrainingPrograms.Core.Common.Entities.Requests;
using Kudiyarov.TrainingPrograms.Core.Common.TrainingPrograms;
using Kudiyarov.TrainingPrograms.Core.Common.TrainingPrograms.Strength;
using Kudiyarov.TrainingPrograms.Core.Dal.Interfaces;

namespace Kudiyarov.TrainingPrograms.Core.Dal
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