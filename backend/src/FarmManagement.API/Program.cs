using FarmManagement.Application.DependencyInjection;
using FarmManagement.Infrastructure.DependencyInjection;
using FarmManagement.SharedKernel.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddApplication()
    .AddInfrastructure()
    .AddSharedKernel();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();

