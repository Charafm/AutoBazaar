using AutoBazaar.Common.Application.Interfaces;
using MediatR.Behaviors.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;
using AutoBazaar.Common.Domain.Localization;

namespace AutoBazaar.Common.Application.Authorizations
{
    public class MustHavePermissionRequirement : IAuthorizationRequirement
    {
        public List<string> Permissions { get; set; } = new List<string>();

        private class MustHavePermissionRequirementHandler : IAuthorizationHandler<MustHavePermissionRequirement>
        {
            private readonly ICurrentUserService _currentUserService;
            private readonly IStringLocalizer<Messages> _localizer;

            public MustHavePermissionRequirementHandler(ICurrentUserService currentUserService, IStringLocalizer<Messages> localizer)
            {
                _currentUserService = currentUserService;
                _localizer = localizer;
            }

            public Task<AuthorizationResult> Handle(MustHavePermissionRequirement request,
                CancellationToken cancellationToken)
            {
                return Task.FromResult(AuthorizationResult.Fail(_localizer["PermissionDenied"]));
            }
        }
    }
}
