using AutoBazaar.Common.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.ValueObjects
{
    public sealed class PricingSnapshot : ValueObject
    {
        private PricingSnapshot() { } // EF for JSON mapping

        public Money BasePrice { get; private set; } = null!;
        public Money Taxes { get; private set; } = null!;
        public Money Fees { get; private set; } = null!;
        public decimal DiscountPct { get; private set; }
        public string? RuleId { get; private set; } // rule that produced price

        public PricingSnapshot(Money basePrice, Money taxes, Money fees, decimal discountPct = 0, string? ruleId = null)
        {
            if (basePrice.Currency != taxes.Currency || basePrice.Currency != fees.Currency)
                throw new InvalidOperationException("currency mismatch in pricing snapshot");
            BasePrice = basePrice;
            Taxes = taxes;
            Fees = fees;
            DiscountPct = discountPct;
            RuleId = ruleId;
        }

        public Money Total() => BasePrice.Add(Taxes).Add(Fees).Multiply(1 - DiscountPct / 100m);

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
