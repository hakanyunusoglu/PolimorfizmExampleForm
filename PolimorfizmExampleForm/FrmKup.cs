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
    public partial class FrmKup : Form
    {
        public FrmKup()
        {
            InitializeComponent();
        }
        List<ProfilKup> pkList = new List<ProfilKup>();
        private void btnekle_Click(object sender, EventArgs e)
        {
            ProfilKup pk = new ProfilKup();
            pk.ID = Convert.ToInt32(tbid.Text);
            pk.UrunAdi = tbad.Text;
            pk.Yukseklik = Convert.ToDecimal(tbyukseklik.Text);
            pk.KenarUzunluk = Convert.ToDecimal(tbkenar.Text);

            pkList.Add(pk);

            Temizle();

            Listele();
            tbhacim.Text = pk.GetHacim().ToString("#.000");
            tbfire.Text = pk.Fire().ToString("#.000");
            tbalan.Text =pk.GetTabanAlani().ToString("#.000");

        }
        ProfilKup selected;
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            selected.ID = Convert.ToInt32(tbid.Text);
            selected.UrunAdi = tbad.Text;
            selected.Yukseklik = Convert.ToDecimal(tbyukseklik.Text);
            selected.KenarUzunluk = Convert.ToDecimal(tbkenar.Text);
            tbhacim.Text = selected.GetHacim().ToString("#.000");
            tbfire.Text = selected.Fire().ToString("#.000");
            tbalan.Text = selected.GetTabanAlani().ToString("#.000");
            Listele();
            Temizle();
        }

        private void lburun_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = (ProfilKup)lburun.SelectedItem;

            tbid.Text = selected.ID.ToString();
            tbad.Text = selected.UrunAdi;
            tbyukseklik.Text = selected.Yukseklik.ToString();
            tbkenar.Text = selected.KenarUzunluk.ToString();
            tbalan.Text = selected.GetTabanAlani().ToString();
            tbhacim.Text = selected.GetHacim().ToString();
            tbfire.Text = selected.Fire().ToString();
        }

        private void Listele()
        {
            lburun.Items.Clear();
            foreach (var item in pkList)
            {
                lburun.Items.Add(item);
            }
            dgvurun.DataSource = null;
            dgvurun.DataSource = pkList;
        }

        private void Temizle()
        {
            tbid.Clear();
            tbad.Clear();
            tbyukseklik.Clear();
            tbkenar.Clear();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            pkList.Remove(selected);
            tbhacim.Clear();
            tbfire.Clear();
            tbalan.Clear();
            Listele();
            Temizle();
        }
    }
}
