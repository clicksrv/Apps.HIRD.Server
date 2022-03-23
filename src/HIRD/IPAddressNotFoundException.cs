using System.Runtime.Serialization;

namespace HIRD
{
    [Serializable]
    internal class IPAddressNotFoundException : Exception
    {
        public IPAddressNotFoundException() : base("No network adapters with an IPv4 address in the system!")
        {
        }
    }
}