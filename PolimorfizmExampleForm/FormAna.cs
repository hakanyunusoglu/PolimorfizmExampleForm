namespace PolimorfizmExampleForm
{
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }

        private void silindirProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSilindir formsilindir = new FrmSilindir();
            formsilindir.Show();
        }

        private void dikd�rtgenProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDortgen formdortgen = new FrmDortgen();
            formdortgen.Show();
        }
    }
}