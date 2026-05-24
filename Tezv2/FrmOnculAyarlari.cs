using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Tezv2
{
    public partial class FrmOnculAyarlari : Form
    {
        DbHatDengelemeKDSEntities db = new DbHatDengelemeKDSEntities();
        int seciliAnaOperasyonID = -1;

        public FrmOnculAyarlari()
        {
            InitializeComponent();
            HatlariYukle();
        }

        void HatlariYukle()
        {
            var hatlar = db.Tbl_Projeler.
                Select(x => new 
                { 
                    x.ProjeID, 
                    x.ProjeAdi 
                }).ToList();
            cmbHat.DataSource = hatlar;
            cmbHat.DisplayMember = "ProjeAdi";
            cmbHat.ValueMember = "ProjeID";
            cmbHat.SelectedIndex = -1;
        }

        void AnaIsleriGetir()
        {
            if (cmbHat.SelectedValue == null) return;
            int hatId;
            if (!int.TryParse(cmbHat.SelectedValue.ToString(), out hatId)) return;

            var operasyonlar = db.Tbl_Operasyonlar
                                 .Where(x => x.ProjeID == hatId)
                                 .Select(x => new
                                 {
                                     ID = x.OperasyonID,
                                     Kod = x.OperasyonKodu,
                                     İş_Tanımı = x.Tanim,
                                     Süre = x.Sure
                                 }).ToList();

            dgvKaynakIsler.DataSource = operasyonlar;

            if (dgvKaynakIsler.Columns.Count > 0) dgvKaynakIsler.Columns[0].Width = 40;

            lstOnculler.Items.Clear();
            lblSeciliIs.Text = "Seçili Ana İşlem: [YOK]";
            seciliAnaOperasyonID = -1;
        }

        private void dgvKaynakIsler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvKaynakIsler.Rows[e.RowIndex];
            seciliAnaOperasyonID = int.Parse(row.Cells["ID"].Value.ToString());
            string opAdi = row.Cells["İş_Tanımı"].Value.ToString();
            lblSeciliIs.Text = "Seçili Ana İşlem: " + opAdi;

            SagListeyiDoldur();
        }

        void SagListeyiDoldur() // yapay zeka yardımı
        {
            if (seciliAnaOperasyonID == -1) return;

            int hatId = (int)cmbHat.SelectedValue;

            var adaylar = db.Tbl_Operasyonlar
                            .Where(x => x.ProjeID == hatId && x.OperasyonID != seciliAnaOperasyonID)
                            .ToList();

            lstOnculler.Items.Clear();

            var mevcutOnculler = db.Tbl_Oncelikler
                                   .Where(x => x.OperasyonID == seciliAnaOperasyonID)
                                   .Select(x => x.OnculOperasyonID)
                                   .ToList();

            // Listbox'a ekle ve varsa tik at
            foreach (var op in adaylar)
            {
                bool seciliMi = mevcutOnculler.Contains(op.OperasyonID);
                string gorunum = $"[{op.OperasyonKodu}] {op.Tanim} ({op.Sure} sn)";

                // Özel Item sınıfımızı kullanıyoruz (ID'yi tutmak için)
                CheckedListBoxItem item = new CheckedListBoxItem
                {
                    Text = gorunum,
                    Value = op.OperasyonID
                };

                lstOnculler.Items.Add(item, seciliMi);
            }//
        }

        private void cmbHat_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnaIsleriGetir();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (seciliAnaOperasyonID == -1)
            {
                MessageBox.Show("Lütfen soldaki listeden bir Ana İşlem seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<int> secilenOnculIDleri = new List<int>();
            foreach (CheckedListBoxItem item in lstOnculler.CheckedItems)
            {
                secilenOnculIDleri.Add(item.Value);
            }

            foreach (int onculID in secilenOnculIDleri)
            {
                if (DonguVarMi(onculID, seciliAnaOperasyonID))
                {
                    MessageBox.Show($"HATA: Mantıksal Döngü Tespit Edildi!\n\n" +
                                    $"Seçtiğiniz öncül iş, zaten dolaylı yoldan Ana İşlemin sonrasında geliyor.\n" +
                                    $"Bu ilişki kurulursa üretim sonsuz döngüye girer.",
                                    "Kritik Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            var eskiKayitlar = db.Tbl_Oncelikler.Where(x => x.OperasyonID == seciliAnaOperasyonID).ToList();
            db.Tbl_Oncelikler.RemoveRange(eskiKayitlar);

            foreach (int onculID in secilenOnculIDleri)
            {
                Tbl_Oncelikler yeniIliski = new Tbl_Oncelikler
                {
                    OperasyonID = seciliAnaOperasyonID,
                    OnculOperasyonID = onculID
                };
                db.Tbl_Oncelikler.Add(yeniIliski);
            }

            db.SaveChanges();
            MessageBox.Show("Öncül ilişkileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        bool DonguVarMi(int baslangicID, int aradigimID)  // yapay zeka yardımı
        {
            // 1. Adım: Başlangıç işinin veritabanındaki öncüllerini bul
            var onculer = db.Tbl_Oncelikler
                            .Where(x => x.OperasyonID == baslangicID)
                            .Select(x => x.OnculOperasyonID)
                            .ToList();

            // 2. Adım: Aradığım ID (Ana İşlem) direkt bu öncüller içinde var mı?
            if (onculer.Contains(aradigimID)) return true; // Evet, döngü var!

            // 3. Adım: Yoksa, her bir öncülün de öncüllerine bak (Derinlemesine Arama - DFS)
            foreach (var altOnculID in onculer)
            {
                // Kendi içinde kendini çağıran fonksiyon (Recursion)
                if (DonguVarMi(altOnculID, aradigimID)) return true;
            }

            return false; // Hiçbir yerde bulamadık, döngü yok.
        }
    }

    public class CheckedListBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}