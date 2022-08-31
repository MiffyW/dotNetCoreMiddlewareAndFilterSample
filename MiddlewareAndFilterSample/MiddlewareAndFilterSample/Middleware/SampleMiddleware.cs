using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace MiddlewareAndFilterSample.Middleware
{
    public class SampleMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public SampleMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<SampleMiddleware>();
        }

        public async Task Invoke(HttpContext context)
        {
            _logger.LogInformation("[Middleware - BEFORE]");
            await _next.Invoke(context);
            _logger.LogInformation("[Middleware - AFTER]");
        }
    }

    public static class SampleMiddlewareExtensions
    {
        public static IApplicationBuilder UsaSampleMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SampleMiddleware>();
        }
    }
}
