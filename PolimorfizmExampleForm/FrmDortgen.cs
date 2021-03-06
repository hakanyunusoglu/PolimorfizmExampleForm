using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolimorfizmExampleForm
{
    public partial class FrmDortgen : Form
    {
        public FrmDortgen()
        {
            InitializeComponent();
        }
        List<ProfilDikdortgen> pdList = new List<ProfilDikdortgen>();
        private void btnekle_Click(object sender, EventArgs e)
        {
            ProfilDikdortgen pd = new ProfilDikdortgen();
           pd.ID = Convert.ToInt32(tbid.Text);
            pd.UrunAdi = tbad.Text;
            pd.Yukseklik = Convert.ToDecimal(tbyukseklik.Text);
            pd.KisaKenar = Convert.ToDecimal(tbkisakenar.Text);
            pd.UzunKenar = Convert.ToDecimal(tbuzunkenar.Text);

            pdList.Add(pd);

            Temizle();

            Listele();
            tbhacim.Text = pd.GetHacim().ToString("#.000");
            tbfire.Text = pd.Fire().ToString("#.000");

        }
        ProfilDikdortgen selected;
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            selected.ID = Convert.ToInt32(tbid.Text);
            selected.UrunAdi = tbad.Text;
            selected.Yukseklik = Convert.ToDecimal(tbyukseklik.Text);
            selected.KisaKenar = Convert.ToDecimal(tbkisakenar.Text);
            selected.UzunKenar = Convert.ToDecimal(tbuzunkenar.Text);
            tbhacim.Text = selected.GetHacim().ToString();
            tbfire.Text = selected.Fire().ToString();
            Listele();
            Temizle();
        }

        private void lburun_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = (ProfilDikdortgen)lburun.SelectedItem;

            tbid.Text = selected.ID.ToString();
            tbad.Text = selected.UrunAdi;
            tbyukseklik.Text = selected.Yukseklik.ToString();
            tbkisakenar.Text = selected.KisaKenar.ToString();
            tbuzunkenar.Text = selected.UzunKenar.ToString();
        }

        private void Listele()
        {
            lburun.Items.Clear();
            foreach (var item in pdList)
            {
                lburun.Items.Add(item);
            }
            dgvurun.DataSource = null;
            dgvurun.DataSource = pdList;
        }

        private void Temizle()
        {
            tbid.Clear();
            tbad.Clear();
            tbyukseklik.Clear();
            tbkisakenar.Clear();
            tbuzunkenar.Clear();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            pdList.Remove(selected);
            tbhacim.Clear();
            tbfire.Clear();
            Listele();
            Temizle();
        }
    }
}
