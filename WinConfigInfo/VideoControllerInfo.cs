using System.Management;
using WinConfigInfo.Interfaces;

namespace WinConfigInfo
{
    public class VideoControllerInfo : IWinConfigInfo
    {
        /// <exception cref="NullReferenceException"/>
        public UInt16[]? AcceleratorCapabilities { get { return (UInt16[])GetAllInfo()["AcceleratorCapabilities"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? AdapterCompatibility { get { return (string)GetAllInfo()["AdapterCompatibility"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? AdapterDACType { get { return (string)GetAllInfo()["AdapterDACType"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? AdapterRAM { get { return (UInt32)GetAllInfo()["AdapterRAM"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? Availability { get { return (UInt16)GetAllInfo()["Availability"]; } }


        /// <exception cref="NullReferenceException"/>
        public string[]? CapabilityDescriptions { get { return (string[])GetAllInfo()["CapabilityDescriptions"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? Caption { get { return (string)GetAllInfo()["Caption"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? ColorTableEntries { get { return (UInt32)GetAllInfo()["ColorTableEntries"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? ConfigManagerErrorCode { get { return (UInt32)GetAllInfo()["ConfigManagerErrorCode"]; } }


        /// <exception cref="NullReferenceException"/>
        public bool? ConfigManagerUserConfig { get { return (bool)GetAllInfo()["ConfigManagerUserConfig"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? CreationClassName { get { return (string)GetAllInfo()["CreationClassName"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? CurrentBitsPerPixel { get { return (UInt32)GetAllInfo()["CurrentBitsPerPixel"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? CurrentHorizontalResolution { get { return (UInt32)GetAllInfo()["CurrentHorizontalResolution"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt64? CurrentNumberOfColors { get { return (UInt64)GetAllInfo()["CurrentNumberOfColors"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? CurrentNumberOfColumns { get { return (UInt32)GetAllInfo()["CurrentNumberOfColumns"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? CurrentNumberOfRows { get { return (UInt32)GetAllInfo()["CurrentNumberOfRows"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? CurrentRefreshRate { get { return (UInt32)GetAllInfo()["CurrentRefreshRate"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? CurrentScanMode { get { return (UInt16)GetAllInfo()["CurrentScanMode"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? CurrentVerticalResolution { get { return (UInt32)GetAllInfo()["CurrentVerticalResolution"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? Description { get { return (string)GetAllInfo()["Description"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? DeviceID { get { return (string)GetAllInfo()["DeviceID"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? DeviceSpecificPens { get { return (UInt32)GetAllInfo()["DeviceSpecificPens"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? DitherType { get { return (UInt32)GetAllInfo()["DitherType"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? DriverDate { get { return (string)GetAllInfo()["DriverDate"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? DriverVersion { get { return (string)GetAllInfo()["DriverVersion"]; } }


        /// <exception cref="NullReferenceException"/>
        public bool? ErrorCleared { get { return (bool)GetAllInfo()["ErrorCleared"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? ErrorDescription { get { return (string)GetAllInfo()["ErrorDescription"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? ICMIntent { get { return (UInt32)GetAllInfo()["ICMIntent"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? ICMMethod { get { return (UInt32)GetAllInfo()["ICMMethod"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? InfFilename { get { return (string)GetAllInfo()["InfFilename"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? InfSection { get { return (string)GetAllInfo()["InfSection"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? InstallDate { get { return (string)GetAllInfo()["InstallDate"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? InstalledDisplayDrivers { get { return (string)GetAllInfo()["InstalledDisplayDrivers"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? LastErrorCode { get { return (UInt32)GetAllInfo()["LastErrorCode"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? MaxMemorySupported { get { return (UInt32)GetAllInfo()["MaxMemorySupported"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? MaxNumberControlled { get { return (UInt32)GetAllInfo()["MaxNumberControlled"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? MaxRefreshRate { get { return (UInt32)GetAllInfo()["MaxRefreshRate"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? MinRefreshRate { get { return (UInt32)GetAllInfo()["MinRefreshRate"]; } }


        /// <exception cref="NullReferenceException"/>
        public bool? Monochrome { get { return (bool)GetAllInfo()["Monochrome"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? Name { get { return (string)GetAllInfo()["Name"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? NumberOfColorPlanes { get { return (UInt16)GetAllInfo()["NumberOfColorPlanes"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? NumberOfVideoPages { get { return (UInt32)GetAllInfo()["NumberOfVideoPages"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? PNPDeviceID { get { return (string)GetAllInfo()["PNPDeviceID"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16[]? PowerManagementCapabilities { get { return (UInt16[])GetAllInfo()["PowerManagementCapabilities"]; } }


        /// <exception cref="NullReferenceException"/>
        public bool? PowerManagementSupported { get { return (bool)GetAllInfo()["PowerManagementSupported"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? ProtocolSupported { get { return (UInt16)GetAllInfo()["ProtocolSupported"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? ReservedSystemPaletteEntries { get { return (UInt32)GetAllInfo()["ReservedSystemPaletteEntries"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? SpecificationVersion { get { return (UInt16)GetAllInfo()["SpecificationVersion"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? Status { get { return (string)GetAllInfo()["Status"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? StatusInfo { get { return (UInt16)GetAllInfo()["StatusInfo"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? SystemCreationClassName { get { return (string)GetAllInfo()["SystemCreationClassName"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? SystemName { get { return (string)GetAllInfo()["SystemName"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? SystemPaletteEntries { get { return (UInt32)GetAllInfo()["SystemPaletteEntries"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? TimeOfLastReset { get { return (string)GetAllInfo()["TimeOfLastReset"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? VideoArchitecture { get { return (UInt16)GetAllInfo()["VideoArchitecture"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? VideoMemoryType { get { return (UInt16)GetAllInfo()["VideoMemoryType"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? VideoMode { get { return (UInt16)GetAllInfo()["VideoMode"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? VideoModeDescription { get { return (string)GetAllInfo()["VideoModeDescription"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? VideoProcessor { get { return (string)GetAllInfo()["VideoProcessor"]; } }


        public ManagementBaseObject? GetAllInfo()
        {
            using (var searcher = new ManagementObjectSearcher("select * from Win32_VideoController"))
            {
                foreach (var obj in searcher.Get())
                {
                    return obj;
                }
            }

            return null;
        }


        public override string ToString()
        {
            return "Video Controller WMI win_32 info class.";
        }
    }
}
