using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HappyDart.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection ConfigureInfrastructure(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        string connectionString = configuration.GetConnectionString("LocalDb") ?? throw new ArgumentNullException(nameof(configuration));

        serviceCollection.AddDbContext<HappyDartDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });
        return serviceCollection;
    }
}