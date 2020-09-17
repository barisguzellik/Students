using Dapper;
using Students.BLL.Interfaces;
using Students.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.BLL.LoggerService
{
    public class Logger : ILoggerService
    {
        private readonly IConnection _connection;
        public Logger(IConnection connection)
        {
            _connection = connection;
        }
        public async Task AddLog(Log log)
        {
            var query = "INSERT INTO LOG(MANAGERID,DATETIME,HOSTNAME,HOSTADDRESS,MESSAGE) VALUES(@MANAGERID,@DATETIME,@HOSTNAME,@HOSTADDRESS,@MESSAGE)";
            var parameters = new
            {
                MANAGERID = log.MANAGERID,
                DATETIME = DateTime.Now,
                HOSTNAME = log.HOSTNAME,
                HOSTADDRESS = log.HOSTADDRESS,
                MESSAGE = log.MESSAGE
            };
            await _connection.GetConnection().ExecuteAsync(query, parameters);
        }

        public List<dynamic> GetLogs()
        {
            var query = "SELECT DATETIME,HOSTADDRESS,HOSTNAME,MESSAGE,USERNAME FROM LOG INNER JOIN MANAGER ON MANAGER.MANAGERID=LOG.MANAGERID ORDER BY DATETIME DESC";
            var parameters = new
            {

            };
            return _connection.GetConnection().Query<dynamic>(query, parameters).ToList();
        }
    }
}
