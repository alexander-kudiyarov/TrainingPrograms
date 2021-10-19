using Kudiyarov.TrainingPrograms.Core.Bll;
using Kudiyarov.TrainingPrograms.Core.Bll.Interfaces;
using Kudiyarov.TrainingPrograms.Core.Dal;
using Kudiyarov.TrainingPrograms.Core.Dal.Interfaces;
using Kudiyarov.TrainingPrograms.Di;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Kudiyarov.TrainingPrograms.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddMemoryCache();
            services.AddApplicationServices();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    "default",
                    "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}