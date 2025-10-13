using AutoBazaar.Common.Domain.DataTransferObjects.Backoffice;
using AutoBazaar.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Interfaces.Backoffice
{
    public interface IBookingService
    {
        Task<BookingDto> CreateBookingHoldAsync(CreateBookingRequest request, CancellationToken ct = default);
        Task<BookingDto> ConfirmBookingAsync(Guid bookingId, BookingConfirmRequest request, CancellationToken ct = default);
        Task StartBookingAsync(Guid bookingId, InspectionCheckpointDto pickupInspection, AuditContext audit, CancellationToken ct = default);
        Task CompleteBookingAsync(Guid bookingId, InspectionCheckpointDto returnInspection, CancellationToken ct = default);
        Task CancelBookingAsync(Guid bookingId, CancelBookingRequest request, AuditContext audit, CancellationToken ct = default);
        Task<BookingDto?> GetBookingAsync(Guid bookingId, CancellationToken ct = default);
        Task<IEnumerable<BookingDto>> QueryBookingsAsync(BookingQuery query, CancellationToken ct = default);

    }
}
