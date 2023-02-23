using DevFreela.Application.Projects.Commands;
using DevFreela.Application.Projects.Exceptions;
using DevFreela.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Application.Projects.Handlers
{
    public class DeleteProjectCommandHandler : IRequestHandler<DeleteProjectCommand, Unit>
    {
        private readonly DevFreelaDbContext _dbContext;

        public DeleteProjectCommandHandler(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await _dbContext.Projects.SingleOrDefaultAsync(p => p.Id == request.Id, cancellationToken);

            if (project == null)
            {
                throw new NotFoundException("Project not found", request.Id);
            }

            _dbContext.Projects.Remove(project); // TODO: Ao invés de remover, criar método para Cancelar
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
