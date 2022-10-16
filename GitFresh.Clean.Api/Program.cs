using GitFresh.Clean.Application;
using GitFresh.Clean.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<IDietRepository, DietRepository>();
builder.Services.AddSingleton<IDietService, DietService>();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
