using System.Data.SqlClient;

namespace Students.BLL.Interfaces
{
    public interface IConnection
    {
        SqlConnection GetConnection();
    }
}
