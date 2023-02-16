using DevFreela.Domain.Commons;

namespace DevFreela.Domain.Users;

public class User : EntityBase
{
    public string FullName { get; private set; }
    public string Email { get; private set; }
    public DateTime BirthDate { get; private set; }
    public string Password { get; private set; }
    public UserRole Role { get; private set; }

    public User(string fullName, string email, DateTime birthDate, string password, UserRole role)
    {
        FullName = fullName;
        Email = email;
        BirthDate = birthDate;
        Password = password;
        Role = role;
    }
}
