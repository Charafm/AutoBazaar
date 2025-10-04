using AutoBazaar.Common.Domain.DataTransferObjects;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Interfaces
{
    public interface IDbLogger : ILogger
    {
        void LogToDatabase(LogRequestDto logInfo);
    }
}
