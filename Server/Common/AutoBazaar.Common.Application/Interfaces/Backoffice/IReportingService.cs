using AutoBazaar.Common.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Interfaces.Backoffice
{
    public interface IReportingService
    {
        Task<KpiSnapshot> GetKpiSnapshotAsync(DateRange dateRange, CancellationToken ct = default);
        Task<FileResult> ExportReconciliationAsync(ReconciliationExportRequest request, CancellationToken ct = default);
        Task<DailyGmvReport> GetDailyGmvAsync(DateRange range, CancellationToken ct = default);
    }
}
