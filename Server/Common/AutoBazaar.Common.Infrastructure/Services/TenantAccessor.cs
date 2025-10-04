using AutoBazaar.Common.Application.Interfaces;
using Microsoft.AspNetCore.Http;

namespace AutoBazaar.Common.Infrastructure.Services
{
    public class TenantAccessor : ITenantAccessor
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TenantAccessor(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string? GetTenantId()
        {
            //var tenantId = _httpContextAccessor.HttpContext?.GetTenantId<string>;
            //if (tenantId != null)
            //{
            //    return tenantId;
            //}

            return Guid.NewGuid().ToString();
        }
    }
}
