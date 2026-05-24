using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tezv2.Models;
using Excel = Microsoft.Office.Interop.Excel;

namespace Tezv2
{
    public partial class FrmSonuclar : Form
    {
        private Kromozom _aktifCozum;
        private double _hedefSure;
        private string _hatAdi;
        private int _hatId;

        public FrmSonuclar()
        {
            InitializeComponent();
        }

        public void SonuclariGoster(Kromozom cozum, int hatId, double hedefSure, string hatAdi)
        {
            _aktifCozum = cozum;
            _hedefSure = hedefSure;
            _hatAdi = hatAdi;
            _hatId = hatId;

            string baslikBilgisi = "";
            if (GenetikAyarlar.IterasyonSinirli)
                baslikBilgisi = $"İterasyon: {GenetikAyarlar.IterasyonSayisi}";
            else
                baslikBilgisi = $"Hesaplama: {GenetikAyarlar.UygunlukHesaplamaLimiti}";

            this.Text = $"Sonuçlar - {baslikBilgisi} | Pop: {GenetikAyarlar.PopulasyonBuyuklugu} | {hatAdi}";

            lblIstasyonVal.Text = cozum.IstasyonSayisi.ToString() + " Adet";
            lblHedefCVal.Text = hedefSure.ToString("F2") + " sn";

            lblGercekCVal.Text = cozum.GercekCevrimSuresi.ToString("F2") + " sn";
            if (cozum.GercekCevrimSuresi > hedefSure) lblGercekCVal.ForeColor = Color.Crimson;
            else lblGercekCVal.ForeColor = Color.Black;

            lblVerimVal.Text = "%" + cozum.HatVerimliligi.ToString("F3");
            lblSIVal.Text = cozum.SI.ToString("F3");
            lblFitnessVal.Text = cozum.Fitness.ToString("F3");
            lblFitnessVal.ForeColor = Color.DarkOrange;

            dgvSonuclar.Rows.Clear();
            dgvSonuclar.Columns.Clear();
            dgvSonuclar.Columns.Add("No", "İstasyon");
            dgvSonuclar.Columns.Add("Isler", "Atanan İşler");
            dgvSonuclar.Columns.Add("Sure", "Toplam Süre");
            dgvSonuclar.Columns.Add("Bos", "Boş Süre");
            dgvSonuclar.Columns.Add("Verim", "Verimlilik");

            dgvSonuclar.Columns[0].Width = 60;
            dgvSonuclar.Columns[1].Width = 300;

            foreach (var ist in cozum.Istasyonlar)
            {
                string isler = string.Join(", ", ist.AtananIsler.Select(x => x.Kod));

                double referans = Math.Max(cozum.GercekCevrimSuresi, hedefSure);
                double hesaplananBosSure = Math.Max(0, referans - ist.ToplamSure);

                double istVerim = (referans == 0) ? 0 : (ist.ToplamSure / referans) * 100;

                int satirIndex = dgvSonuclar.Rows.Add(
                    ist.IstasyonNo,
                    isler,
                    ist.ToplamSure.ToString("F2"),
                    hesaplananBosSure.ToString("F2"),
                    "%" + istVerim.ToString("F1")
                );

                if (ist.ToplamSure > hedefSure)
                    dgvSonuclar.Rows[satirIndex].DefaultCellStyle.BackColor = Color.MistyRose;
                else if (istVerim < 70)
                    dgvSonuclar.Rows[satirIndex].DefaultCellStyle.BackColor = Color.LightYellow;
            }
            dgvSonuclar.ClearSelection();

            CizGrafik(cozum, hedefSure);
        }

        private void CizGrafik(Kromozom cozum, double hedefSure)
        {
            chartYukDagitimi.Series.Clear();
            Series seri = new Series("İstasyon Yükü");
            seri.ChartType = SeriesChartType.Column;
            seri.Color = Color.SteelBlue;

            foreach (var ist in cozum.Istasyonlar)
            {
                DataPoint nokta = new DataPoint();
                nokta.AxisLabel = "İst " + ist.IstasyonNo;
                nokta.YValues = new double[] { ist.ToplamSure };

                if (ist.ToplamSure > hedefSure) nokta.Color = Color.Crimson;
                seri.Points.Add(nokta);
            }

            chartYukDagitimi.Series.Add(seri);
            chartYukDagitimi.ChartAreas[0].AxisY.StripLines.Clear();
            StripLine hedefCizgi = new StripLine();
            hedefCizgi.Interval = 0;
            hedefCizgi.IntervalOffset = hedefSure;
            hedefCizgi.StripWidth = 0.5;
            hedefCizgi.BackColor = Color.Red;
            hedefCizgi.BorderDashStyle = ChartDashStyle.Dash;
            hedefCizgi.Text = $"Hedef: {hedefSure}";
            hedefCizgi.ForeColor = Color.Red;
            chartYukDagitimi.ChartAreas[0].AxisY.StripLines.Add(hedefCizgi);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDiyagram_Click(object sender, EventArgs e)
        {
            FrmOnculDiyagrami frm = new FrmOnculDiyagrami();
            frm.HattiOtomatikSec(_hatId, true);
            frm.ShowDialog();
        }

        // EXCEL RAPORLAMA
        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (_aktifCozum == null) return;

            btnExcel.Text = "Rapor Hazırlanıyor...";
            btnExcel.Enabled = false;

            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet dashboardSheet = null;
            Excel.Worksheet detailSheet = null;

            try
            {
                excelApp = new Excel.Application();
                excelApp.Visible = false;
                excelApp.DisplayAlerts = false;

                workbook = excelApp.Workbooks.Add(Type.Missing);

                // 1. DASHBOARD
                dashboardSheet = (Excel.Worksheet)workbook.ActiveSheet;
                dashboardSheet.Name = "Dashboard";
                dashboardSheet.Cells.Interior.Color = ColorTranslator.ToOle(Color.White);

                Excel.Range allCells = dashboardSheet.Cells;
                allCells.Font.Name = "Segoe UI";
                allCells.Font.Color = ColorTranslator.ToOle(Color.FromArgb(64, 64, 64));

                // Başlık
                dashboardSheet.Cells[2, 2] = "HAT DENGELEME ANALİZ RAPORU";
                Excel.Range titleRange = dashboardSheet.Range["B2", "H2"];
                titleRange.Font.Size = 24;
                titleRange.Font.Bold = true;
                titleRange.Font.Color = ColorTranslator.ToOle(Color.FromArgb(32, 32, 32));

                dashboardSheet.Cells[3, 2] = $"Hat: {_hatAdi} | Rapor Tarihi: {DateTime.Now.ToString("g")}";
                dashboardSheet.Range["B3"].Font.Color = ColorTranslator.ToOle(Color.DimGray);

                // KPI
                DrawCard(dashboardSheet, 5, 2, "Hat Verimliliği", $"%{_aktifCozum.HatVerimliligi:F3}",
                         Color.FromArgb(232, 245, 233), Color.FromArgb(46, 125, 50));
                DrawCard(dashboardSheet, 5, 4, "Fitness Skoru", $"{_aktifCozum.Fitness:F3}",
                         Color.FromArgb(255, 248, 225), Color.FromArgb(255, 143, 0));
                DrawCard(dashboardSheet, 5, 6, "İstasyon Sayısı", $"{_aktifCozum.IstasyonSayisi}",
                         Color.FromArgb(227, 242, 253), Color.FromArgb(21, 101, 192));
                DrawCard(dashboardSheet, 5, 8, "Gerçek Çevrim", $"{_aktifCozum.GercekCevrimSuresi:F1}s",
                         Color.FromArgb(255, 243, 224), Color.FromArgb(239, 108, 0));

                // Parametre Tablosu
                int paramStartRow = 9;
                dashboardSheet.Cells[paramStartRow, 2] = "ALGORİTMA PARAMETRELERİ";
                dashboardSheet.Range[$"B{paramStartRow}"].Font.Bold = true;
                dashboardSheet.Range[$"B{paramStartRow}"].Font.Size = 12;
                dashboardSheet.Range[$"B{paramStartRow}"].Font.Color = ColorTranslator.ToOle(Color.DarkSlateGray);

                string durdurmaBilgisi = GenetikAyarlar.IterasyonSinirli
                    ? $"{GenetikAyarlar.IterasyonSayisi} İterasyon"
                    : $"{GenetikAyarlar.UygunlukHesaplamaLimiti} Uygunluk Hesabı";

                string[,] paramsData = {
                    { "Hedef Çevrim Süresi", _hedefSure.ToString() + " sn" },
                    { "Popülasyon Büyüklüğü", GenetikAyarlar.PopulasyonBuyuklugu.ToString() },
                    { "Durdurma Kriteri", durdurmaBilgisi },
                    { "Çaprazlama Oranı", "%" + GenetikAyarlar.CaprazlamaOrani.ToString() },
                    { "Mutasyon Oranı", "%" + GenetikAyarlar.MutasyonOrani.ToString() },
                    { "Algoritma Türü", "Genetik Algoritma" }
                };

                int pRow = paramStartRow + 1;
                for (int i = 0; i < paramsData.GetLength(0); i++)
                {
                    dashboardSheet.Cells[pRow, 2] = paramsData[i, 0];
                    Excel.Range labelCell = dashboardSheet.Cells[pRow, 2];
                    labelCell.Font.Bold = true;
                    labelCell.Interior.Color = ColorTranslator.ToOle(Color.FromArgb(248, 249, 250));
                    labelCell.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    labelCell.Borders.Color = ColorTranslator.ToOle(Color.LightGray);

                    dashboardSheet.Cells[pRow, 3] = paramsData[i, 1];
                    Excel.Range valCell = dashboardSheet.Cells[pRow, 3];
                    valCell.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                    valCell.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    valCell.Borders.Color = ColorTranslator.ToOle(Color.LightGray);
                    pRow++;
                }

                // Grafik
                int dataRow = 1;
                dashboardSheet.Cells[dataRow, 27] = "İstasyon";
                dashboardSheet.Cells[dataRow, 28] = "Yük";
                dashboardSheet.Cells[dataRow, 29] = "Hedef";

                foreach (var ist in _aktifCozum.Istasyonlar)
                {
                    dataRow++;
                    dashboardSheet.Cells[dataRow, 27] = "İst " + ist.IstasyonNo;
                    dashboardSheet.Cells[dataRow, 28] = ist.ToplamSure;
                    dashboardSheet.Cells[dataRow, 29] = _hedefSure;
                }

                Excel.Range chartDataRange = dashboardSheet.Range[$"AA1:AC{dataRow}"];
                Excel.ChartObjects charts = (Excel.ChartObjects)dashboardSheet.ChartObjects(Type.Missing);
                Excel.ChartObject chartObj = charts.Add(320, 150, 500, 220);
                Excel.Chart chart = chartObj.Chart;

                chart.SetSourceData(chartDataRange);
                chart.ChartType = Excel.XlChartType.xlColumnClustered;
                chart.HasTitle = true;
                chart.ChartTitle.Text = "İstasyon Yükleri & Hedef Çizgisi";

                Excel.Series targetSeries = (Excel.Series)chart.SeriesCollection(2);
                targetSeries.ChartType = Excel.XlChartType.xlLine;
                targetSeries.Format.Line.ForeColor.RGB = ColorTranslator.ToOle(Color.Crimson);
                targetSeries.Name = "Hedef Süre";

                Excel.Series loadSeries = (Excel.Series)chart.SeriesCollection(1);
                loadSeries.Format.Fill.ForeColor.RGB = ColorTranslator.ToOle(Color.FromArgb(33, 150, 243));
                loadSeries.Name = "İstasyon Yükü";

                chart.ChartArea.Format.Fill.ForeColor.RGB = ColorTranslator.ToOle(Color.White);
                chart.PlotArea.Format.Fill.ForeColor.RGB = ColorTranslator.ToOle(Color.White);

                // İstasyon Özeti
                int ozetStartRow = 20;
                dashboardSheet.Cells[ozetStartRow, 2] = "İSTASYON PERFORMANS ÖZETİ";
                dashboardSheet.Range[$"B{ozetStartRow}"].Font.Bold = true;
                dashboardSheet.Range[$"B{ozetStartRow}"].Font.Size = 14;
                dashboardSheet.Range[$"B{ozetStartRow}"].Font.Color = ColorTranslator.ToOle(Color.DarkSlateBlue);

                int tableRow = ozetStartRow + 2;
                string[] headers = { "İstasyon", "İş Sayısı", "Toplam Süre (sn)", "Boş Süre (sn)", "Doluluk Oranı" };

                for (int i = 0; i < headers.Length; i++)
                {
                    dashboardSheet.Cells[tableRow, i + 2] = headers[i];
                    Excel.Range cell = dashboardSheet.Cells[tableRow, i + 2];
                    cell.Interior.Color = ColorTranslator.ToOle(Color.FromArgb(52, 58, 64));
                    cell.Font.Color = ColorTranslator.ToOle(Color.White);
                    cell.Font.Bold = true;
                    cell.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                }

                tableRow++;
                foreach (var ist in _aktifCozum.Istasyonlar)
                {
                    // HESAPLAMA
                    double kapasite = Math.Max(_hedefSure, _aktifCozum.GercekCevrimSuresi);
                    double bosSure = Math.Max(0, kapasite - ist.ToplamSure);
                    double dolulukOrani = (kapasite == 0) ? 0 : (ist.ToplamSure / kapasite);

                    dashboardSheet.Cells[tableRow, 2] = ist.IstasyonNo;
                    dashboardSheet.Cells[tableRow, 3] = ist.AtananIsler.Count;
                    dashboardSheet.Cells[tableRow, 4] = ist.ToplamSure;
                    dashboardSheet.Cells[tableRow, 5] = bosSure;
                    dashboardSheet.Cells[tableRow, 6] = dolulukOrani;

                    dashboardSheet.Cells[tableRow, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    dashboardSheet.Cells[tableRow, 3].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    dashboardSheet.Range[$"F{tableRow}"].NumberFormat = "0.0%";

                    Excel.Range rowRange = dashboardSheet.Range[dashboardSheet.Cells[tableRow, 2], dashboardSheet.Cells[tableRow, 6]];
                    rowRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    rowRange.Borders.Color = ColorTranslator.ToOle(Color.LightGray);
                    tableRow++;
                }

                dashboardSheet.Columns[1].ColumnWidth = 2;
                dashboardSheet.Columns[2].ColumnWidth = 22;
                dashboardSheet.Columns[3].ColumnWidth = 18;
                dashboardSheet.Columns[4].ColumnWidth = 18;
                dashboardSheet.Columns[5].ColumnWidth = 18;
                dashboardSheet.Columns[6].ColumnWidth = 18;

                // 2. DETAY SAYFASI
                detailSheet = (Excel.Worksheet)workbook.Worksheets.Add(After: dashboardSheet);
                detailSheet.Name = "İstasyon Detayları";
                detailSheet.Cells.Interior.Color = ColorTranslator.ToOle(Color.White);

                int detRow = 2;
                detailSheet.Cells[detRow, 2] = "İSTASYON BAZLI DETAYLI İŞ PLANI";
                detailSheet.Range["B2"].Font.Size = 20;
                detailSheet.Range["B2"].Font.Bold = true;
                detRow += 2;

                foreach (var ist in _aktifCozum.Istasyonlar)
                {
                    string headerText = $"İstasyon {ist.IstasyonNo}  |  Yük: {ist.ToplamSure} sn";
                    Excel.Range stHeader = detailSheet.Range[detailSheet.Cells[detRow, 2], detailSheet.Cells[detRow, 4]];
                    stHeader.Merge();
                    stHeader.Value = headerText;
                    stHeader.Font.Bold = true;
                    stHeader.Font.Color = ColorTranslator.ToOle(Color.White);
                    stHeader.Interior.Color = ColorTranslator.ToOle(Color.FromArgb(55, 71, 79));
                    stHeader.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                    stHeader.RowHeight = 25;
                    detRow++;

                    detailSheet.Cells[detRow, 2] = "İş Kodu";
                    detailSheet.Cells[detRow, 3] = "İş Tanımı";
                    detailSheet.Cells[detRow, 4] = "Süre (sn)";

                    Excel.Range colHeaders = detailSheet.Range[detailSheet.Cells[detRow, 2], detailSheet.Cells[detRow, 4]];
                    colHeaders.Font.Bold = true;
                    colHeaders.Interior.Color = ColorTranslator.ToOle(Color.FromArgb(236, 239, 241));
                    colHeaders.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                    detRow++;

                    foreach (var isParcasi in ist.AtananIsler)
                    {
                        detailSheet.Cells[detRow, 2] = isParcasi.Kod;
                        detailSheet.Cells[detRow, 3] = isParcasi.Tanim;
                        detailSheet.Cells[detRow, 4] = isParcasi.Sure;

                        Excel.Range rowRange = detailSheet.Range[detailSheet.Cells[detRow, 2], detailSheet.Cells[detRow, 4]];
                        rowRange.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                        rowRange.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = ColorTranslator.ToOle(Color.LightGray);
                        detRow++;
                    }
                    detRow += 2;
                }

                detailSheet.Columns[1].ColumnWidth = 2;
                detailSheet.Columns[2].ColumnWidth = 15;
                detailSheet.Columns[3].ColumnWidth = 50;
                detailSheet.Columns[4].ColumnWidth = 15;

                dashboardSheet.Activate();

                string masaustuYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string dosyaAdi = $"HatDengeleme_Rapor_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                string tamYol = System.IO.Path.Combine(masaustuYolu, dosyaAdi);

                workbook.SaveAs(tamYol);
                excelApp.Visible = true;

                MessageBox.Show("Rapor masaüstüne kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excel Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (detailSheet != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(detailSheet);
                if (dashboardSheet != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(dashboardSheet);
                if (workbook != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                if (excelApp != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                btnExcel.Text = "EXCEL'E AKTAR";
                btnExcel.Enabled = true;
            }
        }

        private void DrawCard(Excel.Worksheet sheet, int row, int col, string title, string value, Color bgColor, Color textColor)
        {
            Excel.Range cardRange = sheet.Range[sheet.Cells[row, col], sheet.Cells[row + 2, col + 1]];
            cardRange.Merge();
            cardRange.Interior.Color = ColorTranslator.ToOle(bgColor);
            cardRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            cardRange.Borders.Color = ColorTranslator.ToOle(Color.White);
            cardRange.Borders.Weight = Excel.XlBorderWeight.xlThick;

            sheet.Cells[row, col] = title + "\n" + value;
            cardRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            cardRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

            Excel.Characters titleChars = cardRange.get_Characters(1, title.Length);
            titleChars.Font.Size = 10;
            titleChars.Font.Color = ColorTranslator.ToOle(Color.Gray);
            titleChars.Font.Bold = true;

            Excel.Characters valChars = cardRange.get_Characters(title.Length + 2, value.Length);
            valChars.Font.Size = 18;
            valChars.Font.Color = ColorTranslator.ToOle(textColor);
            valChars.Font.Bold = true;
        }
    }
}