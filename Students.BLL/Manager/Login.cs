using Dapper;
using Students.BLL.Interfaces;
using Students.COMMON;
using Students.DAL;
using System.Linq;

namespace Students.BLL.ManagerLogin
{
    public class Login : ILogin
    {
        Md5Builder md5Builder = new Md5Builder();

        private readonly IConnection _connection;
        public Login(IConnection connection)
        {
            _connection = connection;
        }

        public Manager Get(string username, string password)
        {
            var query = "SELECT TOP 1 * FROM MANAGER WHERE USERNAME=@USERNAME AND PASSWORD=@PASSWORD AND STATUS=1";
            var parameters = new
            {
                USERNAME = username,
                PASSWORD = md5Builder.GetHashedValue(password)
            };
            Manager result = _connection.GetConnection().Query<Manager>(query, parameters).FirstOrDefault();
            return result;
        }
    }
}
