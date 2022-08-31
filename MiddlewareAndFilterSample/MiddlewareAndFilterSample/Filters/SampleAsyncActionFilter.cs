using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace MiddlewareAndFilterSample.Filters
{
    public class SampleAsyncActionFilter : IAsyncActionFilter
    {
        private readonly ILogger<SampleAsyncActionFilter> _logger;

        public SampleAsyncActionFilter(ILogger<SampleAsyncActionFilter> logger)
        {
            _logger = logger;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            _logger.LogInformation("[AsyncFilter - BEFORE]");
            await next();
            _logger.LogInformation("[AsyncFilter - After]");
        }
    }
}
