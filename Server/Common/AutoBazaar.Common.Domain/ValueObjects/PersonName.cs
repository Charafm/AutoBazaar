using AutoBazaar.Common.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.ValueObjects
{
    public sealed class PersonName : ValueObject
    {
        private PersonName() { } // EF

        public string First { get; private set; } = null!;
        public string? Middle { get; private set; }
        public string Last { get; private set; } = null!;

        public PersonName(string first, string last, string? middle = null)
        {
            if (string.IsNullOrWhiteSpace(first) || string.IsNullOrWhiteSpace(last)) throw new ArgumentException("First and last required");
            First = first.Trim();
            Middle = middle?.Trim();
            Last = last.Trim();
        }

        public string FullName => string.IsNullOrWhiteSpace(Middle) ? $"{First} {Last}" : $"{First} {Middle} {Last}";

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return First;
            yield return Middle;
            yield return Last;
        }
    }

}
