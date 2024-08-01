using HappyDart.Domain.Abstractions;

namespace HappyDart.Domain.Aggregates.Users;
public class User : Entity
{
    private User(
        Guid id,
        DateTime createdOnUtc,
        DateTime modifyOnUtc,
        string email,
        string password,
        bool isActive
        )
        : base(id, createdOnUtc)
    {
        ModifyOnUtc = modifyOnUtc;
        Email = email;
        Password = password;
        IsActive = isActive;
    }

    public DateTime ModifyOnUtc { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public bool IsActive { get; set; }
}