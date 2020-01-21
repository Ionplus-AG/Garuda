namespace Ionplus.Garuda.Model
{
    using System;
    using System.Collections.Generic;

    public sealed class Magazine
    {
        public string Name { get; set; }
        public int? IsotopeNumber { get; set; }
        public IEnumerable<Target> Targets { get; set; }
        public DateTime? LastChanged { get; set; }
    }
}
