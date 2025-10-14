using AutoBazaar.Common.Domain.Enums;
using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.DataTransferObjects.Backoffice
{
    public class CouponDto
    {
        public string Code { get; set; } = null!;
        public DiscountType Type { get; set; }
        public DiscountTarget Target { get; set; }
        public decimal Value { get; set; }
        public DateTime ValidFromUtc { get; set; }
        public DateTime? ValidToUtc { get; set; }
        public int UsageLimit { get; set; } // total number of times this coupon can be used
        public Money MinimumSpend { get; set; } = null!;
        public bool IsStackable { get; set; }
    }
}
