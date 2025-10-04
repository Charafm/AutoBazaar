using AutoBazaar.Common.Domain.BaseEntities;
using Microsoft.AspNetCore.Mvc;

namespace AutoBazaar.Common.Web.Controllers.Interfaces
{
    public interface IGetByIdAction<TEntity, TId>
        where TEntity : BaseEntity<TId>
    {
        Task<ActionResult<TEntity>> GetById(TId id);
    }
}