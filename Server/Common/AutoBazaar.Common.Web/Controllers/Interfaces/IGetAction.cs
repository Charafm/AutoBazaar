using AutoBazaar.Common.Application.Entities;
using AutoBazaar.Common.Domain.BaseEntities;
using Microsoft.AspNetCore.Mvc;

namespace AutoBazaar.Common.Web.Controllers.Interfaces
{
    public interface IGetAction<TEntity, TId>
        where TEntity : BaseEntity<TId>
    {
        Task<ActionResult<PagedResult<TEntity>>> Get(int? page, int? size);
    }
}