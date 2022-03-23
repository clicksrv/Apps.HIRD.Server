namespace HIRD.HWiNFOAccess.Exceptions
{
    [Serializable]
    internal class HWiNFONotRunningException : Exception
    {
        public HWiNFONotRunningException() : base("Could not find 'HWiNFO64.exe' running.")
        {
        }
    }
}