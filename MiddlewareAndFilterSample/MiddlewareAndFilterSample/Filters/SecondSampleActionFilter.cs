using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace MiddlewareAndFilterSample.Filters
{
    public class SecondSampleActionFilter : ActionFilterAttribute
    {
        private readonly ILogger<SecondSampleActionFilter> _logger;

        public SecondSampleActionFilter(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<SecondSampleActionFilter>();
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //base.OnActionExecuting(context);
            _logger.LogInformation("[Sync SecondSampleActionFilter - BEFORE]");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            //base.OnActionExecuted(context);
            _logger.LogInformation("[Sync SecondSampleActionFilter - AFTER]");
        }
    }
}
