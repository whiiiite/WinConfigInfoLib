using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace WinConfigInfo
{
    public class TemperatureProbeInfo
    {
        /// <exception cref="NullReferenceException"/>
        public Int32 Accuracy { get { return (Int32)GetAllInfo()["Accuracy"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16? Availability { get { return (UInt16)GetAllInfo()["Availability"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? ConfigManagerErrorCode { get { return (UInt32)GetAllInfo()["ConfigManagerErrorCode"]; } }


        /// <exception cref="NullReferenceException"/>
        public bool? ConfigManagerUserConfig { get { return (bool)GetAllInfo()["ConfigManagerUserConfig"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? CreationClassName { get { return (string)GetAllInfo()["CreationClassName"]; } }


        /// <exception cref="NullReferenceException"/>
        public Int32 CurrentReading { get { return (Int32)GetAllInfo()["CurrentReading"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? Description { get { return (string)GetAllInfo()["Description"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? DeviceID { get { return (string)GetAllInfo()["DeviceID"]; } }


        /// <exception cref="NullReferenceException"/>
        public bool? ErrorCleared { get { return (bool)GetAllInfo()["ErrorCleared"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? ErrorDescription { get { return (string)GetAllInfo()["ErrorDescription"]; } }


        /// <exception cref="NullReferenceException"/>
        public DateTime? InstallDate { get { return (DateTime?)GetAllInfo()["InstallDate"]; } }


        /// <exception cref="NullReferenceException"/>
        public bool? IsLinear { get { return (bool)GetAllInfo()["IsLinear"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? LastErrorCode { get { return (UInt32)GetAllInfo()["LastErrorCode"]; } }


        public double CurrentTemperature { get
            {
                Double temperature = Convert.ToDouble(GetAllInfo2()["CurrentTemperature"].ToString());
                temperature = (temperature - 2732) / 10.0;
                return temperature;
            } 
        }


        /// <exception cref="NullReferenceException"/>
        public Int32 LowerThresholdCritical { get { return (Int32)GetAllInfo()["LowerThresholdCritical"]; } }


        /// <exception cref="NullReferenceException"/>
        public Int32 LowerThresholdFatal { get { return (Int32)GetAllInfo()["LowerThresholdFatal"]; } }


        /// <exception cref="NullReferenceException"/>
        public Int32 LowerThresholdNonCritical { get { return (Int32)GetAllInfo()["LowerThresholdNonCritical"]; } }


        /// <exception cref="NullReferenceException"/>
        public Int32 MaxReadable { get { return (Int32)GetAllInfo()["MaxReadable"]; } }


        /// <exception cref="NullReferenceException"/>
        public Int32 MinReadable { get { return (Int32)GetAllInfo()["MinReadable"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? Name { get { return (string)GetAllInfo()["Name"]; } }


        /// <exception cref="NullReferenceException"/>
        public Int32 NominalReading { get { return (Int32)GetAllInfo()["NominalReading"]; } }


        /// <exception cref="NullReferenceException"/>
        public Int32 NormalMax { get { return (Int32)GetAllInfo()["NormalMax"]; } }


        /// <exception cref="NullReferenceException"/>
        public Int32 NormalMin { get { return (Int32)GetAllInfo()["NormalMin"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? PNPDeviceID { get { return (string)GetAllInfo()["PNPDeviceID"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt16[]? PowerManagementCapabilities { get { return (UInt16[])GetAllInfo()["PowerManagementCapabilities"]; } }


        /// <exception cref="NullReferenceException"/>
        public bool? PowerManagementSupported { get { return (bool)GetAllInfo()["PowerManagementSupported"]; } }


        /// <exception cref="NullReferenceException"/>
        public UInt32? Resolution { get { return (UInt32)GetAllInfo()["Resolution"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? Status { get { return (string)GetAllInfo()["Status"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? SystemCreationClassName { get { return (string)GetAllInfo()["SystemCreationClassName"]; } }


        /// <exception cref="NullReferenceException"/>
        public string? SystemName { get { return (string)GetAllInfo()["SystemName"]; } }


        /// <exception cref="NullReferenceException"/>
        public Int32 Tolerance { get { return (Int32)GetAllInfo()["Tolerance"]; } }


        /// <exception cref="NullReferenceException"/>
        public Int32 UpperThresholdCritical { get { return (Int32)GetAllInfo()["UpperThresholdCritical"]; } }


        /// <exception cref="NullReferenceException"/>
        public Int32 UpperThresholdFatal { get { return (Int32)GetAllInfo()["UpperThresholdFatal"]; } }


        /// <exception cref="NullReferenceException"/>
        public Int32 UpperThresholdNonCritical { get { return (Int32)GetAllInfo()["UpperThresholdNonCritical"]; } }


        public ManagementBaseObject? GetAllInfo()
        {
            using (var searcher = new ManagementObjectSearcher("select * from Win32_TemperatureProbe"))
            {
                foreach (var obj in searcher.Get())
                {
                    return obj;
                }
            }

            return null;
        }


        public ManagementBaseObject? GetAllInfo2()
        {
            using (var searcher = new ManagementObjectSearcher(@"root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature"))
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
            return "Temperature probe WMI win_32 info class.";
        }
    }
}
