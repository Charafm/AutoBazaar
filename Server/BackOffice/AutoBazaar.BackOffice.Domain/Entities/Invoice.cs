using AutoBazaar.Common.Domain.BaseEntities;
using AutoBazaar.Common.Domain.Enums;
using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.BackOffice.Domain.Entities
{
    public class Invoice : BaseEntity<Guid>
    {
        public Guid IssuerId { get; set; }
        public Guid RecipientId { get; set; }
        public DateTime IssuedAtUtc { get; set; }
        public DateTime? DueAtUtc { get; set; }
        public DateTime? PaidAtUtc { get; set; }
        public Guid? RelatedBookingId { get; set; }
        public Guid? RelatedMaintenanceRecordId { get; set; }
        public Guid? PaymentId { get; set; }
        public Money Subtotal { get; set; } = null!;
        public Money Tax { get; set; } = null!;
        public Money Total { get; set; } = null!;
        public InvoiceStatus Status { get; set; }
        public string? ExternalReceiptRef { get; set; }
    }
}
