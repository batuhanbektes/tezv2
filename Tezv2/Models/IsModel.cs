using System.Collections.Generic;
using System.Diagnostics;

namespace Tezv2.Models
{
    [DebuggerStepThrough]
    public class IsModel
    {
        public int ID { get; set; }

        public string Kod { get; set; }

        public string Tanim { get; set; }

        public double Sure { get; set; }

        public List<int> OnculIDleri { get; set; } = new List<int>();
    }
}