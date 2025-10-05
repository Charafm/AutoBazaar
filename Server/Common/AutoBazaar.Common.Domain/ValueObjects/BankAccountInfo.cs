using AutoBazaar.Common.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Domain.ValueObjects
{
    public sealed class BankAccountInfo : ValueObject
    {
        private BankAccountInfo() { } // EF

        public string BankName { get; private set; } = null!;
        public string AccountNumberMasked { get; private set; } = null!; 
        public string? AccountHolderName { get; private set; }
        public string? Currency { get; private set; }

        public BankAccountInfo(string bankName, string accountNumberMasked, string? accountHolder = null, string? currency = null)
        {
            if (string.IsNullOrWhiteSpace(bankName) || string.IsNullOrWhiteSpace(accountNumberMasked)) throw new ArgumentException();
            BankName = bankName;
            AccountNumberMasked = accountNumberMasked;
            AccountHolderName = accountHolder;
            Currency = currency?.ToUpperInvariant();
        }

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return BankName;
            yield return AccountNumberMasked;
            yield return AccountHolderName;
            yield return Currency;
        }
    }

}
