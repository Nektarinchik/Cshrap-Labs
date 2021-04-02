using System;
using System.Management;

namespace computer_information_WMI_
{
    static class GetInfo
    {
        static public void GetCPUInfo()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            foreach(ManagementObject m in mos.Get())
            {
                Console.WriteLine("------------- Win32_Processor instance ---------------");
                Console.WriteLine("Name: {0}", m["Name"]);
                Console.WriteLine("NumberOfCores: {0}", m["NumberOfCores"]);
                Console.WriteLine("ProcessorId: {0}", m["ProcessorId"]);
            }
            mos.Dispose();
        }
        static public void GetRAMInfo()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");
            foreach (ManagementObject m in mos.Get())
            {
                Console.WriteLine("------------- Win32_PhysicalMemory instance ---------------");
                Console.WriteLine("BankLabel: {0}", m["BankLabel"]);
                Console.WriteLine("Capacity: {0} Gb", Math.Round(System.Convert.ToDouble(m["Capacity"]) / 1024 / 1024 / 1024, 2));
                Console.WriteLine("Speed: {0}", m["Speed"]);
            }
            mos.Dispose();
        }

        static public void GetGraphicsCardInfo()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
            foreach(ManagementObject m in mos.Get())
            {
                Console.WriteLine("----------- Win32_VideoController instance -----------");
                Console.WriteLine("AdapterRAM: {0}", m["AdapterRAM"]);
                Console.WriteLine("Caption: {0}", m["Caption"]);
                Console.WriteLine("Description: {0}", m["Description"]);
                Console.WriteLine("VideoProcessor: {0}", m["VideoProcessor"]);
            }
            mos.Dispose();
        }
    }
}
