using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.DataTransferObjects.Backoffice
{
    public class CouponRedemptionDto
    {
        public List<CouponDto> Coupons { get; set; } = new();
    }
  }
