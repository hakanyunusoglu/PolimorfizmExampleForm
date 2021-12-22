using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmExampleForm
{
    public class ProfilSilindir:TemelUrun
    {
        public decimal YariCap { get; set; }
        public override decimal GetTabanAlani()
        {
            return YariCap * YariCap * 22 / 7;
        }
        public override string ToString()
        {
            return ID + " " + UrunAdi;
        }
    }
}
