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
        private string _UrunAdi;
        public string UrunAdi { get { return _UrunAdi; } 
            set {
                _UrunAdi = value;
                int boyut = _UrunAdi.Length -1;
                string yildiz = "";
                for(int i = 0;i< boyut;i++)
                {
                    yildiz += "*";
                }
                _UrunAdi = string.Concat(value.Substring(0,1).ToUpper(),yildiz);
                
                ; } }
        public decimal Yukseklik { get; set; }
        public decimal Fire()
        {
            return GetHacim() * 20 / 100;
        }

        public virtual decimal GetHacim()
        {
            return GetTabanAlani() * Yukseklik;
        }

        public virtual decimal GetTabanAlani()
        {
            return Yukseklik * Yukseklik;
        }

    }
}
