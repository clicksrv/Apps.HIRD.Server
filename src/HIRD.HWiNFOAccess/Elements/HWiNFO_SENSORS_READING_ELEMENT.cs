using System.Runtime.InteropServices;

namespace HIRD.HWiNFOAccess.Elements
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    public struct HWiNFO_SENSORS_READING_ELEMENT
    {
        public SENSOR_READING_TYPE tReading;
        public uint dwSensorIndex;
        public uint dwReadingID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constants.HWiNFO_SENSORS_STRING_LEN2)]
        public string szLabelOrig;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constants.HWiNFO_SENSORS_STRING_LEN2)]
        public string szLabelUser;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constants.HWiNFO_UNIT_STRING_LEN)]
        public string szUnit;
        public double Value;
        public double ValueMin;
        public double ValueMax;
        public double ValueAvg;
    };
}

// ***************************************************************************************************************
//                                          HWiNFO Shared Memory Footprint
// ***************************************************************************************************************
//
//         |-----------------------------|-----------------------------------|-----------------------------------|
// Content |  HWiNFO_SENSORS_SHARED_MEM2 |  HWiNFO_SENSORS_SENSOR_ELEMENT[]  | HWiNFO_SENSORS_READING_ELEMENT[]  |
//         |-----------------------------|-----------------------------------|-----------------------------------|
// Pointer |<--0                         |<--dwOffsetOfSensorSection         |<--dwOffsetOfReadingSection        |
//         |-----------------------------|-----------------------------------|-----------------------------------|
// Size    |  dwOffsetOfSensorSection    |   dwSizeOfSensorElement           |    dwSizeOfReadingElement         |
//         |                             |      * dwNumSensorElement         |       * dwNumReadingElement       |
//         |-----------------------------|-----------------------------------|-----------------------------------|
//
