using DevFreela.Application.Skills.Queries;
using DevFreela.Application.Skills.ViewModels;
using DevFreela.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Application.Skills.Handlers
{
    public class GetAllSkillsQueryHandler : IRequestHandler<GetAllSkillsQuery, List<SkillViewModel>>
    {
        private readonly DevFreelaDbContext _dbContext;

        public GetAllSkillsQueryHandler(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<SkillViewModel>> Handle(GetAllSkillsQuery request, CancellationToken cancellationToken)
        {
            var skills = await _dbContext.Skills.ToListAsync(cancellationToken);

            var skillsViewModel = skills.Select(s => new SkillViewModel(s.Id, s.Description)).ToList();

            return skillsViewModel;
        }
    }
}
