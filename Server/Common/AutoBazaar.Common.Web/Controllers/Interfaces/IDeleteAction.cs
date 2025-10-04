using Microsoft.AspNetCore.Mvc;

namespace AutoBazaar.Common.Web.Controllers.Interfaces
{
    public interface IDeleteAction<TId>
    {
        Task<ActionResult> Delete(TId id);
    }
}