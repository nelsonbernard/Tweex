using Microsoft.Win32;
using System;
using System.Management;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tweex
{
    class MachineInfo
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern int GetSystemMetrics(int nIndex);

        private static int SM_MAXIMUMTOUCHES = 95;
        protected string stringMake = "";
        private string stringModel = "";
        private string stringCPU = "";
        private string stringVideo = "";
        private string stringOSVersion = "";
        private long lRAM = 0;
        private long lHDD = 0;
        private bool WebcamPresent = false;
        private bool TouchScreenPresent = false;
        private int suggestedPrice;

        public MachineInfo()
        {
            stringMake = getMake();
            stringModel = getModel();
            stringCPU = getCPU();
            stringVideo = getVideo();
            lRAM = getRAM();
            lHDD = getHDD();
            stringOSVersion = getOSVersion();
            TouchScreenPresent = getTouchScreen();
            //WebcamPresent = getCamera();
            suggestedPrice = 0;   //getPrice();
        }

        public string Make
        {
            get { return stringMake; }
        }

        public string Model
        {
            get { return stringModel; }
        }

        public string HDD
        {
            get { return this.FormatHDDBytes(lHDD); }
        }

        public string RAM
        {
            get { return this.FormatRAMBytes(lRAM); }
        }

        public string CPU
        {
            get { return stringCPU; }
        }

        public bool Webcam
        {
            get { return WebcamPresent; }
        }

        public bool TouchScreen
        {
            get { return TouchScreenPresent; }
        }

        public int Price
        {
            get { return suggestedPrice; }
        }

        public string Video
        {
            get { return stringVideo; }
        }

        public string OSVersion
        {
            get { return stringOSVersion; }
        }

        private bool getCamera()
        {
            //FilterInfoCollection videoDevices;
         

            bool DeviceExist = true;

            /*videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
                DeviceExist = false;*/   //throw new ApplicationException();           

            return DeviceExist;
        }

        private string FormatHDDBytes(long bits)
        {
            string[] suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblBits = bits;
            for (i = 0; i < suffix.Length && bits >= 1000; i++, bits /= 1000)
            {
                dblBits = bits / 1000.0;
            }

            if (suffix[i] != "TB")
                return String.Format("{0:0} {1}", dblBits, suffix[i]);
            else
                return String.Format("{0:0.##} {1}", dblBits, suffix[i]);
        }

        private string FormatRAMBytes(long bits)
        {
            string[] suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblBits = bits;
            for (i = 0; i < suffix.Length && bits >= 1024; i++, bits /= 1024)
            {
                dblBits = bits / 1024.0;
            }

            return String.Format("{0:0.#} {1}", dblBits, suffix[i]);
        }

        private string getCPU()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher(/*"root\\CIMV2", */"SELECT * FROM Win32_Processor");
            string cpuName = null;

            foreach (ManagementObject mo in mos.Get())
            {
                if (mo["name"] != null)
                {
                    string cpuErrorName = mo["name"].ToString();
                    cpuErrorName = cpuErrorName.Replace("(R)", "");
                    cpuErrorName = cpuErrorName.Replace("(TM)", "");
                    cpuErrorName = cpuErrorName.Replace("  ", "");
                    cpuErrorName = cpuErrorName.Replace("@ ", " @ ");
                    cpuErrorName = cpuErrorName.Replace("  @ ", " @ ");
                    cpuErrorName = cpuErrorName.Replace("(tm)", "");
                    cpuErrorName = cpuErrorName.Replace("(r)", "");
                    cpuErrorName = cpuErrorName.Replace("CPU ", "");
                    cpuErrorName = cpuErrorName.Replace(" CPU", "");
                    cpuErrorName = cpuErrorName.Replace(" CPU ", " ");

                    if (cpuErrorName.Contains("with"))
                        cpuErrorName.TrimEnd("with");
                    cpuName = cpuErrorName;
                }
            }

            return cpuName;
        }

        private string getMake()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT Manufacturer FROM Win32_ComputerSystem");

            string stringMake = null;

            foreach (ManagementObject mo in mos.Get())
            {
                if (mo["Manufacturer"] != null)
                {
                    stringMake = mo["Manufacturer"].ToString();
                }
                else
                    stringMake = "Dick's Pawn";
            }

            return stringMake;
        }

        private string getModel()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT Model FROM Win32_ComputerSystem");

            string modelName = null;

            foreach (ManagementObject mo in mos.Get())
            {
                if (mo["Model"] != null)
                {
                    modelName = mo["Model"].ToString();
                }

                else
                    modelName = "Custom";
            }

            return modelName;
        }

        private long getHDD()
        {
            long totalSize = 0;

            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT Size FROM Win32_DiskDrive WHERE MediaType = 'Fixed hard disk media'");

            foreach (ManagementObject mo in mos.Get())
            {
                string stringTotal = mo["Size"].ToString();
                totalSize += Convert.ToInt64(stringTotal);
            }

            return totalSize;
        }

        private long getRAM()
        {
            ManagementScope oMs = new ManagementScope();
            ObjectQuery oQuery = new ObjectQuery("SELECT Capacity FROM Win32_PhysicalMemory");
            ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oMs, oQuery);
            ManagementObjectCollection oCollection = oSearcher.Get();

            long MemSize = 0;
            long mCap = 0;

            // In case more than one Memory sticks are installed
            foreach (ManagementObject obj in oCollection)
            {
                mCap = Convert.ToInt64(obj["Capacity"]);
                MemSize += mCap;
            }

            return MemSize;
        }

       /* private int getPrice()
        {
            if (TouchScreenPresent)
                suggestedPrice += 50;

            FileStream file = new FileStream(@"PriceGuide.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(file);
            var textLines = File.ReadAllLines(@"PriceGuide.txt");

            foreach(var line in textLines)
            {
                string[] priceArray = line.Split(',');

                if(stringCPU.Contains(priceArray[1]))
                {
                    suggestedPrice += Convert.ToInt32(priceArray[2]);
                }
            }

            return suggestedPrice;

        } */

        private string getVideo()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT DeviceName FROM Win32_DisplayConfiguration");
            foreach (ManagementObject mo in mos.Get())
            {
                foreach(PropertyData property in mo.Properties)
                {
                    if(property.Name == "DeviceName")
                    {
                        stringVideo = property.Value.ToString();
                        if (stringVideo.Contains("Intel"))
                            stringVideo = "Intel HD Graphics";
                        //stringVideo = stringVideo.Remove(stringVideo.IndexOf("("));
                    }
                }
            }

            return stringVideo;
        }

        private string getOSVersion()
        {
            string osVersion = "";

            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");
            foreach(ManagementObject mo in mos.Get())
            {
                osVersion = mo.Properties["Caption"].Value.ToString();
            }

            return osVersion;
        }

        private bool getTouchScreen()
        {
            int touchscreen = GetSystemMetrics(SM_MAXIMUMTOUCHES);
            if (touchscreen > 0)
                return true;
            else
                return false;
        }
    }
}
