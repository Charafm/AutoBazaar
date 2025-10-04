using Microsoft.EntityFrameworkCore;

namespace AutoBazaar.Common.Application.Interfaces
{
    public interface IContextFactory
    {
        Type ResolveContextType(string clientId);
        DbContext CreateContext(string clientId);
    }
}
