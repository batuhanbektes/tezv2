using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tezv2.Models;
using Excel = Microsoft.Office.Interop.Excel;

namespace Tezv2
{
    public partial class FrmGecmisSonuclar : Form
    {
        DbHatDengelemeKDSEntities db = new DbHatDengelemeKDSEntities();

        public FrmGecmisSonuclar()
        {
            InitializeComponent();
        }

        private void FrmGecmisSonuclar_Load(object sender, EventArgs e)
        {
            HatlariDoldur();
            SonuclariListele();
            GridDuzenle();

            dtBaslangic.ValueChanged += (s, ev) => SonuclariListele();
            dtBitis.ValueChanged += (s, ev) => SonuclariListele();
        }

        void HatlariDoldur()
        {
            var hatlar = db.Tbl_Projeler
                           .Select(x => new { x.ProjeID, x.ProjeAdi })
                           .ToList();

            hatlar.Insert(0, new { ProjeID = -1, ProjeAdi = "--- Tümü ---" });

            cmbHatFiltre.DataSource = hatlar;
            cmbHatFiltre.DisplayMember = "ProjeAdi";
            cmbHatFiltre.ValueMember = "ProjeID";
        }

        void SonuclariListele()
        {
            var sorgu = db.Tbl_Cozumler.AsQueryable();

            if (cmbHatFiltre.SelectedValue != null)
            {
                if (int.TryParse(cmbHatFiltre.SelectedValue.ToString(), out int seciliHatId))
                {
                    if (seciliHatId != -1)
                        sorgu = sorgu.Where(x => x.ProjeID == seciliHatId);
                }
            }

            if (chkTarihAraligi.Checked)
            {
                DateTime baslangic = dtBaslangic.Value.Date;
                DateTime bitis = dtBitis.Value.Date.AddDays(1).AddSeconds(-1);
                sorgu = sorgu.Where(x => x.CozumTarihi >= baslangic && x.CozumTarihi <= bitis);
            }

            var liste = sorgu.OrderByDescending(x => x.CozumTarihi)
                             .ToList()
                             .Select(x => new
                             {
                                 ID = x.CozumID,
                                 Hat = x.Tbl_Projeler.ProjeAdi,
                                 Tarih = x.CozumTarihi,
                                 Durdurma = (x.DurdurmaKriteri == "İterasyon")
                                     ? $"{x.IterasyonSayisi} (İterasyon)"
                                     : $"{x.UygunlukLimiti} (Uygunluk)",
                                 Fitness = x.Fitness,
                                 Verim = x.HatVerimliligi,
                                 Ist_Sayisi = x.IstasyonSayisi,
                                 Hedef_Sure = x.HedefCevrimSuresi,
                                 Pop_Boyut = x.PopulasyonBuyuklugu
                             }).ToList();

            dgvListe.DataSource = liste;
        }

        void GridDuzenle()
        {
            if (dgvListe.Columns.Count > 0)
            {
                dgvListe.Columns["ID"].Width = 50;
                dgvListe.Columns["Hat"].Width = 150;
                dgvListe.Columns["Tarih"].Width = 120;
                dgvListe.Columns["Fitness"].DefaultCellStyle.Format = "F3";
                dgvListe.Columns["Verim"].DefaultCellStyle.Format = "0.000'%'";

                if (dgvListe.Columns.Contains("Durdurma"))
                    dgvListe.Columns["Durdurma"].HeaderText = "Durdurma Kriteri";
            }
        }

        private void cmbHatFiltre_SelectedIndexChanged(object sender, EventArgs e) => SonuclariListele();
        private void btnFiltrele_Click(object sender, EventArgs e) => SonuclariListele();
        private void chkTarihAraligi_CheckedChanged(object sender, EventArgs e)
        {
            dtBaslangic.Enabled = chkTarihAraligi.Checked;
            dtBitis.Enabled = chkTarihAraligi.Checked;
            SonuclariListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvListe.SelectedRows.Count == 0) { MessageBox.Show("Seçim yapınız."); return; }
            int id = Convert.ToInt32(dgvListe.SelectedRows[0].Cells["ID"].Value);
            if (MessageBox.Show("Silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var k = db.Tbl_Cozumler.Find(id);
                if (k != null) { db.Tbl_Cozumler.Remove(k); db.SaveChanges(); SonuclariListele(); }
            }
        }

        private void btnDetayGor_Click(object sender, EventArgs e)
        {
            if (dgvListe.SelectedRows.Count == 0) return;

            int cozumId = Convert.ToInt32(dgvListe.SelectedRows[0].Cells["ID"].Value);
            var dbCozum = db.Tbl_Cozumler.Find(cozumId);
            var dbDetaylar = db.Tbl_CozumDetaylari.Where(x => x.CozumID == cozumId).OrderBy(x => x.IstasyonNo).ThenBy(x => x.SiraNo).ToList();

            if (dbCozum == null) return;

            Kromozom gecmisCozum = new Kromozom();
            gecmisCozum.Fitness = dbCozum.Fitness ?? 0;
            gecmisCozum.HatVerimliligi = dbCozum.HatVerimliligi ?? 0;
            gecmisCozum.SI = dbCozum.PuruzsuzlukIndeksi ?? 0;
            gecmisCozum.IstasyonSayisi = dbCozum.IstasyonSayisi ?? 0;

            var istasyonGruplari = dbDetaylar.GroupBy(x => x.IstasyonNo);
            foreach (var grup in istasyonGruplari)
            {
                IstasyonModel ist = new IstasyonModel { IstasyonNo = grup.Key, AtananIsler = new List<IsModel>(), ToplamSure = 0 };
                foreach (var detay in grup)
                {
                    IsModel isParcasi = new IsModel { ID = detay.OperasyonID, Kod = detay.Tbl_Operasyonlar.OperasyonKodu, Tanim = detay.Tbl_Operasyonlar.Tanim, Sure = detay.Tbl_Operasyonlar.Sure };
                    ist.AtananIsler.Add(isParcasi);
                    ist.ToplamSure += isParcasi.Sure;
                }
                gecmisCozum.Istasyonlar.Add(ist);
            }
            gecmisCozum.GercekCevrimSuresi = gecmisCozum.Istasyonlar.Max(x => x.ToplamSure);

            FrmSonuclar frm = new FrmSonuclar();
            frm.Text = $"Geçmiş - {dbCozum.Tbl_Projeler.ProjeAdi}";
            frm.SonuclariGoster(gecmisCozum, dbCozum.ProjeID, dbCozum.HedefCevrimSuresi ?? 0, dbCozum.Tbl_Projeler.ProjeAdi);
            frm.ShowDialog();
        }

        private void btnTumunuExcel_Click(object sender, EventArgs e)
        {
            if (dgvListe.Rows.Count == 0) return;

            btnTumunuExcel.Text = "Aktarılıyor...";
            btnTumunuExcel.Enabled = false;

            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                excelApp = new Excel.Application();
                excelApp.Visible = false;
                workbook = excelApp.Workbooks.Add(Type.Missing);
                worksheet = (Excel.Worksheet)workbook.ActiveSheet;
                worksheet.Name = "Geçmiş Analizler";

                worksheet.Cells.Interior.Color = ColorTranslator.ToOle(Color.White);

                worksheet.Cells[2, 2] = "GEÇMİŞ HAT DENGELEME KAYITLARI";
                Excel.Range titleRange = worksheet.Range["B2", "I2"];
                titleRange.Merge();
                titleRange.Font.Size = 20;
                titleRange.Font.Bold = true;
                titleRange.Font.Color = ColorTranslator.ToOle(Color.FromArgb(32, 32, 32));

                int headerRow = 5;
                for (int i = 0; i < dgvListe.Columns.Count; i++)
                {
                    worksheet.Cells[headerRow, i + 2] = dgvListe.Columns[i].HeaderText;
                }

                Excel.Range headerRange = worksheet.Range[worksheet.Cells[headerRow, 2], worksheet.Cells[headerRow, dgvListe.Columns.Count + 1]];
                headerRange.Font.Bold = true;
                headerRange.Interior.Color = ColorTranslator.ToOle(Color.FromArgb(52, 58, 64));
                headerRange.Font.Color = ColorTranslator.ToOle(Color.White);
                headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                int currentRow = headerRow + 1;
                for (int i = 0; i < dgvListe.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvListe.Columns.Count; j++)
                    {
                        var cellValue = dgvListe.Rows[i].Cells[j].Value;
                        worksheet.Cells[currentRow, j + 2] = cellValue;
                    }
                    currentRow++;
                }

                worksheet.Columns.AutoFit();
                worksheet.Columns[1].ColumnWidth = 2;

                excelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (worksheet != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                if (workbook != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                if (excelApp != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                btnTumunuExcel.Text = "LİSTEYİ EXCEL'E AKTAR";
                btnTumunuExcel.Enabled = true;
            }
        }
    }
}