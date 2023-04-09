using System.Management;
using WinConfigInfo.Interfaces;

namespace WinConfigInfo
{
    public class MotherboardInfo : IWinConfigInfo
    {
        /// <exception cref="NullReferenceException"/>
        public UInt16? Availability { get { return (UInt16)GetAllInfo()["Availability"]; } }


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
        public bool? ErrorCleared { get { return (bool)GetAllInfo()["ErrorCleared"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? ErrorDescription { get { return (string)GetAllInfo()["ErrorDescription"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? InstallDate { get { return (string)GetAllInfo()["InstallDate"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? LastErrorCode { get { return (UInt32)GetAllInfo()["LastErrorCode"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? Name { get { return (string)GetAllInfo()["Name"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? PNPDeviceID { get { return (string)GetAllInfo()["PNPDeviceID"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16[]? PowerManagementCapabilities { get { return (UInt16[])GetAllInfo()["PowerManagementCapabilities"]; } }


        /// <exception cref="NullReferenceException"/>
        public bool? PowerManagementSupported { get { return (bool)GetAllInfo()["PowerManagementSupported"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? PrimaryBusType { get { return (string)GetAllInfo()["PrimaryBusType"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? RevisionNumber { get { return (string)GetAllInfo()["RevisionNumber"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? SecondaryBusType { get { return (string)GetAllInfo()["SecondaryBusType"]; } }


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
            using (var searcher = new ManagementObjectSearcher("select * from Win32_MotherboardDevice"))
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
            return "Motherboard WMI win_32 info class.";
        }
    }
}
