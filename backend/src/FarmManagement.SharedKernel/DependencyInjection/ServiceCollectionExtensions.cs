using Microsoft.Extensions.DependencyInjection;

namespace FarmManagement.SharedKernel.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSharedKernel(this IServiceCollection services)
    {
        // tu np. rejestracja wspólnych providerów
        // services.AddSingleton<IDateTimeProvider, UtcDateTimeProvider>();
        return services;
    }
}