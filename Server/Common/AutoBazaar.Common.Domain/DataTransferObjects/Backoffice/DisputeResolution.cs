using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.DataTransferObjects.Backoffice
{
    public class DisputeResolution
    {
        public string ResolutionDetails { get; set; } = null!;
        public Guid? AdjustmentPaymentId { get; set; }
        public Money? AdjustmentMoney { get; set; }
        public DateTime? AdjustmentDate { get; set; }
    }
}
