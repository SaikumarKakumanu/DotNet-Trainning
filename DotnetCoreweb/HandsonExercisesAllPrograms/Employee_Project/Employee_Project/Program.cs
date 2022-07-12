using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Employee_Project.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Employee_ProjectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Employee_ProjectContext") ?? throw new InvalidOperationException("Connection string 'Employee_ProjectContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
