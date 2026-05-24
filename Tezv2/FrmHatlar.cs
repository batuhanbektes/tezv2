using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Tezv2
{
    public partial class FrmHatlar : Form
    {
        DbHatDengelemeKDSEntities db = new DbHatDengelemeKDSEntities();

        public FrmHatlar()
        {
            InitializeComponent();
        }

        private void FrmHatlar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var hatlar = db.Tbl_Projeler
               .Select(x => new
               {
                   ID = x.ProjeID,
                   HatAdı = x.ProjeAdi,
                   Açıklama = x.Aciklama,
                   Tarih = x.OlusturmaTarihi
               }).ToList();

            dgvHatlar.DataSource = hatlar;

            if (dgvHatlar.Columns.Count > 0)
            {
                dgvHatlar.Columns[0].Width = 50;
            }
        }

        void Temizle()
        {
            txtID.Text = "";
            txtHatAdi.Text = "";
            rTxtAciklama.Text = "";

            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;

            dgvHatlar.ClearSelection();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHatAdi.Text))
            {
                MessageBox.Show("Lütfen bir Hat Adı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Tbl_Projeler yeniHat = new Tbl_Projeler();
            yeniHat.ProjeAdi = txtHatAdi.Text;
            yeniHat.Aciklama = rTxtAciklama.Text;
            yeniHat.OlusturmaTarihi = DateTime.Now;

            db.Tbl_Projeler.Add(yeniHat);
            db.SaveChanges();

            MessageBox.Show("Yeni hat başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) return;

            if (MessageBox.Show("Bu hattı silmek istediğinize emin misiniz?\n\nDİKKAT: Hatta bağlı tüm operasyonlar ve sonuçlar da silinecektir!", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int id = int.Parse(txtID.Text);
                    var silinecekHat = db.Tbl_Projeler.Find(id);

                    if (silinecekHat != null)
                    {
                        db.Tbl_Projeler.Remove(silinecekHat);
                        db.SaveChanges();

                        MessageBox.Show("Hat silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listele();
                        Temizle();
                    }
                }
                catch (Exception ex)
                {
                    // Programın çökmesini engelle, kullanıcıyı bilgilendir
                    MessageBox.Show("Silme işlemi sırasında bir hata oluştu. Bu hat kullanımda olabilir (Örn: Bu hata ait operasyonlar varsa önce onları silmelisiniz).\n\nHata Detayı: " + ex.Message, "Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) return;

            int id = int.Parse(txtID.Text);
            var guncellenecekHat = db.Tbl_Projeler.Find(id);

            if (guncellenecekHat != null)
            {
                guncellenecekHat.ProjeAdi = txtHatAdi.Text;
                guncellenecekHat.Aciklama = rTxtAciklama.Text;

                db.SaveChanges();

                MessageBox.Show("Hat bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        // Grid'den Seçim Yapılınca
        private void dgvHatlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvHatlar.Rows[e.RowIndex];

            txtID.Text = row.Cells["ID"].Value.ToString();
            txtHatAdi.Text = row.Cells["HatAdı"].Value.ToString();
            rTxtAciklama.Text = row.Cells["Açıklama"].Value.ToString();

            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }
    }
}