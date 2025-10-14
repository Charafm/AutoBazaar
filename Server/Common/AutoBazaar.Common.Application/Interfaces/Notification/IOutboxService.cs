using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Interfaces.Notification
{
    public interface IOutboxService
    {
        //Task EnqueueAsync(OutboxMessage message, CancellationToken ct = default);
        //Task MarkProcessedAsync(Guid outboxMessageId, DateTime processedOnUtc, CancellationToken ct = default);
        //Task<IEnumerable<OutboxMessage>> ReadPendingAsync(int maxBatch, CancellationToken ct = default);

    }
}
