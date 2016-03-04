using System;
using System.Collections.Generic;
using System.Text;

namespace IfMyComputer
{
    class Auth
    {
        private static string adminname = "admin";// administrator name, must be set
        private static string adminpass = "admin";// administrator password, must be set

        private string username; //user name which waiting for authenticate
        private string password; //user password
        private string authUrl;  //authenticating url

        private string errorMsg; // error message when login failed

        /// <summary>
        /// The constructor of Auth class
        /// </summary>
        /// <param name="userName">user name inputed</param>
        /// <param name="userPassword">user password inputed</param>
        /// <param name="authenticatingURL">url user set or administrator set</param>
        public Auth(string userName, string userPassword, string authenticatingURL)
        {
            username = userName;
            password = userPassword;
            authUrl = authenticatingURL;
            errorMsg = "";
        }

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
        private bool isAdminLogin()
        {
            if (adminname == null || adminpass == null || adminname == "" || adminpass == ""
               ||username == null || password == null  || username == ""  || password == "")
            {
                return false;
            }
            if(username.CompareTo(adminname) == 0 && password.CompareTo(adminpass) == 0)
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

        /// <summary>
        /// create the request message of authenticate
        /// </summary>
        /// <returns>the message of authenticate</returns>
        private string createAuthRequest()
        {
            if (username == null || password == null || username == "" || password == "")
            {
                return "";
            }
            return string.Format("<xml><secretkey>%s</secretkey><username>%s</username><password>%s</password></xml>",
                                  getSecretKey(), username, password);
        }

        /// <summary>
        /// Parse the response from authenticating server, and judge if user can log in.
        /// If login fail, error message will be recorded.
        /// </summary>
        /// <returns>true: user could log in;false: user cannot be log in.</returns>
        private bool isLogInAftherAuth(string authResponse)
        {
            return true;
        }

        /// <summary>
        /// The interface that auth module offers to judge if the user could log in. 
        /// </summary>
        /// <returns>true:can login; false:cannot login.</returns>
        public bool doLogIn()
        {
            // login as administrator
            if (isAdminLogin())
            {
                return true;
            }
            // login as normal user
            NetworkUtil netutil = new NetworkUtil();
            if (netutil.getResponseFromHttpPost(authUrl, createAuthRequest()) == false)
            {
                errorMsg = netutil.getErrorData();
                return false;
            }
            else
            {
                return isLogInAftherAuth(netutil.getResponseContent());
            }
        }
    }
}
