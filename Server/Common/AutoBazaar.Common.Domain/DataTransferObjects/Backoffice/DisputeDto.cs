using AutoBazaar.Common.Domain.Enums;
using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.DataTransferObjects.Backoffice
{
    public class DisputeDto
    {   
        public Guid BookingId { get; set; }
        public Guid RaisedBy { get; set; }
        public PersonName PersonName { get; set; } = null!;
        public DisputeType Type { get; set; }
        public DisputeStatus Status { get; set; }
        public Money ClaimedAmount { get; set; } = null!;
        public List<DocumentMetadata> Evidence { get; set; } = new();
        public string ResolutionDetails { get; set; } = null!;
        public Guid? AdjustmentPaymentId { get; set; }
    }
}
