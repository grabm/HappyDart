using HappyDart.Domain.Abstractions;
using HappyDart.Domain.Aggregates.Games;
using HappyDart.Domain.Aggregates.Users;

namespace HappyDart.Domain.Aggregates.Players;

public class Player : Entity
{
    private readonly List<Game> _games = new();

    private Player()
    {
    }

    private Player(
        Guid id,
        DateTime createdOnUtc,
        string name,
        User user
        ) : base(id, createdOnUtc)
    {
        Name = name;
        User = user;
    }

    public string Name { get; private set; }
    public Guid UserId { get; private set; }
    public User User { get; private set; }
    public IReadOnlyCollection<Game> Games => _games.AsReadOnly();

    public static Result<Player> CreateNew(string name, string email, string password)
    {
        var user = User.CreateNew(email, password);
        var player = new Player(Guid.NewGuid(), DateTime.Now, name, user.Value);

        return Result.Success(player);
    }
}