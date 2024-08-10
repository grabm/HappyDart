using HappyDart.Domain.Abstractions;

namespace HappyDart.Domain.Aggregates.Users;

public class User : Entity
{
    private User()
    {
    }

    private User(
        Guid id,
        DateTime createdOnUtc,
        string email,
        string password,
        bool isActive)
        : base(id, createdOnUtc)
    {
        Email = email;
        Password = password;
        IsActive = isActive;
    }

    public DateTime ModifyOnUtc { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public bool IsActive { get; set; }

    public static Result<User> CreateNew (string email, string password)
    {
        var user = new User(Guid.NewGuid(), DateTime.Now, email, password, true);

        return Result.Success(user);
    }
}