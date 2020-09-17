using Students.DAL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Students.BLL.Interfaces
{
    public interface ILesson
    {
        Lesson GetLesson(Lesson lesson);
        List<dynamic> GetLessons();
        Task AddLesson(Lesson lesson);
        Task EditLesson(Lesson lesson);
        Task DeleteLesson(Lesson lesson);
    }
}
