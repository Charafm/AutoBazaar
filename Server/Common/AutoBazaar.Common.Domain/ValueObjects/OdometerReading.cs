using AutoBazaar.Common.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.ValueObjects
{
    public sealed class OdometerReading : ValueObject
    {
        private OdometerReading() { } // EF

        public long Value { get; private set; } // in kilometers or meters per domain decision
        public DateTime RecordedAtUtc { get; private set; }

        public OdometerReading(long value, DateTime recordedAtUtc)
        {
            if (value < 0) throw new ArgumentOutOfRangeException(nameof(value));
            if (recordedAtUtc.Kind != DateTimeKind.Utc) throw new ArgumentException("Use UTC times");
            Value = value;
            RecordedAtUtc = recordedAtUtc;
        }

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return Value;
            yield return RecordedAtUtc;
        }
    }

}
