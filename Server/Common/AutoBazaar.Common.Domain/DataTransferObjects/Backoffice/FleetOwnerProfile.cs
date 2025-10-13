using AutoBazaar.Common.Domain.Enums;
using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.DataTransferObjects.Backoffice
{
    public class FleetOwnerProfile
    {
        public string BusinessName { get; set; } = null!; 
        public ServiceRating serviceRating { get; set; }
        public ContactInfo Contact { get; set; } = null!;
        public Address Address { get; set; } = null!;
        public bool IsActive { get; set; } = true;
       }
}
