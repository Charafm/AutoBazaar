using AutoBazaar.Common.Domain.Enums;
using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.DataTransferObjects.Backoffice
{
    public class CreateInspectionRequest
    {
        public Guid VehicleId { get; set; }
        public Guid? InspectorId { get; set; } // person / org id
        public Guid? BookingId { get; set; }   // optional link to booking
        public string? InspectorName { get; set; } // denormalized for convenience
        public DateTime PerformedAtUtc { get; set; }
        public InspectionOutcome Outcome { get; set; }
        public string? ReportJson { get; set; }   // structured details
        public List<DocumentMetadata> Photos { get; set; } = new();
        public Money? EstimatedRepairCost { get; set; } = null!;
    }
}
