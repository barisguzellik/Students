using Students.DAL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Students.BLL.Interfaces
{
    public interface IStudent
    {
        Student GetStudent(Student student);
        List<dynamic> GetStudents();
        Task AddStudent(Student student);
        Task EditStudent(Student student);
        Task DeleteStudent(Student student);
    }
}
