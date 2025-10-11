using AutoBazaar.Common.Domain.BaseEntities;
using AutoBazaar.Common.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.BackOffice.Domain.Entities
{
    public class AuditLog : BaseEntity<Guid>
    {

        public AuditLogType EntityType { get; set; }
        public Guid EntityId { get; set; }
        public OperationType Operattion { get; set; }
        public string UserId { get; set; } = null!;
        public string CorrelationId { get; set; } = null!;
        public string PayloadJson { get; set; } = "{}";
        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    }

}
