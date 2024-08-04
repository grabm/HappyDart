using HappyDart.Domain.Abstractions;
using HappyDart.Domain.Aggregates.Users;

namespace HappyDart.Domain.Aggregates.Players;
public class Player : Entity
{
    private Player()
    {

    }
    public string Name { get; private set; }
    public Guid UserId { get; private set; }
    public User User { get; private set; }
}