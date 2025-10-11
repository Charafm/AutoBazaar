using AutoBazaar.Common.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.ValueObjects
{
    public sealed class AuditContext : ValueObject
    {
        private AuditContext() { }

        public Guid CorrelationId { get; private set; }
        public string? UserId { get; private set; }
        public string? Source { get; private set; } // service name
        public DateTime TimestampUtc { get; private set; }

        public AuditContext(Guid correlationId, string? userId, string? source, DateTime? timestampUtc = null)
        {
            CorrelationId = correlationId == Guid.Empty ? Guid.NewGuid() : correlationId;
            UserId = string.IsNullOrWhiteSpace(userId) ? null : userId;
            Source = string.IsNullOrWhiteSpace(source) ? null : source;
            TimestampUtc = (timestampUtc ?? DateTime.UtcNow).ToUniversalTime();
        }

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return CorrelationId;
            yield return UserId;
            yield return Source;
            yield return TimestampUtc;
        }
    }
}
