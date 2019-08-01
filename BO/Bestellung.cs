using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Bestellung
    {
        public string Dp { get; set; }
        public BestInfo BestInfo { get; set; }
        public BestLieferant BestLieferant { get; set; }
        public BestKunde BestKunde { get; set; }
        public List<BestPosition> BestPositionen { get; set; }
    }
}
