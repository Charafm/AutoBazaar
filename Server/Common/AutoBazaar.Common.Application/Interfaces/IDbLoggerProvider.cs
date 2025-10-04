using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Interfaces
{
    public interface IDbLoggerProvider : ILoggerProvider
    {
        IDbLogger CreateDbLogger(string categoryName);
    }
}
