using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Interfaces.Backoffice
{
    public interface IMaintenanceService
    {
        Task<MaintenanceRecordDto> CreateMaintenanceRecordAsync(CreateMaintenanceRequest request, AuditContext audit, CancellationToken ct = default);
        Task<IEnumerable<MaintenanceRecordDto>> GetMaintenanceForVehicleAsync(Guid vehicleId, CancellationToken ct = default);
        Task ScheduleMaintenanceAsync(Guid vehicleId, DateRange window, CreateMaintenanceRequest request, AuditContext audit, CancellationToken ct = default);
    }
}
