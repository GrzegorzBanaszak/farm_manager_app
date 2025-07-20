using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace FarmManagement.Application.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var asm = Assembly.GetExecutingAssembly();

        services.AddMediatR(cfg =>
           cfg.RegisterServicesFromAssemblies(
              asm

           ));

        services.AddValidatorsFromAssembly(asm);
        services.AddAutoMapper(cfg => { }, asm);
        return services;
    }
}
