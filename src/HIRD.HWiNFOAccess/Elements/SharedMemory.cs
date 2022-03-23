using System.Runtime.InteropServices;

namespace HIRD.HWiNFOAccess.Elements
{
    internal class SharedMemory
    {
        public static HWiNFO_SENSORS_READING_ELEMENT GetReadingElement(ref GCHandle handle)
        {
            return (HWiNFO_SENSORS_READING_ELEMENT)Marshal.PtrToStructure(handle.AddrOfPinnedObject(),
                                typeof(HWiNFO_SENSORS_READING_ELEMENT));
        }

        public static HWiNFO_SENSORS_SENSOR_ELEMENT GetSensorElement(ref GCHandle handle)
        {
            return (HWiNFO_SENSORS_SENSOR_ELEMENT)Marshal.PtrToStructure(handle.AddrOfPinnedObject(),
                                typeof(HWiNFO_SENSORS_SENSOR_ELEMENT));
        }
    }
}
