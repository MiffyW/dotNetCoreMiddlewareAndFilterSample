using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MiddlewareAndFilterSample.Filters;
using MiddlewareAndFilterSample.Models;
using System.Diagnostics;

namespace MiddlewareAndFilterSample.Controllers
{
    [ServiceFilter(typeof(SampleActionFilter))]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [ServiceFilter(typeof(SampleAsyncActionFilter))]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
