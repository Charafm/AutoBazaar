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
    public class AuctionListing : BaseEntity<Guid>
    {
        public Guid VehicleId { get; set; }
        public ListingType ListingType { get; set; }
        public AuctionStatus Status { get; set; }
        public DateTime StartTimeUtc { get; set; }
        public DateTime EndTimeUtc { get; set; }
        public Money StartingBid { get; set; } = null!;
        public Money? ReservePrice { get; set; }
        public Money? BuyNowPrice { get; set; }
        public bool IsActive { get; set; }
        public List<Guid> BidIds { get; set; } = new();
        public Guid? WinningBidId { get; set; }
        public Guid SellerId { get; set; }
        public string? Description { get; set; }
        public decimal CommissionRate { get; set; } // e.g., 0.05 for 5%
        public List<DocumentMetadata> PhotoUrls { get; set; } = new();
    }
}
