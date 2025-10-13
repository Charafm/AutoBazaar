using AutoBazaar.Common.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.DataTransferObjects.Backoffice
{
    public class AvailabilityQuery
    {
        public string? Model { get; set; }
        public string? Make { get; set; }
        public FuelType? FuelType { get; set; }
        public int? Seats { get; set; }
        public TransmitionType? TransmitionType { get; set; }
        public Guid? OwnerId { get; set; }
        public DateTime? AvailableFromUtc { get; set; }
        public DateTime? AvailableToUtc { get; set; }
    }
}
