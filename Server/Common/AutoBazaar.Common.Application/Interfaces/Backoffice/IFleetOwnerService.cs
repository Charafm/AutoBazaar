using AutoBazaar.Common.Domain.DataTransferObjects.Backoffice;
using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Interfaces.Backoffice
{
    public interface IFleetOwnerService
    {
        Task<FleetOwnerDto> CreateOwnerAsync(CreateFleetOwnerRequest request, AuditContext audit, CancellationToken ct = default);
        Task<FleetOwnerDto?> GetOwnerAsync(Guid ownerId, CancellationToken ct = default);
        Task UpdatePayoutAccountAsync(Guid ownerId, BankAccountInfo bankAccount, AuditContext audit, CancellationToken ct = default);
        Task<IEnumerable<FleetOwnerDto>> SearchOwnersAsync(OwnerSearchQuery query, CancellationToken ct = default);
    }
}
