using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.DataTransferObjects.Backoffice
{
    public class EscrowBalanceDto
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; } = null!;
        public Money Balance { get; set; } = null!;
    }
}
