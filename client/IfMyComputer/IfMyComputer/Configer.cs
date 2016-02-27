using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace IfMyComputer
{
    class Configer
    {
        public string serverIP;
        public int serverPort;
        public string prefixOfMonitoredIP;
        public string secretKey;

        private string errorMsg;

        public Configer()
        {
            serverIP = "127.0.0.1";
            serverPort = 9527;
            prefixOfMonitoredIP = "127.";
            secretKey = "";

            errorMsg = "";
        }

        /// <summary>
        /// Read configuration from "config.ini", which user defined.
        /// </summary>
        /// <returns>If error occurred, will return false and errorMsg will be recorded.Normal true.</returns>
        public bool loadConfig()
        {
            try
            {
                using (FileStream ifs = new FileStream("config.ini", FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(ifs))
                    {
                        string line = "";
                        string temp = "";
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line.StartsWith("serverip="))
                            {
                                temp = line.Split('=')[1];
                                serverIP = NetworkUtil.validateIP(temp) ? temp : "127.0.0.1"; //bad ip is regarded as normal ip;
                            }
                            if (line.StartsWith("serverport="))
                            {
                                if (int.TryParse(line.Split('=')[1], out serverPort) == false)
                                {
                                    serverPort = 9527; //bad port is regarded as normal port
                                }
                            }
                        }
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                errorMsg = e.Message;
                return false;
            }
        }

        /// <summary>
        /// Write "config.ini", user difined configuration will be saved.
        /// </summary>
        /// <returns>If error occurred, will return false and errorMsg will be recorded.Normal true.</returns>
        public bool writeConfig()
        {
            try
            {
                using (FileStream ofs = new FileStream("config.ini", FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(ofs))
                    {
                        sw.WriteLine("serverip=" + serverIP);
                        sw.WriteLine("serverport" + serverPort);
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                errorMsg = e.Message;
                return false;
            }
        }

        /// <summary>
        /// Read configuration from "preconfig.ini", which administrator defined or software auto recorded.
        /// </summary>
        /// <returns>If error occurred, will return false and errorMsg will be recorded.Normal true.</returns>
        public bool loadPreConfig()
        {
            try
            {
                using (FileStream ifs = new FileStream("preconfig.ini", FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(ifs))
                    {
                        string line = "";
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line.StartsWith("secretkey="))
                            {
                                secretKey = line.Split('=')[1];
                            }
                            if (line.StartsWith("prefixOfIP="))
                            {
                                prefixOfMonitoredIP = line.Split('=')[1];
                            }
                        }
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                errorMsg = e.Message;
                return false;
            }
        }

        /// <summary>
        /// Write "preconfig.ini", administrator difined configuration will be saved, the software auto recorded will be refreshed to current statues.
        /// </summary>
        /// <returns>If error occurred, will return false and errorMsg will be recorded.Normal true.</returns>
        public bool writePreConfig()
        {
            try
            {
                using (FileStream ofs = new FileStream("preconfig.ini", FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(ofs))
                    {
                        sw.WriteLine("prefixOfIP=" + prefixOfMonitoredIP.Trim());
                        sw.WriteLine("secretkey=" + Auth.getSecretKey());
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                errorMsg = e.Message;
                return false;
            }
        }
    }
}
