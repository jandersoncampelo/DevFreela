using DevFreela.Application.Projects.ViewModels;
using MediatR;

namespace DevFreela.Application.Projects.Queries
{
    public class GetAllProjectsQuery : IRequest<List<ProjectViewModel>>
    {
        public GetAllProjectsQuery(string query)
        {
            Query = query;
        }

        public string Query { get; private set; }
    }
}
