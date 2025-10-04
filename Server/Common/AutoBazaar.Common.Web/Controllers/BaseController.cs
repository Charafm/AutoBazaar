
using AutoBazaar.Common.Domain.BaseEntities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace AutoBazaar.Common.Web.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public abstract class BaseController<TEntity, TId> : ApiController
        where TEntity : IdBasedEntity<TId>, IDeletableEntity, IAuditableEntity<string>
    {

    }
}