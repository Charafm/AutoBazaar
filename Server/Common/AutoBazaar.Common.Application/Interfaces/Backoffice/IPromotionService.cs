using AutoBazaar.Common.Domain.DataTransferObjects.Backoffice;
using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Interfaces.Backoffice
{
    public interface IPromotionService
    {
        Task<CouponDto> CreateCouponAsync(CreateCouponRequest request, AuditContext audit, CancellationToken ct = default);
        Task<CouponRedemptionResult> RedeemCouponAsync(string couponCode, Guid userId, Guid bookingId, CancellationToken ct = default);
        Task<PromotionDto?> GetPromotionAsync(Guid promotionId, CancellationToken ct = default);
        Task<IEnumerable<CouponRedemptionDto>> QueryRedemptionsAsync(RedemptionQuery query, CancellationToken ct = default);

    }
}
