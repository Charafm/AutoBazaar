using AutoBazaar.Common.Domain.BaseEntities;
using Microsoft.AspNetCore.Mvc;

namespace AutoBazaar.Common.Web.Controllers.Interfaces
{
    public interface IUpdateAction<TEntity, TDto, TId>
        where TEntity : BaseEntity<TId>
        where TDto : class
    {
        Task<ActionResult> Update(TId id, TDto dto);
    }
}