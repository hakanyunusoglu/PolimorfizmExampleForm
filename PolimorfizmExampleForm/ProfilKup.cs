using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmExampleForm
{
    public class ProfilKup:TemelUrun
    {
        public decimal KenarUzunluk { get; set; }


        public override string ToString()
        {
            return ID + " " + UrunAdi + " " + KenarUzunluk;
        }
        public override decimal GetTabanAlani()
        {
            return 6 * (KenarUzunluk * KenarUzunluk);
        }
        public override decimal GetHacim()
        {
            return KenarUzunluk * KenarUzunluk * KenarUzunluk;
        }
    }
}
