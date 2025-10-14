using AutoBazaar.Common.Application.Entities;
using AutoBazaar.Common.Domain.DataTransferObjects.Backoffice;
using AutoBazaar.Common.Domain.Enums;
using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Interfaces.Backoffice
{
    public interface IVehicleCatalogService
    {
        Task<VehicleDto> RegisterVehicleAsync(CreateVehicleRequest request, AuditContext auditContext, CancellationToken ct = default);
        Task<VehicleDto> UpdateVehicleAsync(Guid vehicleId, UpdateVehicleRequest request, AuditContext audit, CancellationToken ct = default);
        Task SetVehicleStatusAsync(Guid vehicleId, VehicleStatus newStatus, AuditContext audit, CancellationToken ct = default);
        Task<VehicleDto?> GetVehicleAsync(Guid vehicleId, CancellationToken ct = default);
        Task<PagedResult<VehicleSearchResultDto>> SearchVehiclesAsync(VehicleSearchQuery query, CancellationToken ct = default);
        Task AddVehicleDocumentAsync(Guid vehicleId, DocumentMetadata metadata, AuditContext audit, CancellationToken ct = default);
        Task SoftDeleteVehicleAsync(Guid vehicleId, AuditContext audit, CancellationToken ct = default);
    }
}
