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
    public class SettlementBatch : BaseEntity<Guid>
    {
        public DateTime SettlementStart { get; set; }
        public DateTime SettlementEnd { get; set; }
        public SettlementBatchStatus Status { get; set; }
        public Money TotalAmount { get; set; } = null!;
        public Money Fees { get; set; } = null!;
        public string? BankReference { get; set; }

    }
}
