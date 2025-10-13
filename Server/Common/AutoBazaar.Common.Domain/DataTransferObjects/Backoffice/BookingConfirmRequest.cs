using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.DataTransferObjects.Backoffice
{
    public class BookingConfirmRequest
    {
        public Guid BookingId { get; set; }
        public Guid UserId { get; set; } // who is confirming (renter or fleet owner)
    }
}
