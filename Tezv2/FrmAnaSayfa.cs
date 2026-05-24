using System;
using System.Windows.Forms;

namespace Tezv2
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void FormGetir(Form childForm)
        {
            pnlMain.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(childForm);
            childForm.Show();
        }

        private void btnHatlar_Click(object sender, EventArgs e)
        {
            FormGetir(new FrmHatlar());
        }

        private void btnOperasyonlar_Click(object sender, EventArgs e)
        {
            FormGetir(new FrmOperasyonlar());
        }

        private void btnOnculler_Click(object sender, EventArgs e)
        {
            FormGetir(new FrmOnculAyarlari());

        }

        private void btnDiyagram_Click(object sender, EventArgs e)
        {
            FormGetir(new FrmOnculDiyagrami());
        }

        private void btnSimulasyon_Click(object sender, EventArgs e)
        {
            FormGetir(new FrmHatDengeleme());
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            FormGetir(new FrmGecmisSonuclar());
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}