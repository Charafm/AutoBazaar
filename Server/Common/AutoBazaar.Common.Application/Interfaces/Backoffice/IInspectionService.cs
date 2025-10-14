using AutoBazaar.Common.Domain.DataTransferObjects.Backoffice;
using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Interfaces.Backoffice
{
    public interface IInspectionService
    {
        Task<InspectionReportDto> CreateInspectionAsync(CreateInspectionRequest request, AuditContext audit, CancellationToken ct = default);
        Task AddInspectionPhotoAsync(Guid inspectionId, DocumentMetadata metadata, AuditContext audit, CancellationToken ct = default);
        Task<InspectionReportDto?> GetInspectionAsync(Guid inspectionId, CancellationToken ct = default);
    }
}
