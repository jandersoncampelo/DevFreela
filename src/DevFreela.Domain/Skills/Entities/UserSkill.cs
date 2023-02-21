using DevFreela.Domain.Commons;
using DevFreela.Domain.Users;

namespace DevFreela.Domain.Skills;

public class UserSkill : EntityBase
{
    public Guid IdUser { get; private set; }
    public Guid IdSkill { get; private set; }
    public User User { get; set; }
    public Skill Skill { get; set; }

    public UserSkill(Guid idUser, Guid idSkill)
    {
        IdUser = idUser;
        IdSkill = idSkill;
    }
}
