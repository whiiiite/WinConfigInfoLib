using System.Management;
using WinConfigInfo.Interfaces;

namespace WinConfigInfo
{
    public class BIOSInfo : IWinConfigInfo
    {
        /// <exception cref="NullReferenceException"/>
        public UInt16[]? BiosCharacteristics { get { return (UInt16[])GetAllInfo()["BiosCharacteristics"]; } }


        /// <exception cref="NullReferenceException"/>
        public string[]? BIOSVersion { get { return (string[])GetAllInfo()["BIOSVersion"]; } }


        /// <exception cref="NullReferenceException"/>
        public string BuildNumber { get { return (string)GetAllInfo()["BuildNumber"]; } }


        /// <exception cref="NullReferenceException"/>
        public string Caption { get { return (string)GetAllInfo()["Caption"]; } }


        /// <exception cref="NullReferenceException"/>
        public string CodeSet { get { return (string)GetAllInfo()["CodeSet"]; } }


        /// <exception cref="NullReferenceException"/>
        public string CurrentLanguage { get { return (string)GetAllInfo()["CurrentLanguage"]; } }


        /// <exception cref="NullReferenceException"/>
        public string Description { get { return (string)GetAllInfo()["Description"]; } }


        /// <exception cref="NullReferenceException"/>
        public byte EmbeddedControllerMajorVersion { get { return (byte)GetAllInfo()["EmbeddedControllerMajorVersion"]; } }


        /// <exception cref="NullReferenceException"/>
        public byte EmbeddedControllerMinorVersion { get { return (byte)GetAllInfo()["EmbeddedControllerMinorVersion"]; } }


        /// <exception cref="NullReferenceException"/>
        public string IdentificationCode { get { return (string)GetAllInfo()["IdentificationCode"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? InstallableLanguages { get { return (UInt16)GetAllInfo()["InstallableLanguages"]; } }


        /// <exception cref="NullReferenceException"/>
        public string InstallDate { get { return (string)GetAllInfo()["InstallDate"]; } }


        /// <exception cref="NullReferenceException"/>
        public string LanguageEdition { get { return (string)GetAllInfo()["LanguageEdition"]; } }


        /// <exception cref="NullReferenceException"/>
        public string[] ListOfLanguages { get { return (string[])GetAllInfo()["ListOfLanguages"]; } }


        /// <exception cref="NullReferenceException"/>
        public string Manufacturer { get { return (string)GetAllInfo()["Manufacturer"]; } }


        /// <exception cref="NullReferenceException"/>
        public string Name { get { return (string)GetAllInfo()["Name"]; } }


        /// <exception cref="NullReferenceException"/>
        public string OtherTargetOS { get { return (string)GetAllInfo()["OtherTargetOS"]; } }


        /// <exception cref="NullReferenceException"/>
        public bool PrimaryBIOS { get { return (bool)GetAllInfo()["PrimaryBIOS"]; } }


        /// <exception cref="NullReferenceException"/>
        public string ReleaseDate { get { return (string)GetAllInfo()["ReleaseDate"]; } }


        /// <exception cref="NullReferenceException"/>
        public string SerialNumber { get { return (string)GetAllInfo()["SerialNumber"]; } }


        /// <exception cref="NullReferenceException"/>
        public string SMBIOSBIOSVersion { get { return (string)GetAllInfo()["SMBIOSBIOSVersion"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? SMBIOSMajorVersion { get { return (UInt16)GetAllInfo()["SMBIOSMajorVersion"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? SMBIOSMinorVersion { get { return (UInt16)GetAllInfo()["SMBIOSMinorVersion"]; } }


        /// <exception cref="NullReferenceException"/>
        public bool SMBIOSPresent { get { return (bool)GetAllInfo()["SMBIOSPresent"]; } }


        /// <exception cref="NullReferenceException"/>
        public string SoftwareElementID { get { return (string)GetAllInfo()["SoftwareElementID"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? SoftwareElementState { get { return (UInt16)GetAllInfo()["SoftwareElementState"]; } }


        /// <exception cref="NullReferenceException"/>
        public string Status { get { return (string)GetAllInfo()["Status"]; } }


        /// <exception cref="NullReferenceException"/>
        public byte SystemBiosMajorVersion { get { return (byte)GetAllInfo()["SystemBiosMajorVersion"]; } }


        /// <exception cref="NullReferenceException"/>
        public byte SystemBiosMinorVersion { get { return (byte)GetAllInfo()["SystemBiosMinorVersion"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? TargetOperatingSystem { get { return (UInt16)GetAllInfo()["TargetOperatingSystem"]; } }


        /// <exception cref="NullReferenceException"/>
        public string Version { get { return (string)GetAllInfo()["Version"]; } }



        public ManagementBaseObject? GetAllInfo()
        {
            using (var searcher = new ManagementObjectSearcher("select * from Win32_BIOS"))
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
            return "BIOS WMI win_32 info class.";
        }
    }
}
