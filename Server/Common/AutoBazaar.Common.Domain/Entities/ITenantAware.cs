using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.Entities
{
    public interface ITenantAware
    {
        string? TenantId { get; set; }
    }
}
