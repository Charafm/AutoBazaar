using AutoBazaar.Common.Domain.DataTransferObjects.Backoffice;
using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Interfaces.Backoffice
{
    public interface IDisputeService
    {
        Task<DisputeDto> CreateDisputeAsync(CreateDisputeRequest request, CancellationToken ct = default);
        Task ResolveDisputeAsync(Guid disputeId, DisputeResolution resolution, AuditContext audit, CancellationToken ct = default);
        Task<DisputeDto?> GetDisputeAsync(Guid disputeId, CancellationToken ct = default);
        Task<IEnumerable<DisputeDto>> QueryDisputesAsync(DisputeQuery query, CancellationToken ct = default);
    }
}
