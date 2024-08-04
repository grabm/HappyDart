using HappyDart.Domain.Aggregates.Players;
using HappyDart.Domain.Aggregates.Users;

namespace HappyDart.Infrastructure.Repositories;

public class UserRepository : IPlayerRepository
{  

    public void Add(Player user)
    {
        throw new NotImplementedException();
    }

    Task<Player> IPlayerRepository.GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}