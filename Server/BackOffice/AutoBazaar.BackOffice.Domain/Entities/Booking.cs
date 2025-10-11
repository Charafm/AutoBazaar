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
    public class Booking : BaseEntity<Guid>
    {
        public Guid VehicleId { get; set; }
        public Guid RenterId { get; set; }            // user/customer id
        public DateTime StartUtc { get; set; }        // consider DateRange VO for domain checks
        public DateTime EndUtc { get; set; }
        public BookingStatus Status { get; set; }
        public Money TotalAmount { get; set; } = null!;  // Owned VO
        public string? PricingSnapshotJson { get; set; } // store PricingSnapshot as JSON (or Owned)
        public string? IdempotencyKey { get; set; }      // nullable, unique where not null (partial index)
        public Guid? PaymentId { get; set; }
        public string? CancellationReason { get; set; }
        public Guid? DisputeId { get; set; } // link to dispute if any
        public InspectionCheckpoint PickupInspection { get; set; } = null!; // Owned VO
        public InspectionCheckpoint ReturnInspection { get; set; } = null!; // Owned VO
        public TimeSpan Duration => EndUtc - StartUtc;

    }

}
