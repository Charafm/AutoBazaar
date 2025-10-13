using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Interfaces.Backoffice
{
     public interface IKycService
    {
        Task<KycRecordDto> SubmitKycAsync(Guid subjectId, KycSubmissionRequest request, CancellationToken ct = default);
        Task<KycRecordDto?> GetKycRecordAsync(Guid subjectId, CancellationToken ct = default);
        Task HandleExternalKycResultAsync(Guid kycRecordId, ExternalKycResult result, CancellationToken ct = default);

    }
}
