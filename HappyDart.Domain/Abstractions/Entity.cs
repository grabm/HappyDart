namespace HappyDart.Domain.Abstractions;
public class Entity
{
    protected Entity()
    {
    }

    protected Entity(
        Guid id,
        DateTime createdOnUtc)
    {
        Id = id;
        CreatedDateUtc = createdOnUtc;
    }
    public Guid Id { get; init; }

    public DateTime CreatedDateUtc { get; init; }
}