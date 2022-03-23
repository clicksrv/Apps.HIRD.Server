namespace HIRD.HWiNFOAccess
{
    public class ReadingSources
    {
        public CpuReadingSources CPU { get; set; } = new();
        public GpuReadingSources? GPU { get; set; }
        public SystemReadingSources System { get; set; } = new();
    }

    public class CpuReadingSources
    {
        public ReadingSource? PackageTemp { get; set; }
        public List<ReadingSource> CoreTemps { get; set; } = new();
        public List<ReadingSource> ThermalThrottling { get; set; } = new();
        public ReadingSource? CoreClockEffective { get; set; }
        public ReadingSource? Power { get; set; }
        public List<ReadingSource> CoreUsages { get; internal set; } = new();
        public ReadingSource? FanSpeed { get; internal set; }
    }

    public class GpuReadingSources
    {
        public ReadingSource? Temp { get; set; }
        public ReadingSource? HotSpotTemp { get; set; }
        public ReadingSource? Clock { get; set; }
        public ReadingSource? MemoryClock { get; set; }
        public List<ReadingSource> FanSpeeds { get; set; } = new();
        public ReadingSource? Power { get; set; }
        public ReadingSource? Usage { get; internal set; }
        public ReadingSource? MemUsage { get; internal set; }
    }

    public class SystemReadingSources
    {
        public ReadingSource? MemoryClock { get; set; }
        public ReadingSource? RamLoad { get; set; }
        public List<ReadingSource> StorageTemps { get; set; } = new();
        public ReadingSource? Power { get; set; }
        public ReadingSource? ChargeLevel { get; internal set; }
    }

    public struct ReadingSource
    {
        public ReadingSource(ushort id, string name)
        {
            Id = id;
            Name = name;
        }

        public ushort Id { get; set; }
        public string Name { get; set; }
    }
}


