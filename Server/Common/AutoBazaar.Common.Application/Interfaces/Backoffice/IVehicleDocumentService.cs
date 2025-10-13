using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Interfaces.Backoffice
{
    public interface IVehicleDocumentService
    {
        Task<DocumentMetadata> UploadVehicleDocumentAsync(Guid vehicleId, Stream file, string fileName, string contentType, AuditContext audit, CancellationToken ct = default);
        Task<IReadOnlyList<DocumentMetadata>> GetVehicleDocumentsAsync(Guid vehicleId, CancellationToken ct = default);
        Task RemoveDocumentMetadataAsync(Guid documentId, AuditContext audit, CancellationToken ct = default);
    }
}
