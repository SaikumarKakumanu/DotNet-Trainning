using Handson_ASP_Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Handson_ASP_Core.Data;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Handson_ASP_CoreContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Handson_ASP_CoreContext") ?? throw new InvalidOperationException("Connection string 'Handson_ASP_CoreContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ILog,MyConsole>();
//builder.Services.AddSingleton<ILog, MyConsole>();
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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
