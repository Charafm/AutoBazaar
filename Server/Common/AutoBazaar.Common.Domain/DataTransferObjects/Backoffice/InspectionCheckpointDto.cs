using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.DataTransferObjects.Backoffice
{
    public class InspectionCheckpointDto
    {
        public int OdometerReading { get; set; } // in kilometers
        public List<DocumentMetadata> Photos { get; set; } = new();
        public DateTime RecordedAtUtc { get; set; }
        public Guid CreatedBy { get; set; } // user id
    }
}
