using AutoBazaar.Common.Domain.Enums;
using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.DataTransferObjects.Backoffice
{
    public class UpdateVehicleRequest
    {
        public Guid? OwnerId { get; set; }
        public string? VIN { get; set; } = null!;
        public string? LicensePlate { get; set; }
        public DateTime? RegistrationDateUtc { get; set; }
        public DateTime? RetireDateUtc { get; set; }
        public VehicleSpecs? Specs { get; set; } = null!;
        public GeoLocation? Location { get; set; }
        public int? CurrentOdometer { get; set; }
        public VehicleStatus? Status { get; set; }
        public Guid? CurrentBookingId { get; set; }
        public int? ServiceCount { get; set; }
        public DateTime? LastServicedAtUtc { get; set; }
        public Money? BookValue { get; set; }

            }
}
