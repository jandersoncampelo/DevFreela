using DevFreela.Domain.Commons;

namespace DevFreela.Domain.Projects.Entities;

public class Project : EntityBase
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public decimal TotalCost { get; private set; }
    public int IdClient { get; private set; }
    public int IdFreelancer { get; private set; }
    public DateTime StartedAt { get; private set; }
    public DateTime FinishedAt { get; private set; }
    public ProjectStatus Status { get; private set; }

    public Project(string title, string description, decimal totalCost, int idClient, int idFreelancer)
    {
        Title = title;
        Description = description;
        TotalCost = totalCost;
        IdClient = idClient;
        IdFreelancer = idFreelancer;
        Status = ProjectStatus.Created;
    }

    public void Start()
    {
        Status = ProjectStatus.InProgress;
        StartedAt = DateTime.Now;
    }

    public void Finish()
    {
        Status = ProjectStatus.Finished;
        FinishedAt = DateTime.Now;
    }
}
