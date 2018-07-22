using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using SQLMTD.Data.Info;
using SQLMTD.Data.DB;

namespace SQLMTD.Logic.Login
{
    public static class LoginManager
    {
        public static bool Login(string username, string password)
        {
            password = GetHash(password);
            UserInfo user = DatabaseManager.UserSelectByUsernameAndPassword(username, password);

            if (user != null)
            {
                return true;
            }

            return false;
        }

        public static string GetHash(string input)
        {
            byte[] result;
            byte[] imputBytes = Encoding.UTF8.GetBytes(input);

            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            result = sha1.ComputeHash(imputBytes);

            return Convert.ToBase64String(result);
        }
    }
}
