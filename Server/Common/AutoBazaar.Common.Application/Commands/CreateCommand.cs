
using AutoBazaar.Common.Application.Interfaces;
using AutoBazaar.Common.Domain.BaseEntities;
using MediatR;

namespace AutoBazaar.Common.Application.Commands
{
    public class CreateCommand<TContext, TEntity, TId> : IRequest<TEntity>
        where TEntity : class, IDeletableEntity
        where TContext : IContext
    {
        public TEntity Data { get; set; }
    }

    public class CreateCommandHandler<TCommand, TContext, TEntity, TId> : IRequestHandler<TCommand, TEntity>
        where TEntity : class, IDeletableEntity
        where TContext : IContext
        where TCommand : CreateCommand<TContext, TEntity, TId>
    {
        protected TContext DbContext { get; private set; }

        public CreateCommandHandler(TContext dbContext)
        {
            DbContext = dbContext;
        }

        public virtual async Task<TEntity> Handle(TCommand request, CancellationToken cancellationToken)
        {
            DbContext.Set<TEntity>().Add(request.Data);

            await DbContext.SaveChangesAsync(cancellationToken);

            return request.Data;
        }
    }
}