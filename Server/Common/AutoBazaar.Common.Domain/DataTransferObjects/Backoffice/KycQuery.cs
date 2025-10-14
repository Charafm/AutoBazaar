using AutoBazaar.Common.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.DataTransferObjects.Backoffice
{
    public class KycQuery
    {
        public Guid? SubjectId { get; set; }  
        public string? SubjectName { get; set; } 
        public KycType? Type { get; set; }
        public KycStatus? Status { get; set; }
        public DateTime? SubmittedAfter { get; set; }
        public DateTime? SubmittedBefore { get; set; }
        public bool? IsRejected { get; set; }
        public bool? IsVerified { get; set; }
        public bool? HasDocuments { get; set; }
    }
}
