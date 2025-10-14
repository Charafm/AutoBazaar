using AutoBazaar.Common.Domain.DataTransferObjects.Backoffice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Interfaces.Payment
{
    public interface IPaymentService
    {
        Task<PaymentDto> AuthorizePaymentAsync(Guid bookingId, PaymentRequest request, CancellationToken ct = default);
        Task<PaymentDto> CapturePaymentAsync(Guid paymentId, PaymentCaptureRequest request, CancellationToken ct = default);
        Task<PaymentDto> RefundPaymentAsync(Guid paymentId, PaymentRefundRequest request, CancellationToken ct = default);
        Task HandleGatewayWebhookAsync(string provider, string rawPayload, IDictionary<string, string> headers, CancellationToken ct = default);
        Task<PaymentDto?> GetPaymentAsync(Guid paymentId, CancellationToken ct = default);
    }
}
