using AutoBazaar.Common.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static OpenIddict.Abstractions.OpenIddictConstants;

namespace AutoBazaar.Common.Web.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string UserId
        {
            get
            {
                var claimPricipal = _httpContextAccessor.HttpContext?.User;
                return claimPricipal?.FindFirstValue(Claims.Subject) ?? claimPricipal?.FindFirstValue(ClaimTypes.NameIdentifier);
            }
        }
        public string UserName
        {
            get
            {
                var claimPricipal = _httpContextAccessor.HttpContext?.User;
                return claimPricipal?.FindFirstValue(Claims.Username) ?? claimPricipal?.FindFirstValue(ClaimTypes.Name);
            }
        }
        public string? PreferredUsername
        {
            get
            {
                var claimPricipal = _httpContextAccessor.HttpContext?.User;
                return claimPricipal?.FindFirstValue(Claims.Name) ?? claimPricipal?.FindFirstValue(ClaimTypes.Name);
            }
        }
        public List<string> RoleNames
        {
            get
            {
                var claimPricipal = _httpContextAccessor.HttpContext?.User;
                var roles = claimPricipal?.FindAll(Claims.Role).Select(e => e.Value).ToList();
                if (!roles.Any())
                {
                    roles = claimPricipal?.FindAll(ClaimTypes.Role).Select(e => e.Value).ToList();
                }
                return roles;
            }
        }

        public bool IsAuthenticated => throw new NotImplementedException();
    }
}
