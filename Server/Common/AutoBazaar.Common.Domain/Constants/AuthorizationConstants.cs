using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.Constants
{
    public static class AuthorizationConstants
    {
        public const string DefaultPassword = "AutoBazaar@2025";
        public const string DefaultBackofficeId = "AutoBazaar @2025";

        public static class ClaimTypes
        {
            public const string Permissions = "permissions";
        }

        public static class Scopes
        {
            public const string AutoBazaar= "AutoBazaar";
            public const string BackOffice = "BackOffice";
            public const string FrontOffice = "FrontOffice";
            public const string Offline_Access = "offline_access";
        }

        public static class Roles
        {
            public const string SuperAdmins = "SuperAdmins";
            public const string Administration = "Administration";
            public const string Client = "Client";
            public const string Staff = "Staff";
            public const string Bank = "Bank";
            

        }
    }

}
