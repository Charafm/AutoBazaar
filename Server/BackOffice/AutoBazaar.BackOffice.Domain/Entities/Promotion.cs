using AutoBazaar.Common.Domain.BaseEntities;
using AutoBazaar.Common.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.BackOffice.Domain.Entities
{
    public class Promotion : BaseEntity<Guid>
    {
        public Guid OwnerId { get; set; } // person / org id
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DiscountType DiscountType { get; set; }

        public DateTime StartAtUtc { get; set; }
        public DateTime EndAtUtc { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal? MaxDiscountAmount { get; set; }
        public List<string> ApplicableVehicleCategories { get; set; } = new();
        public bool IsActive => DateTime.UtcNow >= StartAtUtc && DateTime.UtcNow <= EndAtUtc;
    }
}
