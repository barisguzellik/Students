using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Students.BLL.Interfaces;
using Students.DAL;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Students.UI.Controllers
{
    public class LessonController : Controller
    {
        private readonly ILesson _lesson;
        private readonly IClass _class;
        private readonly ILoggerService _logger;

        public LessonController(ILesson lesson, ILoggerService logger, IClass @class)
        {
            _lesson = lesson;
            _logger = logger;
            _class = @class;
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

        [Route("/lesson")]
        public async Task<IActionResult> Index()
        {
            var classes = _lesson.GetLessons();

            await AddLog("Dersler listelendi");

            return View(classes);
        }

        [HttpPost]
        [Route("delete-lesson/{id}")]
        public async Task<IActionResult> Delete()
        {
            if (!string.IsNullOrEmpty(RouteData.Values["id"].ToString()))
            {
                var id = int.Parse(RouteData.Values["id"].ToString());
                var lesson = new DAL.Lesson
                {
                    LESSONID = id
                };
                await _lesson.DeleteLesson(lesson);

                await AddLog(id + " numaralı ders silindi.");
            }
            return RedirectToAction("Index");
        }

        [Route("/add-lesson")]
        public IActionResult Add()
        {
            if (!string.IsNullOrEmpty(Request.Query["success"]))
            {
                ViewData["alert"] = "swal('Ders Ekle', 'Ders eklendi.', 'success');";
            }
            ViewData["Classes"] = _class.GetClasses();
            return View();
        }

        [HttpPost]
        [Route("/add-lesson")]
        public async Task<IActionResult> Add(DAL.Lesson lesson)
        {
            await _lesson.AddLesson(lesson);

            await AddLog(lesson.NAME + " adlı ders eklendi.");

            return RedirectToAction("Add", new { success = true });
        }

        [Route("/edit-lesson/{id}")]
        public IActionResult Edit()
        {
            var data = new DAL.Lesson
            {
                LESSONID = int.Parse(RouteData.Values["id"].ToString())
            };

            var lessonItem = _lesson.GetLesson(data);

            if (!string.IsNullOrEmpty(Request.Query["success"]))
            {
                ViewData["alert"] = "swal('Ders Düzenle', 'Ders düzenlendi.', 'success');";
            }

            ViewData["Classes"] = _class.GetClasses();
            return View(lessonItem);
        }

        [HttpPost]
        [Route("/edit-lesson/{id}")]
        public async Task<IActionResult> Edit(DAL.Lesson lesson)
        {
            await _lesson.EditLesson(lesson);

            await AddLog(lesson.NAME + " adlı ders güncellendi.");

            return RedirectToAction("Edit", new { id = lesson.LESSONID, success = true });
        }
    }
}
