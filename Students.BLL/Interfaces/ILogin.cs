using Students.DAL;

namespace Students.BLL.Interfaces
{
    public interface ILogin
    {
        Manager Get(string username, string password);
    }
}
