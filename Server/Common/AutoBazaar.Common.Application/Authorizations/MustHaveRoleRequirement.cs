using AutoBazaar.Common.Application.Interfaces;
using AutoBazaar.Common.Domain.Localization;
using MediatR.Behaviors.Authorization;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Authorizations
{

    public class MustHaveRoleRequirement : IAuthorizationRequirement
    {
        public List<string> RoleNames { get; set; }

        private class MustHaveRoleRequirementHandler : IAuthorizationHandler<MustHaveRoleRequirement>
        {
            private readonly ICurrentUserService _currentUserService;
            private readonly IStringLocalizer<Messages> _localizer;

            public MustHaveRoleRequirementHandler(ICurrentUserService currentUserService, IStringLocalizer<Messages> localizer)
            {
                _currentUserService = currentUserService;
                _localizer = localizer;
            }

            public Task<AuthorizationResult> Handle(MustHaveRoleRequirement request,
                CancellationToken cancellationToken)
            {
                if (_currentUserService.RoleNames != null && _currentUserService.RoleNames.Intersect(request.RoleNames)
                    .Any())
                {
                    return Task.FromResult(AuthorizationResult.Succeed());
                }

                return Task.FromResult(AuthorizationResult.Fail(_localizer["PermissionDenied"]));
            }
        }
    }
}
