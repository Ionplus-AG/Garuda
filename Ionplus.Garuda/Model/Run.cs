using System.Collections.Generic;

namespace Ionplus.Garuda.Model
{
    public sealed class Run
    {
        public int RunId { get; set; }
        public IEnumerable<Cycle> Cycles { get; set; }
    }
}
