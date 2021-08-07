using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Kudiyarov.TrainingPrograms.Web
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            await GetHost(args).RunAsync();
        }

        private static IHost GetHost(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); })
                .Build();

            return host;
        }
    }
}