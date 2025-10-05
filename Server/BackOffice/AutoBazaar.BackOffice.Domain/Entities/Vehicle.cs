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
    public class Vehicle : BaseEntity<Guid>
    {
        public Guid OwnerId { get; set; }            // FK to FleetOwner / User
        public string VIN { get; set; } = null!;     // unique
        public string? LicensePlate { get; set; }
        public VehicleSpecs Specs { get; set; } = null!; // Value Object (Owned)
        public GeoLocation? Location { get; set; }   // Owned VO
        public int CurrentOdometer { get; set; }     // last known
        public VehicleStatus Status { get; set; }    // enum
        public Guid? CurrentBookingId { get; set; }  // optional

        // Collections
        public List<InspectionReport> Inspections { get; set; } = new();
        public List<MaintenanceRecord> MaintenanceRecords { get; set; } = new();

        // Soft delete, audit, RowVersion are on BaseEntity
    }

}
