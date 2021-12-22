using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmExampleForm
{
    public class ProfilDikdortgen:TemelUrun
    {
        public decimal KisaKenar { get; set; }
        public decimal UzunKenar { get; set; }
        public override decimal GetTabanAlani()
        {
            return KisaKenar * UzunKenar;
        }
        public override string ToString()
        {
            return ID + " " + UrunAdi;
        }
    }
}
