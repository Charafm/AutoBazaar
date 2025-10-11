using AutoBazaar.Common.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.ValueObjects
{
    public sealed class IdempotencyKey : ValueObject
    {
        private IdempotencyKey() { } // EF

        public string Key { get; private set; } = null!;
        public DateTime CreatedAtUtc { get; private set; }

        public IdempotencyKey(string key, DateTime createdAt)
        {
            if (string.IsNullOrWhiteSpace(key)) throw new ArgumentNullException(nameof(key));
            Key = key.Trim();

            // be forgiving: convert to UTC if caller passed local time
            CreatedAtUtc = createdAt.Kind == DateTimeKind.Utc ? createdAt : createdAt.ToUniversalTime();
        }

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return Key;
            yield return CreatedAtUtc;
        }
    }
}
