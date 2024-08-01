using HappyDart.Domain.Abstractions;
using HappyDart.Domain.Aggregates.DicGames;

namespace HappyDart.Domain.Aggregates.Games;
public class Game : Entity
{
    public DicGame DicGame { get; private set; }
    public DateTime AddDateUtc { get; private set; }
}