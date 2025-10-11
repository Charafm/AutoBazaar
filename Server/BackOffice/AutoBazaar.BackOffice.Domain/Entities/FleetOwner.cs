using AutoBazaar.Common.Domain.BaseEntities;
using AutoBazaar.Common.Domain.Enums;
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
        public string BusinessName { get; set; } = null!; // Owner Name or Business Name
        public ServiceRating serviceRating { get; set; }
        public ContactInfo Contact { get; set; } = null!;
        public Address Address { get; set; } = null!;
        public BankAccountInfo? BankAccount { get; set; }
        public KycStatus KycStatus { get; set; }
        public decimal OwnerRiskRate { get; set; } // e.g., insurance risk factor
        public DefaultPayoutSchedule PayoutSchedule { get; set; }
        public bool IsActive { get; set; } = true;
        public List<Guid> VehicleIds { get; set; } = new();
    }
}
