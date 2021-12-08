using Kudiyarov.TrainingPrograms.Bll;
using Kudiyarov.TrainingPrograms.Bll.Interfaces;
using Kudiyarov.TrainingPrograms.Dal.Interfaces;
using Kudiyarov.TrainingPrograms.Dal.Memory;

namespace Kudiyarov.TrainingPrograms.Web.Extensions;

public static class DependencyInjectionExtensions
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddSingleton<ITrainingProgramLogic, TrainingProgramLogic>();
        services.AddSingleton<IProgramRepository, ProgramRepository>();
    }
}