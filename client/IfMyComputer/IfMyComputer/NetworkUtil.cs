using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;

namespace IfMyComputer
{
    class NetworkUtil
    {
        private string responseContent;
        private string errorData;

        NetworkUtil()
        {
            responseContent = "";
            errorData = "";
        }

        /// <summary>
        /// Get response from website via GET 
        /// </summary>
        /// <param name="url">URL</param>
        /// <returns>
        ///   true: get response successfully
        ///   false:get response failed, error data is catched in "erorData". 
        /// </returns>
        public bool getResponseFromHttpGet(string url)
        {
            Stream stream = null;
            try
            {
                WebClient client = new WebClient();
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                stream = client.OpenRead(url);
                if (stream == null)
                {
                    errorData = "stream is null!!!";
                    return false;
                }
                StreamReader sr = new StreamReader(stream);
                responseContent = sr.ReadToEnd();
                return true;
            }
            catch (Exception e)
            {
                errorData = e.Data.ToString();
                return false;
            }
        }

        /// <summary>
        /// Get response from website via POST
        /// </summary>
        /// <param name="url">URL</param>
        /// <returns>
        ///   true: get response successfully
        ///   false:get response failed, error data is catched in "erorData". 
        /// </returns>
        public bool getResponseFromHttpPost(string url, string postMsg)
        {
            try
            {
                WebClient client = new WebClient();
                byte[] bytes = Encoding.UTF8.GetBytes(postMsg);
                client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                client.Headers.Add("ContentLength", postMsg.Length.ToString());
                byte[] responseData = client.UploadData("https://api.weibo.com/oauth2/access_token", "POST", bytes);
                responseContent = Encoding.Default.GetString(responseData);
                return true;
            }
            catch (Exception e)
            {
                errorData = e.Data.ToString();
                return false;
            }
        }
    }
}
