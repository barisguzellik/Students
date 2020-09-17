using Students.DAL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Students.BLL.Interfaces
{
    public interface ILoggerService
    {
        Task AddLog(Log log);
        List<dynamic> GetLogs();
    }
}
