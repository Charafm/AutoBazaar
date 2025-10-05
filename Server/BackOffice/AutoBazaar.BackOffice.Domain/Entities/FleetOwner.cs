using AutoBazaar.Common.Domain.BaseEntities;
using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.BackOffice.Domain.Entities
{
    public class FleetOwner : BaseEntity<Guid>
    {
        public string BusinessName { get; set; } = null!;
        public ContactInfo Contact { get; set; } = null!;
        public Address Address { get; set; } = null!;
        public BankAccountInfo? BankAccount { get; set; } // masked info only
        public List<Guid> VehicleIds { get; set; } = new(); // or a nav list if you prefer
    }
}
