using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.DataTransferObjects.Backoffice
{
    public class CreateMaintenanceRequest
    {
        public Guid VehicleId { get; set; }
        public DateTime PerformedAtUtc { get; set; }
        public string Description { get; set; } = null!;
        public Money? Cost { get; set; }
        public string? Vendor { get; set; }
        public bool IsWarranty { get; set; }
        public Guid? RelatedInvoiceId { get; set; }
    }
}
