using HappyDart.Domain.Abstractions;
using HappyDart.Domain.Aggregates.Games;
using HappyDart.Domain.Aggregates.Players;

namespace HappyDart.Domain.Aggregates.Throws;

public class Throw : Entity
{
    private Throw()
    {

    }
    public Game Game { get; set; }
    public Player Player { get; set; }
    public int Score { get; set; }
    public bool WasDouble { get; set; }
    public bool WasTriple { get; set; }
    public bool WasFinish { get; set; }
    public DateTime ModificatedDateUtc { get; set; }
}