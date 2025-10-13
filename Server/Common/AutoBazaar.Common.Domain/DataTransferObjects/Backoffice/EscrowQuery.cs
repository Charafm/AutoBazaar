using AutoBazaar.Common.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.DataTransferObjects.Backoffice
{
    public class EscrowQuery
    {
        public Guid? PaymentId { get; set; }
        public Guid? BookingId { get; set; }
        public Guid? FleetOwner { get; set; } // renter or fleet owner
        public EscrowAction? Action { get; set; } // e.g. "Hold", "Release", "Refund"
        public DateTime? FromUtc { get; set; } // escrow creation time
        public DateTime? ToUtc { get; set; } // escrow creation time
        public Guid? RelatedSettlementEntryId { get; set; }

    }
}
