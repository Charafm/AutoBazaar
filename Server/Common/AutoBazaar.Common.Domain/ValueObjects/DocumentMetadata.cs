using AutoBazaar.Common.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.ValueObjects
{
    public sealed class DocumentMetadata : ValueObject
    {
        private DocumentMetadata() { } // EF

        public string BlobPath { get; private set; } = null!; // storage key
        public string Sha256Hash { get; private set; } = null!; // integrity
        public string MimeType { get; private set; } = null!;
        public long SizeBytes { get; private set; }
        public DateTime UploadedAtUtc { get; private set; }

        public DocumentMetadata(string blobPath, string sha256Hash, string mimeType, long sizeBytes, DateTime uploadedAtUtc)
        {
            if (string.IsNullOrWhiteSpace(blobPath)) throw new ArgumentException(nameof(blobPath));
            if (string.IsNullOrWhiteSpace(sha256Hash)) throw new ArgumentException(nameof(sha256Hash));
            BlobPath = blobPath;
            Sha256Hash = sha256Hash;
            MimeType = mimeType;
            SizeBytes = sizeBytes;
            if (uploadedAtUtc.Kind != DateTimeKind.Utc) throw new ArgumentException("Use UTC times");
            UploadedAtUtc = uploadedAtUtc;
        }

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return BlobPath;
            yield return Sha256Hash;
            yield return MimeType;
            yield return SizeBytes;
            yield return UploadedAtUtc;
        }
    }

}
