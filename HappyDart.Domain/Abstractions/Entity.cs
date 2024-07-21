namespace HappyDart.Domain.Abstractions;
public class Entity
{
    protected Entity()
    {
    }

    protected Entity(
        long id,
        DateTime createdOnUtc)
    {
        Id = id;
        CreatedDateUtc = createdOnUtc;
    }
    public long Id { get; init; }

    public DateTime CreatedDateUtc { get; init; }
}