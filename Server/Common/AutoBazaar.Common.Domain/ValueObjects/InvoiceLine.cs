using AutoBazaar.Common.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.ValueObjects
{
    public sealed class InvoiceLine : ValueObject
    {
        private InvoiceLine() { }

        public string Description { get; private set; } = null!;
        public Money Amount { get; private set; } = null!;
        public string? TaxCode { get; private set; }
        public int Quantity { get; private set; }

        public InvoiceLine(string description, Money amount, int quantity = 1, string? taxCode = null)
        {
            if (string.IsNullOrWhiteSpace(description)) throw new ArgumentException(nameof(description));
            if (quantity <= 0) throw new ArgumentOutOfRangeException(nameof(quantity));
            Description = description.Trim();
            Amount = amount ?? throw new ArgumentNullException(nameof(amount));
            Quantity = quantity;
            TaxCode = string.IsNullOrWhiteSpace(taxCode) ? null : taxCode;
        }

        public Money LineTotal() => Amount.Multiply(Quantity);

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return Description;
            yield return Amount;
            yield return TaxCode;
            yield return Quantity;
        }
    }
}
