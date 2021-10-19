using Kudiyarov.TrainingPrograms.Core.Bll;
using Kudiyarov.TrainingPrograms.Core.Bll.Interfaces;
using Kudiyarov.TrainingPrograms.Core.Dal;
using Kudiyarov.TrainingPrograms.Core.Dal.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Kudiyarov.TrainingPrograms.Di
{
    public static class Bootstrapper
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddSingleton<ITrainingProgramLogic, TrainingProgramLogic>();
            services.AddSingleton<IProgramRepository, ProgramRepository>();
        }
    }
}