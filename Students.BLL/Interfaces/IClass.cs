using Students.DAL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Students.BLL.Interfaces
{
    public interface IClass
    {
        Class GetClass(Class @class);
        List<dynamic> GetClasses();
        Task AddClass(Class @class);
        Task EditClass(Class @class);
        Task DeleteClass(Class @class);
    }
}
