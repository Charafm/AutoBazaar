using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Interfaces.Backoffice
{
    public interface IScheduleService
    {
        Task<ScheduleDto> CreateScheduleAsync(CreateScheduleRequest request, AuditContext audit, CancellationToken ct = default);
        Task<ScheduleDto> UpdateScheduleAsync(Guid scheduleId, UpdateScheduleRequest request, AuditContext audit, CancellationToken ct = default);
        Task DeleteScheduleAsync(Guid scheduleId, AuditContext audit, CancellationToken ct = default);
        Task<bool> HasScheduleConflictAsync(Guid subjectId, DateRange candidate, CancellationToken ct = default);
        Task<IEnumerable<ScheduleDto>> GetSchedulesAsync(ScheduleQuery query, CancellationToken ct = default);
    }
}
