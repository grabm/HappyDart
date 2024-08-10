using HappyDart.Domain.Aggregates.Players;
using HappyDart.Domain.Aggregates.Users;
using Microsoft.EntityFrameworkCore;

namespace HappyDart.Infrastructure.Repositories;

public class PlayerRepository : IPlayerRepository
{
    private readonly HappyDartDbContext _happyDartDbContext;

    public PlayerRepository(HappyDartDbContext happyDartDbContext)
    {
        _happyDartDbContext = happyDartDbContext;
    }

    public void Add(Player player)
    {
        _happyDartDbContext.Set<Player>().Add(player);
    }

    public async Task<Player> GetByCredentialsAsync(string email, string password, CancellationToken cancellationToken = default)
    {
        var result = await _happyDartDbContext.Set<Player>().SingleOrDefaultAsync(p => p.User.Email == email && p.User.Password == password);

        return result;
    }
}