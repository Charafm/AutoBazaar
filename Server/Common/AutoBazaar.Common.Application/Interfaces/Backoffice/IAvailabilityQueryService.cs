using AutoBazaar.Common.Application.Entities;
using AutoBazaar.Common.Domain.DataTransferObjects.Backoffice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Interfaces.Backoffice
{
    public interface IAvailabilityQueryService
    {
        Task<PagedResult<VehicleAvailabilityDto>> QueryAvailabilityAsync(AvailabilityQuery query, CancellationToken ct = default);
        Task RefreshAvailabilityForVehicleAsync(Guid vehicleId, CancellationToken ct = default);
        Task RebuildAvailabilityIndexAsync(CancellationToken ct = default);
    }
}
