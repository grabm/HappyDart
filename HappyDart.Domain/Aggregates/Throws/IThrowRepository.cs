namespace HappyDart.Domain.Aggregates.Throws;
public interface IThrowRepository
{
    Task<IEnumerable<Throw>> GetAll(CancellationToken cancellationToken = default);
}