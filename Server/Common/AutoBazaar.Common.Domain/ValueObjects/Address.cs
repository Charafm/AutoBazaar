using AutoBazaar.Common.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.ValueObjects
{
    public sealed class Address : ValueObject
    {
        private Address() { } // EF

        public string Line1 { get; private set; } = null!;
        public string? Line2 { get; private set; }
        public string City { get; private set; } = null!;
        public string? PostalCode { get; private set; }
        public string CountryCode { get; private set; } = null!; // ISO2/ISO3
                                                                 // For referencial, Or Countries list and DB I need to use CountryCode as string
        public Address(string line1, string city, string countryCode, string? line2 = null, string? postalCode = null)
        {
            if (string.IsNullOrWhiteSpace(line1)) throw new ArgumentException(nameof(line1));
            if (string.IsNullOrWhiteSpace(city)) throw new ArgumentException(nameof(city));
            if (string.IsNullOrWhiteSpace(countryCode)) throw new ArgumentException(nameof(countryCode));
            Line1 = line1.Trim();
            Line2 = line2?.Trim();
            City = city.Trim();
            PostalCode = postalCode?.Trim();
            CountryCode = countryCode.ToUpperInvariant();
        }

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return Line1;
            yield return Line2;
            yield return City;
            yield return PostalCode;
            yield return CountryCode;
        }
    }

}
