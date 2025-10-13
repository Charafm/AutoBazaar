using AutoBazaar.Common.Domain.Enums;
using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.DataTransferObjects.Backoffice
{
    public class BookingQuery
    {
        public Guid? BookingId { get; set; }
        public Guid? UserId { get; set; } // renter or fleet owner
        public PersonName? UserName { get; set; } // renter or fleet owner
        public Guid? VehicleId { get; set; }
        public DateTime? FromUtc { get; set; } // booking start time
        public DateTime? ToUtc { get; set; } // booking end time
        public BookingStatus? Status { get; set; } // e.g. "Pending", "Confirmed", "Cancelled", "Completed"
    }
}
