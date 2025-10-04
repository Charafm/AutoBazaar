using AutoBazaar.Common.Domain.Localization;

namespace AutoBazaar.Common.Application.Exceptions
{
    public class BusinessValidationException : Exception
    {
        public BusinessValidationException()
          : base(Messages.InvalideBusinessRule)
        {
        }

        public BusinessValidationException(string message)
            : base(message)
        {
        }
    }
}
