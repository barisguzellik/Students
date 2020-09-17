using Dapper;
using Students.BLL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.BLL.ClassService
{
    public class Class : IClass
    {
        private readonly IConnection _connection;
        public Class(IConnection connection)
        {
            _connection = connection;
        }

        public async Task Execute(string query,object param)
        {
            await _connection.GetConnection().ExecuteAsync(query, param);
        }

        public async Task AddClass(DAL.Class @class)
        {
            var query = "INSERT INTO CLASS(CODE,NAME,SORT,STATUS) VALUES(@CODE,@NAME,@SORT,@STATUS)";
            var parameters = new
            {
                CODE = @class.CODE,
                NAME = @class.NAME,
                SORT = @class.SORT,
                STATUS = @class.STATUS
            };
            await Execute(query, parameters);
        }

        public async Task DeleteClass(DAL.Class @class)
        {
            var query = "DELETE FROM CLASS WHERE CLASSID=@CLASSID";
            var parameters = new
            {
                CLASSID = @class.CLASSID
            };
            await Execute(query, parameters);
        }

        public async Task EditClass(DAL.Class @class)
        {
            var query = "UPDATE CLASS SET CODE=@CODE,NAME=@NAME,SORT=@SORT,STATUS=@STATUS WHERE CLASSID=@CLASSID";
            var parameters = new
            {
                CODE = @class.CODE,
                NAME = @class.NAME,
                SORT = @class.SORT,
                STATUS = @class.STATUS,
                CLASSID = @class.CLASSID
            };
            await Execute(query, parameters);
        }

        public DAL.Class GetClass(DAL.Class @class)
        {
            var query = "SELECT TOP 1 * FROM CLASS WHERE CLASSID=@CLASSID";
            var parameters = new
            {
                CLASSID = @class.CLASSID
            };
            return _connection.GetConnection().Query<DAL.Class>(query, parameters).SingleOrDefault();
        }

        public List<dynamic> GetClasses()
        {
            var query = "SELECT * FROM CLASS";
            var parameters = new
            {

            };
            return _connection.GetConnection().Query<dynamic>(query, parameters).ToList();
        }
    }
}
