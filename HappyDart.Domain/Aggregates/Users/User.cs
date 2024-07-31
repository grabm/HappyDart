using HappyDart.Domain.Abstractions;

namespace HappyDart.Domain.Aggregates.Users;
public class User : Entity
{
    private User()
    {

    }

    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
}