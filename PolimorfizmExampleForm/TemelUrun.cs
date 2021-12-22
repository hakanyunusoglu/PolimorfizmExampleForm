using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmExampleForm
{
    public class TemelUrun
    {
        public int ID { get; set; }
        public string UrunAdi { get; set; }
        public decimal Yukseklik { get; set; }
        public decimal Fire()
        {
            return GetHacim() * 20 / 100;
        }

        public decimal GetHacim()
        {
            return GetTabanAlani() * Yukseklik;
        }

        public virtual decimal GetTabanAlani()
        {
            return Yukseklik * Yukseklik;
        }

    }
}
