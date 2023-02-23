using DevFreela.Application.Skills.ViewModels;
using MediatR;

namespace DevFreela.Application.Skills.Queries
{
    public class GetAllSkillsQuery : IRequest<List<SkillViewModel>> 
    {
    }
}
