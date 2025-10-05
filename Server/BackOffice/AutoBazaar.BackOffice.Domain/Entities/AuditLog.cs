using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.BackOffice.Domain.Entities
{
    public class AuditLog
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string EntityType { get; set; } = null!;
        public Guid EntityId { get; set; }
        public string Operation { get; set; } = null!; // Create/Update/Delete/Payment...
        public string UserId { get; set; } = null!;
        public string CorrelationId { get; set; } = null!;
        public string PayloadJson { get; set; } = "{}";
        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    }

}
