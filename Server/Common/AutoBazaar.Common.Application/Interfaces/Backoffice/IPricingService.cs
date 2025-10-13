using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Interfaces.Backoffice
{
    public interface IPricingService
    {
        Task<PricingSnapshot> ComputePriceAsync(PriceRequest request, CancellationToken ct = default);
        Task<PromotionApplicationResult> EvaluatePromotionsAsync(PromotionEvaluationRequest request, CancellationToken ct = default);

    }
}
