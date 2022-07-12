using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Day7_WebApi_HandsOn.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Day7_WebApi_HandsOnContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Day7_WebApi_HandsOnContext") ?? throw new InvalidOperationException("Connection string 'Day7_WebApi_HandsOnContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
