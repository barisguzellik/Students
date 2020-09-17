using Dapper;
using Students.BLL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.BLL.LessonService
{
    public class Lesson : ILesson
    {
        private readonly IConnection _connection;
        public Lesson(IConnection connection)
        {
            _connection = connection;
        }

        public async Task Execute(string query, object param)
        {
            await _connection.GetConnection().ExecuteAsync(query, param);
        }
        public async Task AddLesson(DAL.Lesson lesson)
        {
            var query = "INSERT INTO LESSON(CLASSID,CODE,NAME,SORT,STATUS) VALUES(@CLASSID,@CODE,@NAME,@SORT,@STATUS)";
            var parameters = new
            {
                CLASSID = lesson.CLASSID,
                CODE = lesson.CODE,
                NAME = lesson.NAME,
                SORT = lesson.SORT,
                STATUS = lesson.STATUS
            };
            await Execute(query, parameters);
        }

        public async Task DeleteLesson(DAL.Lesson lesson)
        {
            var query = "DELETE FROM LESSON WHERE LESSONID=@LESSONID";
            var parameters = new
            {
                LESSONID = lesson.LESSONID
            };
            await Execute(query, parameters);
        }

        public async Task EditLesson(DAL.Lesson lesson)
        {
            var query = "UPDATE LESSON SET CLASSID=@CLASSID,CODE=@CODE,NAME=@NAME,SORT=@SORT,STATUS=@STATUS WHERE LESSONID=@LESSONID";
            var parameters = new
            {
                CLASSID = lesson.CLASSID,
                CODE = lesson.CODE,
                NAME = lesson.NAME,
                SORT = lesson.SORT,
                STATUS = lesson.STATUS,
                LESSONID = lesson.LESSONID
            };
            await Execute(query, parameters);
        }

        public DAL.Lesson GetLesson(DAL.Lesson lesson)
        {
            var query = "SELECT TOP 1 * FROM LESSON WHERE LESSONID=@LESSONID";
            var parameters = new
            {
                LESSONID = lesson.LESSONID
            };
            return _connection.GetConnection().Query<DAL.Lesson>(query, parameters).SingleOrDefault();
        }

        public List<dynamic> GetLessons()
        {
            var query = "SELECT LESSONID,LESSON.CODE,LESSON.NAME,LESSON.SORT,LESSON.STATUS,CLASS.NAME AS CLASSNAME FROM LESSON INNER JOIN CLASS ON LESSON.CLASSID=CLASS.CLASSID";
            var parameters = new
            {

            };
            return _connection.GetConnection().Query<dynamic>(query, parameters).ToList();
        }
    }
}
