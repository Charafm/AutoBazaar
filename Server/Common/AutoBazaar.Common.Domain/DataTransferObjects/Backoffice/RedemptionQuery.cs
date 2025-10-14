using AutoBazaar.Common.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.DataTransferObjects.Backoffice
{
    public class RedemptionQuery
    {
        public Guid? FleetOwner { get; set; }
        public DiscountType? DiscountType { get; set; }
        public DateTime? RedeemedAfter { get; set; }
        public DateTime? RedeemedBefore { get; set; }
        public bool? IsProcessed { get; set; }
        public DiscountTarget? Target { get; set; }
    }
}
