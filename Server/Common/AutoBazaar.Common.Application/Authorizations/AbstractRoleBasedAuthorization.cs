using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR.Behaviors.Authorization;

namespace AutoBazaar.Common.Application.Authorizations
{
    public abstract class AbstractRoleBasedAuthorizer<TRequest> : AbstractRequestAuthorizer<TRequest>
    {
        protected abstract List<string> GetAllowedRoles();

        public override void BuildPolicy(TRequest request)
        {
            UseRequirement(new MustHaveRoleRequirement
            {
                RoleNames = GetAllowedRoles()
            });
        }
    }
}
