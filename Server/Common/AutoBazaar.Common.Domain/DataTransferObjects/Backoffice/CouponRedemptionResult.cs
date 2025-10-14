using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.DataTransferObjects.Backoffice
{
    public class CouponRedemptionResult
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? NewTotalAmount { get; set; }
    }
}
