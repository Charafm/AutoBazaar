using AutoBazaar.Common.Domain.DataTransferObjects.Backoffice;
using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Interfaces.Backoffice
{
    public interface IKycReviewService
    {
        Task VerifyKycAsync(Guid kycRecordId, string verifiedByUserId, AuditContext audit, CancellationToken ct = default);
        Task RejectKycAsync(Guid kycRecordId, string reason, string reviewedBy, AuditContext audit, CancellationToken ct = default);
        Task<IEnumerable<KycRecordDto>> QueryPendingKycAsync(KycQuery query, CancellationToken ct = default);
    }
}
