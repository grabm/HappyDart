using HappyDart.Domain.Aggregates.Players;

namespace HappyDart.Domain.Aggregates.Users;

public interface IPlayerRepository
{
    Task<Player> GetByCredentialsAsync(string email, string password, CancellationToken cancellationToken = default);
    void Add(Player user);
}