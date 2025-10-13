using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Interfaces.Backoffice
{
    public interface IIdempotencyService
    {
        Task<IdempotencyResult> TryCreateIdempotencyAsync(string key, string payloadHash, CancellationToken ct = default);
        Task StoreResultAsync(string key, string resultJson, CancellationToken ct = default);
        Task<IdempotencyEntry?> GetEntryAsync(string key, CancellationToken ct = default);
    }
}
