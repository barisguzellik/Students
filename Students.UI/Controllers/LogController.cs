using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Students.BLL.Interfaces;

namespace Students.UI.Controllers
{
    [Authorize]
    public class LogController : Controller
    {
        private readonly ILoggerService _logger;
        public LogController(ILoggerService logger)
        {
            _logger = logger;
        }

        [Route("/log")]
        public IActionResult Index()
        {
            var data = _logger.GetLogs();
            return View(data);
        }
    }
}
