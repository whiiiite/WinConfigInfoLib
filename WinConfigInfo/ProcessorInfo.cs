using System.Management;
using WinConfigInfo.Interfaces;

namespace WinConfigInfo
{
    /// <summary>
    /// Class contains information about Processor from WMI class
    /// </summary>
    public class ProcessorInfo : IWinConfigInfo
    {
        /// <exception cref="NullReferenceException"/>
        public UInt16? AddressWidth { get { return (UInt16)GetAllInfo()["AddressWidth"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? Architecture { get { return (UInt16)GetAllInfo()["Architecture"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? AssetTag { get { return (string)GetAllInfo()["AssetTag"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? Availability { get { return (UInt16)GetAllInfo()["Availability"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? Caption { get { return (string)GetAllInfo()["Caption"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? Characteristics { get { return (UInt32)GetAllInfo()["Characteristics"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? ConfigManagerErrorCode { get { return (UInt32)GetAllInfo()["ConfigManagerErrorCode"]; } }


        /// <exception cref="NullReferenceException"/>
        public bool? ConfigManagerUserConfig { get { return (bool)GetAllInfo()["ConfigManagerUserConfig"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? CpuStatus { get { return (UInt16)GetAllInfo()["CpuStatus"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? CreationClassName { get { return (string)GetAllInfo()["CreationClassName"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? CurrentVoltage { get { return (UInt16)GetAllInfo()["CurrentVoltage"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? DataWidth { get { return (UInt16)GetAllInfo()["DataWidth"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? Description { get { return (string)GetAllInfo()["Description"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? DeviceID { get { return (string)GetAllInfo()["DeviceID"]; } }


        /// <exception cref="NullReferenceException"/>
        public bool? ErrorCleared { get { return (bool)GetAllInfo()["ErrorCleared"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? ErrorDescription { get { return (string)GetAllInfo()["ErrorDescription"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? ExtClock { get { return (UInt32)GetAllInfo()["ExtClock"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? Family { get { return (UInt16)GetAllInfo()["Family"]; } }


        /// <exception cref="NullReferenceException"/>
        public DateTime? InstallDate { get { return (DateTime?)GetAllInfo()["InstallDate"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? L2CacheSize { get { return (UInt32)GetAllInfo()["L2CacheSize"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? L2CacheSpeed { get { return (UInt32)GetAllInfo()["L2CacheSpeed"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? L3CacheSize { get { return (UInt32)GetAllInfo()["L3CacheSize"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? L3CacheSpeed { get { return (UInt32)GetAllInfo()["L3CacheSpeed"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? LastErrorCode { get { return (UInt32)GetAllInfo()["LastErrorCode"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? Level { get { return (UInt16)GetAllInfo()["Level"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? LoadPercentage { get { return (UInt16)GetAllInfo()["LoadPercentage"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? Manufacturer { get { return (string)GetAllInfo()["Manufacturer"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? MaxClockSpeed { get { return (UInt32)GetAllInfo()["MaxClockSpeed"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? Name { get { return (string)GetAllInfo()["Name"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? NumberOfCores { get { return (UInt32)GetAllInfo()["NumberOfCores"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? NumberOfEnabledCore { get { return (UInt32)GetAllInfo()["NumberOfEnabledCore"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? NumberOfLogicalProcessors { get { return (UInt32)GetAllInfo()["NumberOfLogicalProcessors"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? OtherFamilyDescription { get { return (string)GetAllInfo()["OtherFamilyDescription"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? PartNumber { get { return (string)GetAllInfo()["PartNumber"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? PNPDeviceID { get { return (string)GetAllInfo()["PNPDeviceID"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16[]? PowerManagementCapabilities { get { return (UInt16[])GetAllInfo()["PowerManagementCapabilities"]; } }


        /// <exception cref="NullReferenceException"/>
        public bool? PowerManagementSupported { get { return (bool)GetAllInfo()["PowerManagementSupported"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? ProcessorId { get { return (string)GetAllInfo()["ProcessorId"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? ProcessorType { get { return (UInt16)GetAllInfo()["ProcessorType"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? Revision { get { return (UInt16)GetAllInfo()["Revision"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? Role { get { return (string)GetAllInfo()["Role"]; } }


        /// <exception cref="NullReferenceException"/>
        public bool? SecondLevelAddressTranslationExtensions { get { return (bool)GetAllInfo()["SecondLevelAddressTranslationExtensions"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? SerialNumber { get { return (string)GetAllInfo()["SerialNumber"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? SocketDesignation { get { return (string)GetAllInfo()["SocketDesignation"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? Status { get { return (string)GetAllInfo()["Status"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? StatusInfo { get { return (UInt16)GetAllInfo()["StatusInfo"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? Stepping { get { return (string)GetAllInfo()["Stepping"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? SystemCreationClassName { get { return (string)GetAllInfo()["SystemCreationClassName"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? SystemName { get { return (string)GetAllInfo()["SystemName"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? ThreadCount { get { return (UInt32)GetAllInfo()["ThreadCount"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? UniqueId { get { return (string)GetAllInfo()["UniqueId"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? UpgradeMethod { get { return (UInt16)GetAllInfo()["UpgradeMethod"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? Version { get { return (string)GetAllInfo()["Version"]; } }


        /// <exception cref="NullReferenceException"/>
        public bool? VirtualizationFirmwareEnabled { get { return (bool)GetAllInfo()["VirtualizationFirmwareEnabled"]; } }


        /// <exception cref="NullReferenceException"/>
        public bool? VMMonitorModeExtensions { get { return (bool)GetAllInfo()["VMMonitorModeExtensions"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? VoltageCaps { get { return (UInt32)GetAllInfo()["VoltageCaps"]; } }


        /// <summary>
        ///
        /// </summary>
        /// <returns>All information about processor configuration from WMI class</returns>
        public ManagementBaseObject? GetAllInfo()
        {
            using (var searcher = new ManagementObjectSearcher("select * from Win32_Processor"))
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
            return "Processor WMI win_32 info class.";
        }
    }
}
