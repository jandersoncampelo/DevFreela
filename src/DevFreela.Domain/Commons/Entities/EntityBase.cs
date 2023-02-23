namespace DevFreela.Domain.Commons;

public abstract class EntityBase
{
    public int Id { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }

    protected EntityBase()
    {
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }
}
