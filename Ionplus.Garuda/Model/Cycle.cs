namespace Ionplus.Garuda.Model
{
    using System;

    public sealed class Cycle
    {
        public int CycleNumber { get; set; }
        public int SubcycleNumber { get; set; }
        public double Runtime { get; set; }
        public DateTime EndTime { get; set; }
        public Current Ana { get; set; }
        public Current A { get; set; }
        public Current B { get; set; }
        public Current Iso { get; set; }
        public int R { get; set; }
        public int G1 { get; set; }
        public int G2 { get; set; }
        public bool IsBurnIn { get; set; }
    }
}
