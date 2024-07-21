using HappyDart.Domain.Abstractions;
using HappyDart.Domain.Aggregates.Users;

namespace HappyDart.Domain.Aggregates.Players;
public class Player : Entity
{
    private Player()
    {

    }
    public string Name { get; set; }
    public User User { get; set; }
}