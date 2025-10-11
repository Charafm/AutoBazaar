using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.Enums
{
    public enum OperationType
    {
        Create,
        Read,
        Update,
        Delete,
        Payment,
        Dispute,
        Invoice,
        Maintenance,
        Booking,
        Refund
    }
}
