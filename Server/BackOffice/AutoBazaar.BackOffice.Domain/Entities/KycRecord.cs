using AutoBazaar.Common.Domain.BaseEntities;
using AutoBazaar.Common.Domain.Enums;
using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.BackOffice.Domain.Entities
{
    public class KycRecord : BaseEntity<Guid>
    {
        public Guid SubjectId { get; set; }       // user or owner
        public KycType Type { get; set; }
        public KycStatus Status { get; set; }
        public string? RejectionReason { get; set; }
        public Guid? VerifiedByAdminId { get; set; }
        public DateTime? VerifiedAt { get; set; }

        // Documents as separate rows
        public List<DocumentMetadata> Documents { get; set; } = new();
    }
}
