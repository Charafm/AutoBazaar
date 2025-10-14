using AutoBazaar.Common.Domain.Enums;
using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.DataTransferObjects.Backoffice
{
    public class CreateFleetOwnerRequest
    {
        public string BusinessName { get; set; } = null!; // Owner Name or Business Name
        public ServiceRating serviceRating { get; set; }
        public ContactInfo Contact { get; set; } = null!;
        public Address Address { get; set; } = null!;
        public BankAccountInfo? BankAccount { get; set; }
        public KycStatus KycStatus { get; set; } = KycStatus.Pending;
        public decimal OwnerRiskRate { get; set; } // e.g., insurance risk factor
        public DefaultPayoutSchedule PayoutSchedule { get; set; }
        public bool IsActive { get; set; } = true;
        public List<Guid> VehicleIds { get; set; } = new();
    }
}
