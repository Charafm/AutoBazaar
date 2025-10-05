using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.BackOffice.Domain.Entities
{
    public class IdempotencyEntry
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Key { get; set; } = null!;  // idempotency key
        public string ResultJson { get; set; } = null!; // small payload summary
        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    }

}
