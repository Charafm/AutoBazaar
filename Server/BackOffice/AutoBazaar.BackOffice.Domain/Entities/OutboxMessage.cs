using AutoBazaar.Common.Domain.BaseEntities;
using AutoBazaar.Common.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.BackOffice.Domain.Entities
{
    public class OutboxMessage : BaseEntity<Guid>
    {
        public OutboxMessageType MessageType { get; set; }
        public string Payload { get; set; } = null!;
        public DateTime OccurredAtUtc { get; set; }
        public DateTime? ProcessedAtUtc { get; set; }
        public bool IsProcessed => ProcessedAtUtc.HasValue;
        public int RetryCount { get; set; }
        public string DestinationService { get; set; } = null!;
    }
}
