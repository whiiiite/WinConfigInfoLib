using System.Management;
using WinConfigInfo.Interfaces;

namespace WinConfigInfo
{

    /// <summary>
    /// The Win32_DesktopMonitor WMI class represents the type of monitor or display device attached to the computer system.
    /// </summary>
    public class DesktopMonitorInfo : IWinConfigInfo
    {
        /// <exception cref="NullReferenceException"/>
        public UInt16? Availability { get { return (UInt16)GetAllInfo()["Availability"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? Bandwidth { get { return (UInt32)GetAllInfo()["Bandwidth"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? Caption { get { return (string)GetAllInfo()["Caption"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? ConfigManagerErrorCode { get { return (UInt32)GetAllInfo()["ConfigManagerErrorCode"]; } }


        /// <exception cref="NullReferenceException"/>
        public bool? ConfigManagerUserConfig { get { return (bool)GetAllInfo()["ConfigManagerUserConfig"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? CreationClassName { get { return (string)GetAllInfo()["CreationClassName"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? Description { get { return (string)GetAllInfo()["Description"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? DeviceID { get { return (string)GetAllInfo()["DeviceID"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? DisplayType { get { return (UInt16)GetAllInfo()["DisplayType"]; } }


        /// <exception cref="NullReferenceException"/>
        public bool? ErrorCleared { get { return (bool)GetAllInfo()["ErrorCleared"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? ErrorDescription { get { return (string)GetAllInfo()["ErrorDescription"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? InstallDate { get { return (string)GetAllInfo()["InstallDate"]; } }


        /// <exception cref="NullReferenceException"/>
        public bool? IsLocked { get { return (bool)GetAllInfo()["IsLocked"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? LastErrorCode { get { return (UInt32)GetAllInfo()["LastErrorCode"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? MonitorManufacturer { get { return (string)GetAllInfo()["MonitorManufacturer"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? MonitorType { get { return (string)GetAllInfo()["MonitorType"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? Name { get { return (string)GetAllInfo()["Name"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? PixelsPerXLogicalInch { get { return (UInt32)GetAllInfo()["PixelsPerXLogicalInch"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? PixelsPerYLogicalInch { get { return (UInt32)GetAllInfo()["PixelsPerYLogicalInch"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? PNPDeviceID { get { return (string)GetAllInfo()["PNPDeviceID"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16[]? PowerManagementCapabilities { get { return (UInt16[])GetAllInfo()["PowerManagementCapabilities"]; } }


        /// <exception cref="NullReferenceException"/>
        public bool? PowerManagementSupported { get { return (bool)GetAllInfo()["PowerManagementSupported"]; } }


        /// <exception cref="NullReferenceException"/>
        /// <summary>return value in pixels</summary>
        public static UInt32? ScreenHeight { get { return (UInt32)GetSystemMetrics(1); } } // from WMI class it return null. I just add it from user32.dll


        /// <exception cref="NullReferenceException"/>
        /// <summary>return value in pixels</summary>
        public static UInt32? ScreenWidth { get { return (UInt32)GetSystemMetrics(0); } } // from WMI class it return null. I just add it from user32.dll


        /// <exception cref="NullReferenceException"/>
        public string? Status { get { return (string)GetAllInfo()["Status"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? StatusInfo { get { return (UInt16)GetAllInfo()["StatusInfo"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? SystemCreationClassName { get { return (string)GetAllInfo()["SystemCreationClassName"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? SystemName { get { return (string)GetAllInfo()["SystemName"]; } }


        public ManagementBaseObject? GetAllInfo()
        {
            using (var searcher = new ManagementObjectSearcher("select * from Win32_DesktopMonitor"))
            {
                foreach (var obj in searcher.Get())
                {
                    return obj;
                }
            }

            return null;
        }


        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int GetSystemMetrics(int i);


        public override string ToString()
        {
            return "DesktopMonitor WMI win_32 info class.";
        }
    }
}
