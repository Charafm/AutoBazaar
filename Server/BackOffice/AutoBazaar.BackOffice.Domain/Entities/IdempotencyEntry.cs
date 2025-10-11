using AutoBazaar.Common.Domain.BaseEntities;
using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.BackOffice.Domain.Entities
{
    public class IdempotencyEntry   : BaseEntity<Guid>
    {
       public IdempotencyKey Key { get; set; } = null!;  // idempotency key
       public string ResultJson { get; set; } = null!; // small payload summary
       
    }

}
