using DevFreela.Domain.Commons;
using DevFreela.Domain.Projects.Entities;
using DevFreela.Domain.Skills;

namespace DevFreela.Domain.Users;

public class User : EntityBase
{
    public string FullName { get; private set; }
    public string Email { get; private set; }
    public DateTime BirthDate { get; private set; }
    public string Password { get; private set; }
    public UserRole Role { get; private set; }
    public List<Skill> Skills { get; private set; }
    public List<Project> FreelancerProjects { get; set; }
    public List<Project> OwnedProjects { get; set; }

    public User(string fullName, string email, DateTime birthDate, string password, UserRole role)
    {
        FullName = fullName;
        Email = email;
        BirthDate = birthDate;
        Password = password;
        Role = role;
        Skills = new List<Skill>();
    }

    public void AddSkill(Skill skill)
    {
        Skills.Add(skill);
    }

}
