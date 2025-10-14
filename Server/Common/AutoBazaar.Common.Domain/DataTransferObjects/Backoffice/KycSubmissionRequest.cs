using AutoBazaar.Common.Domain.Enums;
using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.DataTransferObjects.Backoffice
{
    public class KycSubmissionRequest
    {
        public Guid SubjectId { get; set; }       // user or owner
        public KycType Type { get; set; }
        public KycStatus Status { get; set; } = KycStatus.Pending;
        public List<DocumentMetadata> Documents { get; set; } = new();
    }
}
