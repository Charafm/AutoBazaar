using AutoBazaar.Common.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.ValueObjects
{
    public sealed class ContactInfo : ValueObject
    {
        private ContactInfo() { } // EF

        public string? Email { get; private set; }
        public string? PhoneNumber { get; private set; } // normalized e.g. E.164
        public string? PreferredChannel { get; private set; } // "email"|"sms"|...

        public ContactInfo(string? email = null, string? phoneNumber = null, string? preferredChannel = null)
        {
            if (email != null) Email = email.Trim().ToLowerInvariant();
            if (phoneNumber != null) PhoneNumber = NormalizePhone(phoneNumber);
            PreferredChannel = preferredChannel?.ToLowerInvariant();
        }

        private static string NormalizePhone(string phone)
        {
            // minimal normalization: remove spaces, dashes. Use lib in prod.
            return new string(phone.Where(char.IsDigit).ToArray());
        }

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return Email;
            yield return PhoneNumber;
            yield return PreferredChannel;
        }
    }

}
