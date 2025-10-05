using AutoBazaar.Common.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.ValueObjects
{
    public sealed class DateRange : ValueObject
    {
        private DateRange() { } // EF

        public DateTime StartUtc { get; private set; }
        public DateTime EndUtc { get; private set; }

        public DateRange(DateTime startUtc, DateTime endUtc)
        {
            if (startUtc.Kind != DateTimeKind.Utc || endUtc.Kind != DateTimeKind.Utc)
                throw new ArgumentException("Use UTC times.");
            if (endUtc <= startUtc) throw new ArgumentException("End must be after start.");
            StartUtc = startUtc;
            EndUtc = endUtc;
        }

        public bool Overlaps(DateRange other)
        {
            return StartUtc < other.EndUtc && other.StartUtc < EndUtc;
        }

        public TimeSpan Duration => EndUtc - StartUtc;

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return StartUtc;
            yield return EndUtc;
        }
    }

}
