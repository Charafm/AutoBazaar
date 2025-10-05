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
        private Money() { }

        public decimal Amount { get; }
        public string Currency { get; }

        public Money(decimal amount, string currency)
        {
            if (string.IsNullOrWhiteSpace(currency)) throw new ArgumentException(nameof(currency));
            Amount = decimal.Round(amount, 2);
            Currency = currency.ToUpperInvariant();
        }

        public Money Add(Money other)
        {
            if (other.Currency != Currency) throw new InvalidOperationException("Currency mismatch");
            return new Money(Amount + other.Amount, Currency);
        }
        public Money Multiply(decimal factor, int scale = 2, MidpointRounding rounding = MidpointRounding.ToEven)
        {

            var result = Amount * factor;
            result = Math.Round(result, scale, rounding);
            return new Money(result, Currency);
        }
        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return Amount;
            yield return Currency;
        }
    }
}
