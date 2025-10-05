using AutoBazaar.Common.Domain.BaseEntities;
using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.BackOffice.Domain.Entities
{
    public class MaintenanceRecord : BaseEntity<Guid>
    {
        public Guid VehicleId { get; set; }
        public DateTime PerformedAtUtc { get; set; }
        public string Description { get; set; } = null!;
        public Money? Cost { get; set; }
        public string? Vendor { get; set; }
        public bool IsWarranty { get; set; }
    }

}
