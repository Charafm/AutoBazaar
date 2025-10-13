using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Interfaces.Payment
{
    public interface IPaymentReconciliationService
    {
        Task<ReconciliationReport> ReconcilePspFileAsync(Stream fileStream, string provider, CancellationToken ct = default);
        Task CreateAdjustmentAsync(ReconciliationAdjustmentRequest request, CancellationToken ct = default);
        Task<ReconciliationSummaryDto> GetLastReconciliationAsync(string provider, DateRange range, CancellationToken ct = default);
    }
}
