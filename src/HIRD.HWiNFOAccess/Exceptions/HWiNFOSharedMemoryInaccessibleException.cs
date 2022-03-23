namespace HIRD.HWiNFOAccess.Exceptions
{
    [Serializable]
    internal class HWiNFOSharedMemoryInaccessibleException : Exception
    {
        private const string ErrorMessage = "An error occured while opening the HWiNFO shared memory! Please make sure HWiNFO is running and shared memory is enabled in settings.";

        public HWiNFOSharedMemoryInaccessibleException() : base(ErrorMessage)
        {
        }
    }
}