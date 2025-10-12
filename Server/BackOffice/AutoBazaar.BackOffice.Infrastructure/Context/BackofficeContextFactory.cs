using AutoBazaar.Common.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.BackOffice.Infrastructure.Context
{
    public class BackofficeContextFactory : AbstractContextFactory<BackofficeContext>
    {
        public BackofficeContextFactory()
        {
        }

        protected override string GetAppSettingsProject()
        {
            return "../AutoBazaar.Web.Backoffice";
        }
    }
}
