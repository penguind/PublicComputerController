using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using System.Net;

namespace IfMyComputer
{
    class SystemInfoUtil
    {
        /// <summary>
        /// Get the unique ID of the CPU.
        /// </summary>
        /// <returns>the unique ID of the CPU, if get many, seperate with ';'.If error occurred, return "unknown"</returns>
        public static string getCpuID()
        {
            string cpuInfo = "";
            try
            {
                ManagementClass mc = new ManagementClass("Win32_Processor");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    cpuInfo += mo.Properties["ProcessorId"].Value.ToString() + ";";
                }
                moc = null;
                mc = null;
                return cpuInfo;
            }
            catch
            {
                return "unknown";
            }
        }
        
        /// <summary>
        /// Get ip list of PC
        /// </summary>
        /// <returns>List of IP, seperated by ';'</returns>
        public string GetAddressIP()
        {
            string AddressIP = "";
            foreach (IPAddress _IPAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (_IPAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    AddressIP += _IPAddress.ToString() + ";";
                }
            }
            return AddressIP;
        }
    }
}
