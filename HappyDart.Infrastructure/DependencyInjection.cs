using HappyDart.Domain.Abstractions;
using HappyDart.Domain.Aggregates.Users;
using HappyDart.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HappyDart.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection ConfigureInfrastructure(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        string connectionString = configuration.GetConnectionString("LocalDb") ?? throw new ArgumentNullException(nameof(configuration));

        serviceCollection.AddDbContext<IUnitOfWork, HappyDartDbContext>(options =>
        {
            options.UseSqlServer(connectionString);

            options.EnableSensitiveDataLogging();
            options.LogTo(m => Console.WriteLine(m + "\n"));
        });

        serviceCollection.AddScoped<IPlayerRepository, PlayerRepository>();
        //serviceCollection.AddScoped<IUnitOfWork, HappyDartDbContext>();

        return serviceCollection;
    }
}