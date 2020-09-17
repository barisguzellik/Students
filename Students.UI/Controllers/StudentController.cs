using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Students.BLL.Interfaces;
using Students.DAL;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Students.UI.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudent _student;
        private readonly IClass _class;
        private readonly ILoggerService _logger;

        public StudentController(IStudent student, ILoggerService logger, IClass @class)
        {
            _student = student;
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

        [Route("/student")]
        public async Task<IActionResult> Index()
        {
            var classes = _student.GetStudents();

            await AddLog("Öğrenciler listelendi");

            return View(classes);
        }

        [HttpPost]
        [Route("delete-student/{id}")]
        public async Task<IActionResult> Delete()
        {
            if (!string.IsNullOrEmpty(RouteData.Values["id"].ToString()))
            {
                var id = int.Parse(RouteData.Values["id"].ToString());
                var student = new DAL.Student
                {
                    STUDENTID = id
                };
                await _student.DeleteStudent(student);

                await AddLog(id + " numaralı öğrenci silindi.");
            }
            return RedirectToAction("Index");
        }

        [Route("/add-student")]
        public IActionResult Add()
        {
            if (!string.IsNullOrEmpty(Request.Query["success"]))
            {
                ViewData["alert"] = "swal('Öğrenci Ekle', 'Öğrenci eklendi.', 'success');";
            }
            ViewData["Classes"] = _class.GetClasses();
            return View();
        }

        [HttpPost]
        [Route("/add-student")]
        public async Task<IActionResult> Add(DAL.Student student)
        {
            await _student.AddStudent(student);

            await AddLog(student.FIRSTNAME + " adlı öğrenci eklendi.");

            return RedirectToAction("Add", new { success = true });
        }

        [Route("/edit-student/{id}")]
        public IActionResult Edit()
        {
            var data = new DAL.Student
            {
                STUDENTID = int.Parse(RouteData.Values["id"].ToString())
            };

            var studentItem = _student.GetStudent(data);

            if (!string.IsNullOrEmpty(Request.Query["success"]))
            {
                ViewData["alert"] = "swal('Öğrenci Düzenle', 'Öğrenci düzenlendi.', 'success');";
            }

            ViewData["Classes"] = _class.GetClasses();
            return View(studentItem);
        }

        [HttpPost]
        [Route("/edit-student/{id}")]
        public async Task<IActionResult> Edit(DAL.Student student)
        {
            await _student.EditStudent(student);

            await AddLog(student.FIRSTNAME + " adlı öğrenci güncellendi.");

            return RedirectToAction("Edit", new { id = student.STUDENTID, success = true });
        }
    }
}
