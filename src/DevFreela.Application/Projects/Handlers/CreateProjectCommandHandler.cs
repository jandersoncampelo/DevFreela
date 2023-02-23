using DevFreela.Application.Projects.Command;
using DevFreela.Domain.Projects.Entities;
using DevFreela.Infrastructure.Data;
using MediatR;
using Microsoft.Extensions.Configuration;

namespace DevFreela.Application.Projects.Handlers
{
    public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, int>
    {
        private readonly DevFreelaDbContext _dbContext;

        public CreateProjectCommandHandler(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            var project = new Project(request.Title, request.Description, request.TotalCost, request.IdClient, request.IdFreelancer);

            await _dbContext.Projects.AddAsync(project, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return project.Id;
        }
    }
}
