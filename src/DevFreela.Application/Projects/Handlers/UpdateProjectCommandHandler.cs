using DevFreela.Application.Projects.Commands;
using DevFreela.Application.Projects.Exceptions;
using DevFreela.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Application.Projects.Handlers
{
    internal class UpdateProjectCommandHandler : IRequestHandler<UpdateProjectCommand, Unit>
    {
        private readonly DevFreelaDbContext _dbContext;

        public UpdateProjectCommandHandler(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await _dbContext.Projects.SingleOrDefaultAsync(p => p.Id == request.Id, cancellationToken);

            if (project == null)
            {
                throw new NotFoundException("Project not found", request.Id);
            }

            project.Update(request.Title, request.Description, request.TotalCost);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
