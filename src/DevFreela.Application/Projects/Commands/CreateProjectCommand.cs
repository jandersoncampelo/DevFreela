using MediatR;

namespace DevFreela.Application.Projects.Command
{
    public class CreateProjectCommand : IRequest<int>
    {
        public CreateProjectCommand(string title, string description, decimal totalCost, int idClient, int idFreelancer)
        {
            Title = title;
            Description = description;
            TotalCost = totalCost;
            IdClient = idClient;
            IdFreelancer = idFreelancer;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal TotalCost { get; private set; }
        public int IdClient { get; private set; }
        public int IdFreelancer { get; private set; }
    }
}
