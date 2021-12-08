using Kudiyarov.TrainingPrograms.Web.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationServices();
builder.Services.AddControllersWithViews();
builder.Services.AddMemoryCache();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();
app.UseEndpoints(endpoints =>
    endpoints.MapControllerRoute(
        "default",
        "{controller=Home}/{action=Index}/{id?}"));

app.Run();