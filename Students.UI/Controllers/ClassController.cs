using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Students.BLL.Interfaces;
using Students.DAL;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Students.UI.Controllers
{
    public class ClassController : Controller
    {
        private readonly IClass _class;
        private readonly ILoggerService _logger;

        public ClassController(IClass @class, ILoggerService logger)
        {
            _class = @class;
            _logger = logger;
        }


        public async Task AddLog(string message)
        {
            await _logger.AddLog(new Log
            {
                HOSTNAME = Request.GetDisplayUrl(),
                HOSTADDRESS = HttpContext.Connection.RemoteIpAddress.ToString(),
                MANAGERID = int.Parse(User.Claims.Where(c => c.Type == ClaimTypes.Sid).Select(s => s.Value).SingleOrDefault()),
                MESSAGE = message
            });
        }

        [Route("/class")]
        public async Task<IActionResult> Index()
        {
            var classes = _class.GetClasses();

            await AddLog("Sınıflar listelendi");

            return View(classes);
        }

        [HttpPost]
        [Route("delete-class/{id}")]
        public async Task<IActionResult> Delete()
        {
            if (!string.IsNullOrEmpty(RouteData.Values["id"].ToString()))
            {
                var id = int.Parse(RouteData.Values["id"].ToString());
                var @class = new DAL.Class
                {
                    CLASSID = id
                };
                await _class.DeleteClass(@class);

                await AddLog(id + " numaralı sınıf silindi.");
            }
            return RedirectToAction("Index");
        }

        [Route("/add-class")]
        public IActionResult Add()
        {
            if (!string.IsNullOrEmpty(Request.Query["success"]))
            {
                ViewData["alert"] = "swal('Sınıf Ekle', 'Sınıf eklendi.', 'success');";
            }
            return View();
        }

        [HttpPost]
        [Route("/add-class")]
        public async Task<IActionResult> Add(DAL.Class @class)
        {
            await _class.AddClass(@class);

            await AddLog(@class.NAME + " adlı sınıf eklendi.");

            return RedirectToAction("Add", new { success = true });
        }

        [Route("/edit-class/{id}")]
        public IActionResult Edit()
        {
            var data = new DAL.Class
            {
                CLASSID = int.Parse(RouteData.Values["id"].ToString())
            };

            var classItem = _class.GetClass(data);

            if (!string.IsNullOrEmpty(Request.Query["success"]))
            {
                ViewData["alert"] = "swal('Sınıf Düzenle', 'Sınıf düzenlendi.', 'success');";
            }

            return View(classItem);
        }

        [HttpPost]
        [Route("/edit-class/{id}")]
        public async Task<IActionResult> Edit(DAL.Class @class)
        {
            await _class.EditClass(@class);

            await AddLog(@class.NAME + " adlı sınıf güncellendi.");

            return RedirectToAction("Edit", new { id = @class.CLASSID, success = true });
        }
    }
}
