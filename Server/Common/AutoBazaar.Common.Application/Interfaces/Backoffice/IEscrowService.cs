using AutoBazaar.Common.Domain.DataTransferObjects.Backoffice;
using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Interfaces.Backoffice
{
    public interface IEscrowService
    {
        Task<EscrowEntryDto> CreateHoldAsync(Guid paymentId, Guid bookingId, Money amount, string reason, AuditContext audit, CancellationToken ct = default);
        Task<EscrowEntryDto> ReleaseEscrowAsync(Guid bookingId, Money amount, string reason, AuditContext audit, CancellationToken ct = default);
        Task<EscrowEntryDto> CreateReserveAsync(Guid ownerId, Money amount, string reason, AuditContext audit, CancellationToken ct = default);
        Task<EscrowBalanceDto> GetEscrowBalanceAsync(EscrowBalanceQuery query, CancellationToken ct = default);
        Task<IEnumerable<EscrowEntryDto>> QueryEntriesAsync(EscrowQuery query, CancellationToken ct = default);
    }
}
