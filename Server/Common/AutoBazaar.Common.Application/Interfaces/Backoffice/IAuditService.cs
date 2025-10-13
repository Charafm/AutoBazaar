using AutoBazaar.Common.Domain.DataTransferObjects.Backoffice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Interfaces.Backoffice
{
    public interface IAuditService
    {
        Task WriteAuditAsync(AuditLogEntry entry, CancellationToken ct = default);
        Task<IEnumerable<AuditLogEntry>> QueryAsync(AuditQuery query, CancellationToken ct = default);
    }
}
