using System.Text;

namespace Students.COMMON
{
    public class Md5Builder
    {
        public string GetHashedValue(string val)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bytes = ASCIIEncoding.Default.GetBytes(val);
            byte[] encoded = md5.ComputeHash(bytes);
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < encoded.Length; i++)
                strBuilder.Append(encoded[i].ToString("x2"));
            return strBuilder.ToString();
        }
    }
}
