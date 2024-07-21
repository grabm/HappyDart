using HappyDart.Domain.Abstractions;

namespace HappyDart.Domain.Aggregates.Users;
public class User : Entity
{
    private User()
    {

    }

    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}