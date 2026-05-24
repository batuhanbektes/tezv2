using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tezv2.Algoritma;
using Tezv2.Models;

namespace Tezv2
{
    public partial class FrmHatDengeleme : Form
    {
        DbHatDengelemeKDSEntities db = new DbHatDengelemeKDSEntities();
        private bool _yukleniyor = true;

        public FrmHatDengeleme()
        {
            InitializeComponent();
        }

        private void FrmHatDengeleme_Load(object sender, EventArgs e)
        {
            HatlariDoldur();
            AyarlariYukle();
            OlaylariBagla();

            lblUyari.Text = "Lütfen analiz edilecek hattı seçiniz.";
            lblUyari.ForeColor = Color.DimGray;

            _yukleniyor = false;
        }

        private void AyarlariYukle()
        {
            numPopulasyon.Value = GenetikAyarlar.PopulasyonBuyuklugu;
            if (GenetikAyarlar.IterasyonSinirli) rdbIterasyon.Checked = true; else rdbUygunluk.Checked = true;
            numIterasyon.Value = GenetikAyarlar.IterasyonSayisi;
            numUygunlukLimiti.Value = GenetikAyarlar.UygunlukHesaplamaLimiti;

            numMutasyonOran.Value = (decimal)GenetikAyarlar.MutasyonOrani;
            trkMutasyon.Value = (int)GenetikAyarlar.MutasyonOrani;
            numCaprazlamaOran.Value = (decimal)GenetikAyarlar.CaprazlamaOrani;
            trkCaprazlama.Value = (int)GenetikAyarlar.CaprazlamaOrani;
            numTurnuvaBoyutu.Value = (int)GenetikAyarlar.TurnuvaBoyutu;
            KutucuklariAyarla();
        }

        private void OlaylariBagla()
        {
            rdbIterasyon.CheckedChanged += (s, e) => KutucuklariAyarla();
            rdbUygunluk.CheckedChanged += (s, e) => KutucuklariAyarla();

            trkMutasyon.Scroll += (s, e) => { if (!_yukleniyor) numMutasyonOran.Value = trkMutasyon.Value; };
            numMutasyonOran.ValueChanged += (s, e) => { if (!_yukleniyor) trkMutasyon.Value = (int)numMutasyonOran.Value; };
            trkCaprazlama.Scroll += (s, e) => { if (!_yukleniyor) numCaprazlamaOran.Value = trkCaprazlama.Value; };
            numCaprazlamaOran.ValueChanged += (s, e) => { if (!_yukleniyor) trkCaprazlama.Value = (int)numCaprazlamaOran.Value; };

            chkAdaptif.CheckedChanged += (s, e) =>
            {
                if (chkAdaptif.Checked)
                {
                    lblMutasyon.Text = "Başlangıç Mutasyon Oranı (%):";
                    lblCaprazlama.Text = "Başlangıç Çaprazlama Oranı (%):";
                }
                else
                {
                    lblMutasyon.Text = "Mutasyon Oranı (%):";
                    lblCaprazlama.Text = "Çaprazlama Oranı (%):";
                }
            };
        }

        private void KutucuklariAyarla()
        {
            numIterasyon.Enabled = rdbIterasyon.Checked;
            numUygunlukLimiti.Enabled = !rdbIterasyon.Checked;
        }

        void HatlariDoldur()
        {
            var hatlar = db.Tbl_Projeler.Select(x => new { x.ProjeID, x.ProjeAdi }).ToList();
            cmbHat.DataSource = hatlar;
            cmbHat.DisplayMember = "ProjeAdi";
            cmbHat.ValueMember = "ProjeID";
            cmbHat.SelectedIndex = -1;
        }

        private void cmbHat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHat.SelectedIndex == -1 || cmbHat.SelectedValue == null) return;

            if (int.TryParse(cmbHat.SelectedValue.ToString(), out int hatId))
            {
                using (var localDb = new DbHatDengelemeKDSEntities())
                {
                    int operasyonSayisi = localDb.Tbl_Operasyonlar.Count(x => x.ProjeID == hatId);
                    lblUyari.Text = $"✔ Hat Başarıyla Seçildi.\nToplam Operasyon Sayısı: {operasyonSayisi}";
                    lblUyari.ForeColor = Color.SeaGreen;
                }
            }
        }

        // --- HESAPLAMA BUTONU ---
        private async void btnHesapla_Click(object sender, EventArgs e)
        {
            if (cmbHat.SelectedValue == null) { MessageBox.Show("Lütfen bir Hat seçiniz."); return; }

            // Ayarları Kaydet
            GenetikAyarlar.PopulasyonBuyuklugu = (int)numPopulasyon.Value;
            GenetikAyarlar.TurnuvaBoyutu = (int)numTurnuvaBoyutu.Value;
            GenetikAyarlar.IterasyonSinirli = rdbIterasyon.Checked;
            GenetikAyarlar.IterasyonSayisi = (int)numIterasyon.Value;
            GenetikAyarlar.UygunlukHesaplamaLimiti = (int)numUygunlukLimiti.Value;
            GenetikAyarlar.MutasyonOrani = (double)numMutasyonOran.Value;
            GenetikAyarlar.CaprazlamaOrani = (double)numCaprazlamaOran.Value;
            GenetikAyarlar.AdaptifParametre = chkAdaptif.Checked;

            btnHesapla.Enabled = false;
            btnHesapla.Text = "Hesaplanıyor...";

            // Grafik Başlıkları ve Progress Bar
            int toplamAdim = GenetikAyarlar.IterasyonSinirli ? GenetikAyarlar.IterasyonSayisi : GenetikAyarlar.UygunlukHesaplamaLimiti;
            prgIlerleme.Value = 0;

            lblAnlikMutasyon.Text = "Anlık Mutasyon: -";
            lblAnlikCaprazlama.Text = "Anlık Çaprazlama: -";
            lblAnlikMutasyon.Visible = true;
            lblAnlikCaprazlama.Visible = true;

            prgIlerleme.Maximum = toplamAdim;
            int raporlamaAraligi = Math.Max(1, toplamAdim / 100);

            chartFitness.Series[0].Points.Clear();
            if (GenetikAyarlar.IterasyonSinirli)
                chartFitness.ChartAreas[0].AxisX.Title = "İterasyon Sayısı";
            else
                chartFitness.ChartAreas[0].AxisX.Title = "Uygunluk Hesaplama Sayısı (Evaluation)";

            int hatId = (int)cmbHat.SelectedValue;
            double hedefSure = (double)numHedefSure.Value;
            string hatAdi = cmbHat.Text;
            int populasyonBuyuklugu = GenetikAyarlar.PopulasyonBuyuklugu;

            Stopwatch kronometre = new Stopwatch();
            kronometre.Start();

            // Verileri Çek
            List<IsModel> algoritmaIsleri = new List<IsModel>();
            using (var dbContext = new DbHatDengelemeKDSEntities())
            {
                var dbOperasyonlar = dbContext.Tbl_Operasyonlar.Where(x => x.ProjeID == hatId).ToList();
                if (dbOperasyonlar.Count == 0) { MessageBox.Show("Operasyon bulunamadı!"); btnHesapla.Enabled = true; return; }

                var dbOncelikler = dbContext.Tbl_Oncelikler.Where(x => x.Tbl_Operasyonlar.ProjeID == hatId).ToList();

                foreach (var op in dbOperasyonlar)
                {
                    algoritmaIsleri.Add(new IsModel { ID = op.OperasyonID, Kod = op.OperasyonKodu, Tanim = op.Tanim, Sure = op.Sure });
                }

                foreach (var iliski in dbOncelikler)
                {
                    var anaIs = algoritmaIsleri.FirstOrDefault(x => x.ID == iliski.OperasyonID);
                    var onculIs = algoritmaIsleri.FirstOrDefault(x => x.ID == iliski.OnculOperasyonID);
                    if (anaIs != null && onculIs != null)
                    {
                        anaIs.OnculIDleri.Add(onculIs.ID);
                    }
                }
            }

            var enUzunIs = algoritmaIsleri.OrderByDescending(x => x.Sure).First();
            if (hedefSure < enUzunIs.Sure) { MessageBox.Show("Hedef süre en uzun işten kısa olamaz!"); btnHesapla.Enabled = true; btnHesapla.Text = "HESAPLA"; return; }

            int sonRaporlananX = 0;

            var ilerlemeRaporu = new Progress<IterasyonDurumu>(veri =>
            {
                int xDegeri = GenetikAyarlar.IterasyonSinirli ? veri.IterasyonNo : veri.HesaplamaSayisi;

                if (xDegeri <= prgIlerleme.Maximum)
                    prgIlerleme.Value = xDegeri;
                else
                    prgIlerleme.Value = prgIlerleme.Maximum;

                bool grafikCizimZamani = false;
                if (GenetikAyarlar.IterasyonSinirli)
                {
                    grafikCizimZamani = (xDegeri % raporlamaAraligi == 0 || xDegeri >= toplamAdim);
                }
                else
                {
                    grafikCizimZamani = (xDegeri - sonRaporlananX >= raporlamaAraligi || xDegeri >= toplamAdim);
                }

                if (grafikCizimZamani)
                {
                    sonRaporlananX = xDegeri;

                    chartFitness.Series[0].Points.AddXY(xDegeri, veri.EnIyiFitness);
                    lblGecenSure.Text = $"Geçen Süre: {kronometre.Elapsed:mm\\:ss\\.ff}";

                    lblAnlikMutasyon.Visible = true;
                    lblAnlikCaprazlama.Visible = true;
                    lblAnlikMutasyon.Text = $"Anlık Mutasyon: %{veri.AnlikMutasyonOrani:F2}";
                    lblAnlikCaprazlama.Text = $"Anlık Çaprazlama: %{veri.AnlikCaprazlamaOrani:F2}";

                    if (GenetikAyarlar.IterasyonSinirli)
                        this.Text = $"İterasyon: {veri.IterasyonNo} | En İyi Fitness: {veri.EnIyiFitness:F4}";
                    else
                        this.Text = $"Hesaplama: {veri.HesaplamaSayisi} | En İyi Fitness: {veri.EnIyiFitness:F4}";
                }
            });

            // Algoritmayı Çalıştır
            Kromozom sonuc = await Task.Run(() =>
            {
                GenetikIslemler algoritma = new GenetikIslemler(algoritmaIsleri, hedefSure, populasyonBuyuklugu,
                                                              GenetikAyarlar.CaprazlamaOrani, GenetikAyarlar.MutasyonOrani, GenetikAyarlar.TurnuvaBoyutu);
                return algoritma.Run(ilerlemeRaporu);
            });

            kronometre.Stop();
            btnHesapla.Enabled = true;
            btnHesapla.Text = "HESAPLA";
            lblGecenSure.Text = $"Toplam Süre: {kronometre.Elapsed:mm\\:ss\\.ff}";
            prgIlerleme.Value = prgIlerleme.Maximum;

            try
            {
                SonuclariVeritabaninaKaydet(sonuc, hatId, hedefSure,
                                          GenetikAyarlar.PopulasyonBuyuklugu,
                                          GenetikAyarlar.IterasyonSayisi,
                                          GenetikAyarlar.CaprazlamaOrani,
                                          GenetikAyarlar.MutasyonOrani,
                                          GenetikAyarlar.IterasyonSinirli,
                                          GenetikAyarlar.UygunlukHesaplamaLimiti);
            }
            catch (Exception ex) { MessageBox.Show("Kayıt Hatası: " + ex.Message); }

            FrmSonuclar frm = new FrmSonuclar();
            frm.SonuclariGoster(sonuc, hatId, hedefSure, hatAdi);
            frm.ShowDialog();
        }

        private void SonuclariVeritabaninaKaydet(Kromozom cozum, int hatId, double hedefSure, int pop, int iter,
                                                 double capraz, double mutasyon, bool iterasyonSinirli, int uygunlukLimit)
        {
            using (var dbKayit = new DbHatDengelemeKDSEntities())
            {
                Tbl_Cozumler yeniCozum = new Tbl_Cozumler
                {
                    ProjeID = hatId,
                    AlgoritmaAdi = "Genetik Algoritma (Hibrit)",
                    PopulasyonBuyuklugu = pop,
                    IterasyonSayisi = iter,
                    CaprazlamaOrani = capraz,
                    MutasyonOrani = mutasyon,
                    HedefCevrimSuresi = hedefSure,
                    HatVerimliligi = cozum.HatVerimliligi,
                    IstasyonSayisi = cozum.IstasyonSayisi,
                    PuruzsuzlukIndeksi = cozum.SI,
                    Fitness = cozum.Fitness,
                    CozumTarihi = DateTime.Now,
                    DurdurmaKriteri = iterasyonSinirli ? "İterasyon" : "Uygunluk",
                    UygunlukLimiti = uygunlukLimit
                };

                dbKayit.Tbl_Cozumler.Add(yeniCozum);
                dbKayit.SaveChanges();

                foreach (var ist in cozum.Istasyonlar)
                {
                    int sira = 1;
                    foreach (var isParcasi in ist.AtananIsler)
                    {
                        Tbl_CozumDetaylari detay = new Tbl_CozumDetaylari
                        {
                            CozumID = yeniCozum.CozumID,
                            IstasyonNo = ist.IstasyonNo,
                            OperasyonID = isParcasi.ID,
                            SiraNo = sira++,
                            IstasyonYuku = ist.ToplamSure
                        };
                        dbKayit.Tbl_CozumDetaylari.Add(detay);
                    }
                }
                dbKayit.SaveChanges();
            }
        }

        private void chkAdaptif_CheckedChanged(object sender, EventArgs e)
        {
            bool adaptif = chkAdaptif.Checked;
            trkMutasyon.Enabled = !adaptif;
            numMutasyonOran.Enabled = !adaptif;
            trkCaprazlama.Enabled = !adaptif;
            numCaprazlamaOran.Enabled = !adaptif;
        }
    }
}