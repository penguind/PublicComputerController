using System;
using System.Collections.Generic;
using System.Text;

namespace IfMyComputer
{
    class Auth
    {
        private static string adminname = "admin";// administrator name, must be set
        private static string adminpass = "admin";// administrator password, must be set

        /// <summary>
        /// If user login as administrator.
        /// Unset adminname or adminpass is treated as illegal(return false);
        /// </summary>
        /// <param name="name">user input name</param>
        /// <param name="passwd">user input password</param>
        /// <returns>
        ///     true: log in successfully as administrator
        ///     false:log in failed as administrator
        /// </returns>
        public static bool isAdminLogin(string name, string passwd)
        {
            if (adminname == null || adminpass == null || adminname == "" || adminpass == "")
            {
                return false;
            }
            if(name.CompareTo(adminname) == 0 && passwd.CompareTo(adminpass) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Define which unique sequence will be the secret key.
        /// </summary>
        /// <returns>Secret key seq.</returns>
        public static string getSecretKey()
        {
            return SystemInfoUtil.getCpuID().Trim();
        }
    }
}
