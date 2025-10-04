using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Web.Middleware
{
    public class CorrelationIdMiddleware
    {
        private readonly RequestDelegate _next;
        private const string HeaderKey = "X-Correlation-Id";


        public CorrelationIdMiddleware(RequestDelegate next) => _next = next;


        public async Task InvokeAsync(HttpContext httpContext)
        {
            if (!httpContext.Request.Headers.TryGetValue(HeaderKey, out var correlationId) || string.IsNullOrWhiteSpace(correlationId))
            {
                correlationId = Guid.NewGuid().ToString();
            }


            httpContext.Items["CorrelationId"] = correlationId.ToString();
            httpContext.Response.OnStarting(() => {
                if (!httpContext.Response.Headers.ContainsKey(HeaderKey))
                    httpContext.Response.Headers.Add(HeaderKey, correlationId.ToString());
                return Task.CompletedTask;
            });


            await _next(httpContext);
        }
    }
}
