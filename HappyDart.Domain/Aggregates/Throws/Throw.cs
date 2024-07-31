using HappyDart.Domain.Abstractions;
using HappyDart.Domain.Aggregates.Games;
using HappyDart.Domain.Aggregates.Players;

namespace HappyDart.Domain.Aggregates.Throws;

public class Throw : Entity
{
    private Throw()
    {

    }
    public Game Game { get; private set; }
    public Player Player { get; private set; }
    public int Score { get; private set; }
    public bool WasDouble { get; private set; }
    public bool WasTriple { get; private set; }
    public bool WasFinish { get; private set; }
    public DateTime ModificatedDateUtc { get; private set; }
}