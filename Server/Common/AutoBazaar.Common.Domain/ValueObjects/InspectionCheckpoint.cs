using AutoBazaar.Common.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.ValueObjects
{
    public sealed class InspectionCheckpoint : ValueObject
    {
        private InspectionCheckpoint() { } // EF
        
        public Guid BookingId { get; private set; }
        public int OdometerReading { get; private set; } // in kilometers
        public List<DocumentMetadata> Photos { get; private set; } = new();
        public DateTime RecordedAtUtc { get; private set; }
        public Guid CreatedBy { get; private set; } // user id
        public InspectionCheckpoint(Guid bookingId, int odometerReading , List<DocumentMetadata> photos, DateTime recordedAt, Guid createdBy)
        {
            BookingId = BookingId;
            OdometerReading = odometerReading;
            Photos = photos;
            if (recordedAt.Kind != DateTimeKind.Utc) throw new ArgumentException("Use UTC times");
            CreatedBy = createdBy;
            RecordedAtUtc = recordedAt;
        }

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return BookingId;
            yield return OdometerReading;
            yield return Photos;
            yield return RecordedAtUtc;
            yield return CreatedBy;
        }
    }

}
