using GamesToPlayProject.Database;
using GamesToPlayProject.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IGamesService, GamesService>();

builder.Services.AddDbContext<AppDbContext>(
    config => config.UseSqlServer(builder.Configuration.GetConnectionString("Application"))
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Games}/{action=MyList}/{id?}");

app.Run();
