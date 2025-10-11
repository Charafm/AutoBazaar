using AutoBazaar.Common.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.ValueObjects
{
    public sealed class Money : ValueObject
    {
        private Money() { } // for EF / serializers

        public decimal Amount { get; private set; }
        public string Currency { get; private set; } = null!; // ISO 4217

        public Money(decimal amount, string currency)
        {
            if (string.IsNullOrWhiteSpace(currency)) throw new ArgumentException("currency required", nameof(currency));
            Amount = decimal.Round(amount, 2, MidpointRounding.AwayFromZero);
            Currency = currency.ToUpperInvariant();
        }

        public Money Add(Money other)
        {
            EnsureSameCurrency(other);
            return new Money(Amount + other.Amount, Currency);
        }

        public Money Subtract(Money other)
        {
            EnsureSameCurrency(other);
            return new Money(Amount - other.Amount, Currency);
        }

        public Money Multiply(decimal factor) => new Money(decimal.Round(Amount * factor, 2), Currency);

        private void EnsureSameCurrency(Money other)
        {
            if (other is null) throw new ArgumentNullException(nameof(other));
            if (!string.Equals(other.Currency, Currency, StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("Currency mismatch");
        }

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return Amount;
            yield return Currency;
        }

        public override string ToString() => $"{Currency} {Amount:N2}";
    }
}
