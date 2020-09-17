using Students.BLL.Interfaces;
using System.Data.SqlClient;

namespace Students.BLL.ConnectionClass
{
    public class Connection : IConnection
    {
        public SqlConnection GetConnection()
        {
            return new SqlConnection("Server=46.45.169.190;Database=Students;User Id=Students;Password=6c2*0lBr;");
        }
    }
}
