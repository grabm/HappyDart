using HappyDart.Domain.Abstractions;
using HappyDart.Domain.Aggregates.DicGames;
using HappyDart.Domain.Aggregates.Players;

namespace HappyDart.Domain.Aggregates.Games;

public class Game : Entity
{
    private readonly List<Player> _players = new();

    private Game()
    {
    }

    public DicGame DicGame { get; private set; }
    public IReadOnlyCollection<Player> Players => _players.AsReadOnly();
}