using AutoBazaar.Common.Domain.Enums;
using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.DataTransferObjects.Backoffice
{
    public class PaymentDto
    {
        public Guid BookingId { get; set; }
        public Guid PayerId { get; set; }
        public Money Amount { get; set; } = null!;
        public decimal Fees { get; set; }
        public PaymentStatus Status { get; set; }
        public PaymentMethod Method { get; set; }
        public EscrowStatus EscrowStatus { get; set; }
        public string? PspTransactionId { get; set; } // unique id from PSP
        public string? SettlementBatchId { get; set; }
        public string ExternalResponseJson { get; set; } = null!;
    }
}
