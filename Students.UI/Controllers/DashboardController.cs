using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Students.BLL.Interfaces;
using Students.DAL;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Students.UI.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly IDashboard _dashboard;
        private readonly ILoggerService _logger;

        public DashboardController(IDashboard dashboard, ILoggerService logger)
        {
            _dashboard = dashboard;
            _logger = logger;
        }

        [Route("/dashboard")]
        public async Task<IActionResult> Index()
        {
            await _logger.AddLog(new Log
            {
                HOSTNAME = Request.GetDisplayUrl(),
                HOSTADDRESS = HttpContext.Connection.RemoteIpAddress.ToString(),
                MANAGERID = int.Parse(User.Claims.Where(c => c.Type == ClaimTypes.Sid).Select(s => s.Value).SingleOrDefault()),
                MESSAGE = "Gösterge listelendi."
            });

            ViewData["StudentCount"] = _dashboard.GetStudentCount();
            ViewData["LessonCount"] = _dashboard.GetLessonCount();
            ViewData["ClassCount"] = _dashboard.GetClassCount();
            return View();
        }
    }
}
