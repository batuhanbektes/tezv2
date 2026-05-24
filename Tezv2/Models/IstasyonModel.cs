using System.Collections.Generic;
using System.Diagnostics;

namespace Tezv2.Models
{
    [DebuggerStepThrough]
    public class IstasyonModel
    {
        public int IstasyonNo { get; set; }

        public List<IsModel> AtananIsler { get; set; } = new List<IsModel>();

        public double ToplamSure { get; set; } = 0;
    }
}