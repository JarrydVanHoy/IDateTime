using Microsoft.Extensions.DependencyInjection;

namespace System;

/// <summary>
/// Service collection extensions.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds IDateTime to your IoC container and provides a default implementation that is a passthrough for the DateTime class methods.
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddIDateTime(IServiceCollection services)
    {
        return services.AddSingleton<IDateTime, DateTimeProvider>();
    }
}