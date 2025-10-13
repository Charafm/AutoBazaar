using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.DataTransferObjects.Backoffice
{
    public class OwnerSearchQuery
    {
        public string? BusinessName { get; set; }
        public ContactInfo? Contact { get; set; }

    }
}
