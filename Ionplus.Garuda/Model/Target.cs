namespace Ionplus.Garuda.Model
{
    using System;
    using System.Collections.Generic;

    public sealed class Target
    {
        public int SampleNumber { get; set; }
        public int PrepNumber { get; set; }
        public int TargetNumber { get; set; }
        public int? IsotopeNumber { get; set; }
        public int? Position { get; set; }
        public int? MaxCycles { get; set; }
        public string Comment { get; set; }
        public IEnumerable<Run> Runs { get; set; }
        public DateTime? LastChanged { get; set; }
    }
}
