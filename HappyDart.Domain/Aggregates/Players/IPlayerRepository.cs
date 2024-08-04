using HappyDart.Domain.Aggregates.Players;

namespace HappyDart.Domain.Aggregates.Users;

public interface IPlayerRepository
{
    Task<Player> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    void Add(Player user);
}