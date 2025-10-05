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
    public class InspectionReport : BaseEntity<Guid>
    {
        public Guid VehicleId { get; set; }
        public Guid InspectorId { get; set; } // person / org id
        public DateTime PerformedAtUtc { get; set; }
        public InspectionOutcome Outcome { get; set; }
        public string? ReportJson { get; set; }   // structured details
        public List<DocumentMetadata> Photos { get; set; } = new();
    }

}
