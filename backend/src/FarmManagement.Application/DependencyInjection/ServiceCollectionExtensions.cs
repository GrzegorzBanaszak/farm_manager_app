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
            cfg.RegisterServicesFromAssembly(asm)
        );

        // 2) FluentValidation: walidatory w tej samej assembly
        services.AddValidatorsFromAssembly(asm);

        // 3) AutoMapper: profile w assembly Application

        services.AddAutoMapper(cfg => { }, asm);
        return services;
    }
}
