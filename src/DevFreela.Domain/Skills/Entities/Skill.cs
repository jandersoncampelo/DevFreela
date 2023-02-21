using DevFreela.Domain.Commons;

namespace DevFreela.Domain.Skills;

public class Skill : EntityBase
{
    public string Description { get; private set; }

    public Skill(string description)
    {
        Description = description;
    }
}
