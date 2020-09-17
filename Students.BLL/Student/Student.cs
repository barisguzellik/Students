using Dapper;
using Students.BLL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.BLL.StudentService
{
    public class Student : IStudent
    {
        private readonly IConnection _connection;
        public Student(IConnection connection)
        {
            _connection = connection;
        }

        public async Task Execute(string query, object param)
        {
            await _connection.GetConnection().ExecuteAsync(query, param);
        }
        public async Task AddStudent(DAL.Student student)
        {
            var query = "INSERT INTO STUDENT(CLASSID,IDENTITYNUMBER,FIRSTNAME,LASTNAME,NUMBER,STATUS) VALUES(@CLASSID,@IDENTITYNUMBER,@FIRSTNAME,@LASTNAME,@NUMBER,@STATUS)";
            var parameters = new
            {
                CLASSID = student.CLASSID,
                IDENTITYNUMBER = student.IDENTITYNUMBER,
                FIRSTNAME = student.FIRSTNAME,
                LASTNAME = student.LASTNAME,
                NUMBER = student.NUMBER,
                STATUS = student.STATUS
            };
            await Execute(query, parameters);
        }

        public async Task DeleteStudent(DAL.Student student)
        {
            var query = "DELETE FROM STUDENT WHERE STUDENTID=@LESSTUDENTIDSONID";
            var parameters = new
            {
                STUDENTID = student.STUDENTID
            };
            await Execute(query, parameters);
        }

        public async Task EditStudent(DAL.Student student)
        {
            var query = "UPDATE STUDENT SET CLASSID=@CLASSID,IDENTITYNUMBER=@IDENTITYNUMBER,FIRSTNAME=@FIRSTNAME,LASTNAME=@LASTNAME,NUMBER=@NUMBER,STATUS=@STATUS WHERE STUDENTID=@STUDENTID";
            var parameters = new
            {
                CLASSID = student.CLASSID,
                IDENTITYNUMBER = student.IDENTITYNUMBER,
                FIRSTNAME = student.FIRSTNAME,
                LASTNAME = student.LASTNAME,
                STATUS = student.STATUS,
                NUMBER = student.NUMBER,
                STUDENTID = student.STUDENTID
            };
            await Execute(query, parameters);
        }

        public DAL.Student GetStudent(DAL.Student student)
        {
            var query = "SELECT TOP 1 * FROM STUDENT WHERE STUDENTID=@STUDENTID";
            var parameters = new
            {
                STUDENTID = student.STUDENTID
            };
            return _connection.GetConnection().Query<DAL.Student>(query, parameters).SingleOrDefault();
        }

        public List<dynamic> GetStudents()
        {
            var query = "SELECT STUDENTID,IDENTITYNUMBER,FIRSTNAME,LASTNAME,NUMBER,STUDENT.STATUS,NAME AS CLASSNAME FROM STUDENT INNER JOIN CLASS ON STUDENT.CLASSID=CLASS.CLASSID";
            var parameters = new
            {

            };
            return _connection.GetConnection().Query<dynamic>(query, parameters).ToList();
        }
    }
}
