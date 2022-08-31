using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace MiddlewareAndFilterSample.Filters
{
    public class SampleActionFilter : ActionFilterAttribute
    {
        private readonly ILogger<SampleActionFilter> _logger;

        public SampleActionFilter(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<SampleActionFilter>();
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //base.OnActionExecuting(context);
            _logger.LogInformation("[SyncFilter - BEFORE]");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            //base.OnActionExecuted(context);
            _logger.LogInformation("[SyncFilter - AFTER]");
        }
    }
}
