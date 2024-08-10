using Microsoft.Extensions.DependencyInjection;

namespace HappyDart.Application;

public static class DependencyInjection
{
    public static void RegisterApplication(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddMediatR(options =>
        {
            options.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
        });
    }
}