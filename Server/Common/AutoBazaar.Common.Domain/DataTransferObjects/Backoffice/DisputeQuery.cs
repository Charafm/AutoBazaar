using AutoBazaar.Common.Domain.Enums;
using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.DataTransferObjects.Backoffice
{
    public class DisputeQuery
    {
        public PersonName? RaisedByName { get; set; } // optional filter by name
        public Guid? VehicleId { get; set; } // optional filter by vehicle
        public DateTime? FromUtc { get; set; } // dispute raised from
        public DateTime? ToUtc { get; set; } // dispute raised to
        public DisputeType? Type { get; set; } // e.g. "Damage", "Late Return", "Other  "
    }
}
