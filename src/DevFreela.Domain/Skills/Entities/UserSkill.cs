using DevFreela.Domain.Commons;
using DevFreela.Domain.Users;

namespace DevFreela.Domain.Skills;

public class UserSkill : EntityBase
{
    public int IdUser { get; private set; }
    public int IdSkill { get; private set; }
    public User User { get; set; }
    public Skill Skill { get; set; }

    public UserSkill(int idUser, int idSkill)
    {
        IdUser = idUser;
        IdSkill = idSkill;
    }
}
