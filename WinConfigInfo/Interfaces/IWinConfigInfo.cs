using System.Management;

namespace WinConfigInfo.Interfaces
{
    public interface IWinConfigInfo
    {
        abstract public ManagementBaseObject GetAllInfo();
    }
}
