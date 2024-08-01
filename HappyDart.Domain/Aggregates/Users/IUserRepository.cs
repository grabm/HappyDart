namespace HappyDart.Domain.Aggregates.Users;

interface IUserRepository
{
    Task<User> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    void Add(User);
}