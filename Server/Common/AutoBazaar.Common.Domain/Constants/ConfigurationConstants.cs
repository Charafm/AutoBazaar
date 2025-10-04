using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.Constants
{
    public static class ConfigurationConstants
    {
        public static class Sections
        {
            public const string Security = "Security";
            public const string Mail = "EmailOptions";
            public const string WebPortalsURLs = "WebPortalsURLs";
            public const string Nfs = "Nfs";
            public const string ClamAV = "ClamAV";
            public const string Payment = "Payment";
            public const string RabbitMQ = "RabbitMQ";
            public const string ErrorDetails = "ErrorDetails";
        }
    }
}
