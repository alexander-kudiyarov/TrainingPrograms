using Kudiyarov.TrainingPrograms.Bll;
using Kudiyarov.TrainingPrograms.Bll.Interfaces;
using Kudiyarov.TrainingPrograms.Dal.Interfaces;
using Kudiyarov.TrainingPrograms.Dal.Memory;
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