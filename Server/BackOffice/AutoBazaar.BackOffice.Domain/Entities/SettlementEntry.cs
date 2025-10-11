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
    public class SettlementEntry : BaseEntity<Guid>
    {
        public Guid SettlementBatchId { get; set; }
        public Guid FleetOwnerId { get; set; }
        public Money AmmountToOwner { get; set; } = null!;
        public List<Guid> Payments { get; set; } = new();
        public string? BankReference { get; set; }
        public SettlementEntryStatus Status { get; set; }
        public string? Notes { get; set; }

    }
}
