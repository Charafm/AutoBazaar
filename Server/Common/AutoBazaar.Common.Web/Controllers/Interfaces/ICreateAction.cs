using Microsoft.AspNetCore.Mvc;
using AutoBazaar.Common.Domain.BaseEntities;

namespace AutoBazaar.Common.Web.Controllers.Interfaces
{
    public interface ICreateAction<TEntity, TDto, TId>
        where TEntity : BaseEntity<TId>
        where TDto : class
    {
        Task<ActionResult<TEntity>> Create(TDto dto);
    }
}