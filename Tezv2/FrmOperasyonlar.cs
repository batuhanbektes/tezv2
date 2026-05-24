using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Tezv2
{
    public partial class FrmOperasyonlar : Form
    {
        DbHatDengelemeKDSEntities db = new DbHatDengelemeKDSEntities();

        public FrmOperasyonlar()
        {
            InitializeComponent();
        }

        private void FrmOperasyonlar_Load(object sender, EventArgs e)
        {
            HatlariYukle();
        }

        void HatlariYukle()
        {
            var hatlar = db.Tbl_Projeler
                           .Select(x => new 
                           { 
                               x.ProjeID, 
                               x.ProjeAdi 
                           }).ToList();

            cmbHatSecimi.DataSource = hatlar;
            cmbHatSecimi.DisplayMember = "ProjeAdi";
            cmbHatSecimi.ValueMember = "ProjeID";
            cmbHatSecimi.SelectedIndex = -1;
        }

        void Listele() // yapay zeka yardımı
        {
            if (cmbHatSecimi.SelectedValue == null)
            {
                dgvOperasyonlar.DataSource = null;
                return;
            }

            // GÜVENLİ TİP DÖNÜŞÜMÜ: SelectedValue bazen nesne dönebilir, direkt (int) yapmak hata verebilir.
            int secilenHatId;
            bool cevirmeBasarili = int.TryParse(cmbHatSecimi.SelectedValue.ToString(), out secilenHatId);

            if (!cevirmeBasarili) return;
            //

            string aramaMetni = txtArama.Text.ToLower();

            var operasyonlar = db.Tbl_Operasyonlar
                                 .Where(x => x.ProjeID == secilenHatId &&
                                            (x.OperasyonKodu.Contains(aramaMetni) || x.Tanim.Contains(aramaMetni)))
                                 .Select(x => new
                                 {
                                     ID = x.OperasyonID,
                                     Kod = x.OperasyonKodu,
                                     Tanım = x.Tanim,
                                     Süre = x.Sure
                                 }).ToList();

            dgvOperasyonlar.DataSource = operasyonlar;

            if (dgvOperasyonlar.Columns.Count > 0)
                dgvOperasyonlar.Columns[0].Width = 40;
        }

        void Temizle()
        {
            txtID.Text = "";
            txtOpKodu.Text = "";
            txtOpAdi.Text = "";
            rTxtAciklama.Text = "";
            numSure.Value = 1;

            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            dgvOperasyonlar.ClearSelection();
        }

        private void cmbHatSecimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbHatSecimi.SelectedValue == null)
            {
                MessageBox.Show("Lütfen önce bir Hat seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtOpAdi.Text) || numSure.Value <= 0)
            {
                MessageBox.Show("Operasyon Adı ve Süresi boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Tbl_Operasyonlar yeniOp = new Tbl_Operasyonlar();
            yeniOp.ProjeID = (int)cmbHatSecimi.SelectedValue;
            yeniOp.OperasyonKodu = txtOpKodu.Text;
            yeniOp.Tanim = txtOpAdi.Text;
            yeniOp.Sure = (double)numSure.Value;
            yeniOp.Aciklama = rTxtAciklama.Text;

            db.Tbl_Operasyonlar.Add(yeniOp);
            db.SaveChanges();

            MessageBox.Show("Operasyon eklendi.");
            Listele();

            txtOpKodu.Text = "";
            txtOpAdi.Text = "";
            numSure.Value = 1;
            txtOpKodu.Focus();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) return;

            int id = int.Parse(txtID.Text);
            var op = db.Tbl_Operasyonlar.Find(id);

            if (op != null)
            {
                op.OperasyonKodu = txtOpKodu.Text;
                op.Tanim = txtOpAdi.Text;
                op.Sure = (double)numSure.Value;
                op.Aciklama = rTxtAciklama.Text;

                db.SaveChanges();
                MessageBox.Show("Operasyon güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) return;
            int id = int.Parse(txtID.Text);

            if (MessageBox.Show("Operasyonu silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var op = db.Tbl_Operasyonlar.Find(id);
                    db.Tbl_Operasyonlar.Remove(op);
                    db.SaveChanges();

                    Listele();
                    Temizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Operasyon silinirken bir hata oluştu. Bu operasyona bağlı bir 'Öncül İlişkisi' veya geçmiş sonuç olabilir. Önce ilişkileri temizlemeyi deneyin.\n\nHata Detayı: " + ex.Message, "Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dgvOperasyonlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvOperasyonlar.Rows[e.RowIndex];

            int id = int.Parse(row.Cells["ID"].Value.ToString());
            var op = db.Tbl_Operasyonlar.Find(id);

            if (op != null)
            {
                txtID.Text = op.OperasyonID.ToString();
                txtOpKodu.Text = op.OperasyonKodu;
                txtOpAdi.Text = op.Tanim;
                rTxtAciklama.Text = op.Aciklama;
                numSure.Value = (decimal)op.Sure;

                btnEkle.Enabled = false;
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }
        }
    }
}