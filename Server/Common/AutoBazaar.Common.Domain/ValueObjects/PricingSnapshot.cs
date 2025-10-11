using AutoBazaar.Common.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.ValueObjects
{
    public sealed class PricingSnapshot : ValueObject
    {
        private PricingSnapshot() { }

        public Money BasePrice { get; private set; } = null!;
        public Money Taxes { get; private set; } = null!;
        public Money Fees { get; private set; } = null!;
        public decimal DiscountPct { get; private set; } // 0..100
        public string? RuleId { get; private set; }

        [JsonConstructor]
        public PricingSnapshot(Money basePrice, Money taxes, Money fees, decimal discountPct = 0m, string? ruleId = null)
        {
            BasePrice = basePrice ?? throw new ArgumentNullException(nameof(basePrice));
            Taxes = taxes ?? throw new ArgumentNullException(nameof(taxes));
            Fees = fees ?? throw new ArgumentNullException(nameof(fees));

            // currency consistency
            if (!string.Equals(BasePrice.Currency, Taxes.Currency, StringComparison.OrdinalIgnoreCase) ||
                !string.Equals(BasePrice.Currency, Fees.Currency, StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("Currency mismatch in pricing snapshot");

            if (discountPct < 0m || discountPct > 100m) throw new ArgumentOutOfRangeException(nameof(discountPct));

            DiscountPct = decimal.Round(discountPct, 4);
            RuleId = string.IsNullOrWhiteSpace(ruleId) ? null : ruleId;
        }

        public Money Total()
        {
            var total = BasePrice.Add(Taxes).Add(Fees);
            if (DiscountPct <= 0) return total;
            var factor = (100m - DiscountPct) / 100m;
            return total.Multiply(factor);
        }

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return BasePrice;
            yield return Taxes;
            yield return Fees;
            yield return DiscountPct;
            yield return RuleId;
        }
    }
}
