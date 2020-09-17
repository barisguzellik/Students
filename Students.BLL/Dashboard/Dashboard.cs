using Dapper;
using Students.BLL.Interfaces;
namespace Students.BLL.DashboardService
{
    public class Dashboard : IDashboard
    {
        private readonly IConnection _connection;
        public Dashboard(IConnection connection)
        {
            _connection = connection;
        }

        public int GetClassCount()
        {
            return _connection.GetConnection().ExecuteScalar<int>("SELECT COUNT(CLASSID) FROM CLASS");
        }

        public int GetLessonCount()
        {
            return _connection.GetConnection().ExecuteScalar<int>("SELECT COUNT(LESSONID) FROM LESSON");
        }

        public int GetStudentCount()
        {
            return _connection.GetConnection().ExecuteScalar<int>("SELECT COUNT(STUDENTID) FROM STUDENT");
        }
    }
}
