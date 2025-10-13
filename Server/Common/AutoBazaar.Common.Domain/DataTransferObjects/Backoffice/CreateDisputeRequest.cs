using AutoBazaar.Common.Domain.Enums;
using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.DataTransferObjects.Backoffice
{
    public class CreateDisputeRequest
    {
        public Guid BookingId { get; set; }
        public Guid RaisedBy { get; set; }
        public DisputeType Type { get; set; }
        public DisputeStatus Status { get; set; } = DisputeStatus.Open;
        public Money ClaimedAmount { get; set; } = null!;
        public List<DocumentMetadata> Evidence { get; set; } = new();
        public string ResolutionDetails { get; set; } = null!;
        public Guid? AdjustmentPaymentId { get; set; }
    }
}
