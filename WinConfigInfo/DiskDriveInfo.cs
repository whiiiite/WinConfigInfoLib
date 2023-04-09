using System.Management;
using WinConfigInfo.Interfaces;

namespace WinConfigInfo
{
    public class DiskDriveInfo : IWinConfigInfo
    {
        /// <exception cref="NullReferenceException"/>
        public UInt16? Availability { get { return (UInt16)GetAllInfo()["Availability"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? BytesPerSector { get { return (UInt32)GetAllInfo()["BytesPerSector"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16[]? Capabilities { get { return (UInt16[])GetAllInfo()["Capabilities"]; } }


        /// <exception cref="NullReferenceException"/>
        public string[]? CapabilityDescriptions { get { return (string[])GetAllInfo()["CapabilityDescriptions"]; } }


        /// <exception cref="NullReferenceException"/>
        public string Caption { get { return (string)GetAllInfo()["Caption"]; } }


        /// <exception cref="NullReferenceException"/>
        public string CompressionMethod { get { return (string)GetAllInfo()["CompressionMethod"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? ConfigManagerErrorCode { get { return (UInt32)GetAllInfo()["ConfigManagerErrorCode"]; } }


        /// <exception cref="NullReferenceException"/>
        public bool? ConfigManagerUserConfig { get { return (bool)GetAllInfo()["ConfigManagerUserConfig"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? CreationClassName { get { return (string)GetAllInfo()["CreationClassName"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt64? DefaultBlockSize { get { return (UInt64)GetAllInfo()["DefaultBlockSize"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? Description { get { return (string)GetAllInfo()["Description"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? DeviceID { get { return (string)GetAllInfo()["DeviceID"]; } }


        /// <exception cref="NullReferenceException"/>
        public bool? ErrorCleared { get { return (bool)GetAllInfo()["ErrorCleared"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? ErrorDescription { get { return (string)GetAllInfo()["ErrorDescription"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? ErrorMethodology { get { return (string)GetAllInfo()["ErrorMethodology"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? FirmwareRevision { get { return (string)GetAllInfo()["FirmwareRevision"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? Index { get { return (UInt32)GetAllInfo()["Index"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? InstallDate { get { return (string)GetAllInfo()["InstallDate"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? InterfaceType { get { return (string)GetAllInfo()["InterfaceType"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? LastErrorCode { get { return (UInt32)GetAllInfo()["LastErrorCode"]; } }


        /// <exception cref="NullReferenceException"/>
        public string Manufacturer { get { return (string)GetAllInfo()["Manufacturer"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt64? MaxBlockSize { get { return (UInt64)GetAllInfo()["MaxBlockSize"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt64? MaxMediaSize { get { return (UInt64)GetAllInfo()["MaxMediaSize"]; } }


        /// <exception cref="NullReferenceException"/>
        public bool? MediaLoaded { get { return (bool)GetAllInfo()["MediaLoaded"]; } }


        /// <exception cref="NullReferenceException"/>
        public string MediaType { get { return (string)GetAllInfo()["MediaType"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt64? MinBlockSize { get { return (UInt64)GetAllInfo()["MinBlockSize"]; } }


        /// <exception cref="NullReferenceException"/>
        public string Model { get { return (string)GetAllInfo()["Model"]; } }


        /// <exception cref="NullReferenceException"/>
        public string Name { get { return (string)GetAllInfo()["Name"]; } }


        /// <exception cref="NullReferenceException"/>
        public bool? NeedsCleaning { get { return (bool)GetAllInfo()["NeedsCleaning"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? NumberOfMediaSupported { get { return (UInt32)GetAllInfo()["NumberOfMediaSupported"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? Partitions { get { return (UInt32)GetAllInfo()["Partitions"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? PNPDeviceID { get { return (string)GetAllInfo()["PNPDeviceID"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16[]? PowerManagementCapabilities { get { return (UInt16[])GetAllInfo()["PowerManagementCapabilities"]; } }


        /// <exception cref="NullReferenceException"/>
        public bool? PowerManagementSupported { get { return (bool)GetAllInfo()["PowerManagementSupported"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? SCSIBus { get { return (UInt32)GetAllInfo()["SCSIBus"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? SCSILogicalUnit { get { return (UInt16)GetAllInfo()["SCSILogicalUnit"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? SCSIPort { get { return (UInt16)GetAllInfo()["SCSIPort"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? SCSITargetId { get { return (UInt16)GetAllInfo()["SCSITargetId"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? SectorsPerTrack { get { return (UInt32)GetAllInfo()["SectorsPerTrack"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? SerialNumber { get { return (string)GetAllInfo()["SerialNumber"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? Signature { get { return (UInt32)GetAllInfo()["Signature"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt64? Size { get { return (UInt64)GetAllInfo()["Size"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? Status { get { return (string)GetAllInfo()["Status"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? StatusInfo { get { return (UInt16)GetAllInfo()["StatusInfo"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? SystemCreationClassName { get { return (string)GetAllInfo()["SystemCreationClassName"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? SystemName { get { return (string)GetAllInfo()["SystemName"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt64? TotalCylinders { get { return (UInt64)GetAllInfo()["TotalCylinders"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? TotalHeads { get { return (UInt32)GetAllInfo()["TotalHeads"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt64? TotalSectors { get { return (UInt64)GetAllInfo()["TotalSectors"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt64? TotalTracks { get { return (UInt64)GetAllInfo()["TotalTracks"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? TracksPerCylinder { get { return (UInt32)GetAllInfo()["TracksPerCylinder"]; } }



        public ManagementBaseObject? GetAllInfo()
        {
            using (var searcher = new ManagementObjectSearcher("select * from Win32_DiskDrive"))
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
            return "DiskDrive WMI win_32 info class.";
        }
    }
}
