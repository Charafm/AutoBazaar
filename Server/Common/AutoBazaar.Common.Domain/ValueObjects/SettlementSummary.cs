using AutoBazaar.Common.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.ValueObjects
{
    public sealed class SettlementSummary : ValueObject
    {
        private SettlementSummary() { }

        public Money TotalAmount { get; private set; } = null!;
        public decimal TotalFees { get; private set; }
        public DateTime PeriodStart { get; private set; }
        public DateTime PeriodEnd { get; private set; }

        public SettlementSummary(Money totalAmount, decimal totalFees, DateTime periodStart, DateTime periodEnd)
        {
            TotalAmount = totalAmount ?? throw new ArgumentNullException(nameof(totalAmount));
            if (totalFees < 0) throw new ArgumentOutOfRangeException(nameof(totalFees));
            if (periodEnd <= periodStart) throw new ArgumentException("PeriodEnd must be after PeriodStart");

            TotalFees = decimal.Round(totalFees, 2);
            PeriodStart = periodStart.Kind == DateTimeKind.Utc ? periodStart : periodStart.ToUniversalTime();
            PeriodEnd = periodEnd.Kind == DateTimeKind.Utc ? periodEnd : periodEnd.ToUniversalTime();
        }

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return TotalAmount;
            yield return TotalFees;
            yield return PeriodStart;
            yield return PeriodEnd;
        }
    }
}
