using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Interfaces.Backoffice
{
    public interface IVehicleValuationService
    {
        Task<ValuationResult> EstimateResidualValueAsync(Guid vehicleId, ValuationRequest request, CancellationToken ct = default);
        Task<BatchValuationResult> RevalueFleetAsync(ValuationBatchRequest request, CancellationToken ct = default);
    }
}
