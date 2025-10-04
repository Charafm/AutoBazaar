using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Authorizations
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AuthorizeAccessAttribute : Attribute
    {
        public AuthorizeAccessAttribute(string? roles)
        {
            if (roles != null)
            {
                RoleNames = roles.Split(',', StringSplitOptions.TrimEntries).ToList();
            }
        }

        public List<string> RoleNames { get; set; } = new List<string>();
    }
}
