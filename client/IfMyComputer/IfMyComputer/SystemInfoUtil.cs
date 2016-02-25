using System;
using System.Collections.Generic;
using System.Text;
using System.Management;

namespace IfMyComputer
{
    class SystemInfoUtil
    {
        /// <summary>
        /// Get the unique ID of the CPU.
        /// </summary>
        /// <returns>the unique ID of the CPU, if get many, seperate with ';'</returns>
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
    }
}
