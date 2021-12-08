using Kudiyarov.TrainingPrograms.Di;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddMemoryCache();
builder.Services.AddApplicationServices();

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