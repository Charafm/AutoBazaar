using AutoBazaar.Common.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.DataTransferObjects.Backoffice
{
    public class AuditQuery
    {
        public AuditLogType? Type { get; set; }
        public Guid? EntityId { get; set; }
        public OperationType? Operation { get; set; }
        public string? UserId { get; set; }
        public string? CorrelationId { get; set; }
        //public string? UserName { get; set; } = string.Empty;
        public DateTime? FromUtc { get; set; }
        public DateTime? ToUtc { get; set; }
    }
}
