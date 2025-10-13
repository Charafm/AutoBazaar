using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.DataTransferObjects.Backoffice
{
    public class EscrowBalanceQuery
    {
        public Guid? UserId { get; set; } // fleet owner
        public string? UserName { get; set; } // fleet owner
        public Guid? FleetOwnerId { get; set; } 
    }
}
