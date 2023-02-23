using DevFreela.Application.Projects.Queries;
using DevFreela.Application.Projects.ViewModels;
using DevFreela.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Application.Projects.Handlers
{
    public class GetAllProjectsQueryHandler : IRequestHandler<GetAllProjectsQuery, List<ProjectViewModel>>
    {
        private readonly DevFreelaDbContext _dbContext;

        public GetAllProjectsQueryHandler(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ProjectViewModel>> Handle(GetAllProjectsQuery request, CancellationToken cancellationToken)
        {
            var projects = await _dbContext.Projects.ToListAsync(cancellationToken);

            var projectsViewModel = projects.Select(p => new ProjectViewModel(p.Id,
                                                                              p.Title,
                                                                              p.Description,
                                                                              p.TotalCost)).ToList();

            return projectsViewModel;
        }
    }
}
