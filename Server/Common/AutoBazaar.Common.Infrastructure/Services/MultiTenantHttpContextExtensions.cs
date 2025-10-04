using AutoBazaar.Common.Domain.Constants;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Infrastructure.Services
{
    public static class MultiTenantHttpContextExtensions
    {
        public static T? GetTenantId<T>(this HttpContext context) where T : class
        {
            if (context.Items.TryGetValue(WebConstants.HttpContextTenantKey, out object? tenantId))
            {
                return tenantId as T;
            }
            return default;
        }
    }
}
