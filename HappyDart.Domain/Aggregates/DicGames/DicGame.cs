using HappyDart.Domain.Abstractions;

namespace HappyDart.Domain.Aggregates.DicGames;

public class DicGame : Entity
{
    private DicGame()
    {

    }

    public string Name { get; private set; }
}