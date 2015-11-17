using System.Security.Cryptography;
using System.Text;

namespace Task_Manager_Classes
{
    public class CommonData
    {
        public static string dataBasePath = "tmdb.db";
        public static string serverUriB = "net.tcp://";
        public static string serverUriE = ":8080/TaskManager";

        public static string salt = "f10551c61d8f9d";
        private static string md5(string input)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
        public static string hash_with_salt(string sourse)
        {
            return salt + md5(salt + sourse);
        }
        
    }
}