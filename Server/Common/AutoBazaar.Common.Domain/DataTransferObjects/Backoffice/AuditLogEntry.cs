using AutoBazaar.Common.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.DataTransferObjects.Backoffice
{
    public class AuditLogEntry
    {
        public AuditLogType Type { get; set; }
        public Guid EntityId { get; set; }
        public OperationType Operation { get; set; }
        public string UserId { get; set; } = null!;
        public string CorrelationId { get; set; } = null!;
        public string PayloadJson { get; set; } = "{}";
        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    }
}
