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
    public partial class FrmSilindir : Form
    {
        public FrmSilindir()
        {
            InitializeComponent();
        }
        List<ProfilSilindir> psList = new List<ProfilSilindir>();

        private void btnekle_Click(object sender, EventArgs e)
        {
            ProfilSilindir ps = new ProfilSilindir();

            ps.ID = Convert.ToInt32(tbid.Text);
            ps.UrunAdi = tbad.Text;
            ps.Yukseklik = Convert.ToDecimal(tbyukseklik.Text);
            ps.YariCap = Convert.ToDecimal(tbyaricap.Text);

            psList.Add(ps);

            Temizle();

            Listele();
            tbhacim.Text = ps.GetHacim().ToString("#.000");
            tbfire.Text = ps.Fire().ToString("#.000");

        }

        private void Listele()
        {
            lburun.Items.Clear();
           foreach(var item in psList)
            {
                lburun.Items.Add(item);
            }
            dgvurun.DataSource = null;
           dgvurun.DataSource = psList;
        }

        private void Temizle()
        {
            tbid.Clear();
            tbad.Clear();
            tbyukseklik.Clear();
            tbyaricap.Clear();
        }
        ProfilSilindir selected;
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            selected.ID = Convert.ToInt32(tbid.Text);
            selected.UrunAdi = tbad.Text;
            selected.Yukseklik = Convert.ToDecimal(tbyukseklik.Text);
            selected.YariCap = Convert.ToDecimal(tbyaricap.Text);
            tbhacim.Text = selected.GetHacim().ToString();
            tbfire.Text = selected.Fire().ToString();
            Listele();
            Temizle();
        }

        private void lburun_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = (ProfilSilindir)lburun.SelectedItem;

            tbid.Text = selected.ID.ToString();
            tbad.Text = selected.UrunAdi;
            tbyukseklik.Text = selected.Yukseklik.ToString();
            tbyaricap.Text = selected.YariCap.ToString();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            psList.Remove(selected);
            Listele();
            Temizle();
        }
    }
}
