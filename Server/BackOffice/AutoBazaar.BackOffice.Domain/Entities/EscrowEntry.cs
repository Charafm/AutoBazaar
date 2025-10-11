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
    public class EscrowEntry : BaseEntity<Guid>
    {
        public Guid? PaymentId { get; set; }
        public Guid? BookingId { get; set; }
        public Guid? FleetOwnerId { get; set; }
        public EscrowAction Action { get; set; }
        public Money Amount { get; set; } = null!;
        public Money? BalanceAfter { get; set; }
        public string? Reason { get; set; }
        public Guid? RelatedSettlementEntryId { get; set; }

    }
}
