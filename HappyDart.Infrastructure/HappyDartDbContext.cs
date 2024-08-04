using Microsoft.EntityFrameworkCore;

namespace HappyDart.Infrastructure;

public class HappyDartDbContext : DbContext
{
    public HappyDartDbContext(DbContextOptions<HappyDartDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(HappyDartDbContext).Assembly);
    }
}