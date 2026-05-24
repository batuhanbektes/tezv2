using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Tezv2
{
    public partial class FrmOnculDiyagrami : Form
    {
        DbHatDengelemeKDSEntities db = new DbHatDengelemeKDSEntities();

        private int nodeWidth = 80;
        private int nodeHeight = 50;
        private int horizontalGap = 100;
        private int verticalGap = 80;

        private List<NodeGorsel> cizilecekDugumler = new List<NodeGorsel>();
        private List<IliskiGorsel> cizilecekIliskiler = new List<IliskiGorsel>();

        // Zoom değişkenleri
        private float zoomFactor = 1.0f;
        private float minZoom = 0.25f;
        private float maxZoom = 3.0f;
        private Size originalCanvasSize = Size.Empty;

        public FrmOnculDiyagrami()
        {
            InitializeComponent();
        }

        private void FrmOnculDiyagrami_Load(object sender, EventArgs e)
        {
            HatlariYukle();
            pnlCanvas.AutoScroll = true;
            pbCanvas.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        void HatlariYukle()
        {
            var hatlar = db.Tbl_Projeler.Select(x => new { x.ProjeID, x.ProjeAdi }).ToList();
            cmbHat.DataSource = hatlar;
            cmbHat.DisplayMember = "ProjeAdi";
            cmbHat.ValueMember = "ProjeID";
            cmbHat.SelectedIndex = -1;
        }

        public void HattiOtomatikSec(int hatId, bool kitle = false)
        {
            if (cmbHat.DataSource == null) HatlariYukle();

            cmbHat.SelectedValue = hatId;

            if (kitle)
            {
                cmbHat.Enabled = false;
            }
            else
            {
                cmbHat.Enabled = true;
            }
        }

        private void cmbHat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHat.SelectedValue == null) return;
            if (!int.TryParse(cmbHat.SelectedValue.ToString(), out int hatId)) return;

            VerileriHazirla(hatId);
            // Zoom sıfırla
            zoomFactor = 1.0f;
            originalCanvasSize = Size.Empty;
            lblZoomOran.Text = "%100";
            pbCanvas.Invalidate();
        }

        private void VerileriHazirla(int hatId)
        {
            cizilecekDugumler.Clear();
            cizilecekIliskiler.Clear();

            // 1. Veritabanından Çek
            var operasyonlar = db.Tbl_Operasyonlar.Where(x => x.ProjeID == hatId).ToList();
            var iliskiler = db.Tbl_Oncelikler.Where(x => x.Tbl_Operasyonlar.ProjeID == hatId).ToList();

            if (operasyonlar.Count == 0) return;

            // 2. Seviye Hesabı
            // Level 0: Hiç öncülü olmayanlar.
            // Level 1: Öncülü Level 0 olanlar...

            Dictionary<int, int> opLevel = new Dictionary<int, int>();
            foreach (var op in operasyonlar) opLevel[op.OperasyonID] = 0;

            // Maksimum 50 tur (sonsuz döngü koruması)
            for (int i = 0; i < operasyonlar.Count + 2; i++)
            {
                foreach (var iliski in iliskiler)
                {
                    int onculLevel = opLevel[iliski.OnculOperasyonID];
                    int anaLevel = opLevel[iliski.OperasyonID];

                    if (onculLevel + 1 > anaLevel)
                    {
                        opLevel[iliski.OperasyonID] = onculLevel + 1;
                    }
                }
            }

            // 3. Koordinatları Belirle
            // Her levelde kaç kişi var sayacı
            Dictionary<int, int> levelCount = new Dictionary<int, int>();

            foreach (var op in operasyonlar.OrderBy(x => x.OperasyonKodu))
            {
                int myLevel = opLevel[op.OperasyonID];

                if (!levelCount.ContainsKey(myLevel)) levelCount[myLevel] = 0;
                int myRow = levelCount[myLevel];
                levelCount[myLevel]++;

                // Koordinat Hesapla
                int x = 50 + (myLevel * (nodeWidth + horizontalGap));
                int y = 50 + (myRow * (nodeHeight + verticalGap));

                cizilecekDugumler.Add(new NodeGorsel
                {
                    ID = op.OperasyonID,
                    Text = $"{op.OperasyonKodu}\n({op.Sure} sn)",
                    Rect = new Rectangle(x, y, nodeWidth, nodeHeight)
                });
            }

            // 4. İlişkileri Koordinatlara Bağla
            foreach (var iliski in iliskiler)
            {
                var baslangic = cizilecekDugumler.FirstOrDefault(n => n.ID == iliski.OnculOperasyonID);
                var bitis = cizilecekDugumler.FirstOrDefault(n => n.ID == iliski.OperasyonID);

                if (baslangic != null && bitis != null)
                {
                    cizilecekIliskiler.Add(new IliskiGorsel
                    {
                        StartPoint = new Point(baslangic.Rect.Right, baslangic.Rect.Top + baslangic.Rect.Height / 2),
                        EndPoint = new Point(bitis.Rect.Left, bitis.Rect.Top + bitis.Rect.Height / 2)
                    });
                }
            }

            // Canvas boyutunu ayarla (zoom uygulanmadan orijinal boyut)
            int maxX = cizilecekDugumler.Max(n => n.Rect.Right) + 50;
            int maxY = cizilecekDugumler.Max(n => n.Rect.Bottom) + 50;
            originalCanvasSize = new Size(Math.Max(maxX, pnlCanvas.Width), Math.Max(maxY, pnlCanvas.Height));
            ApplyZoom();
        }

        // Zoom işlemleri
        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            if (zoomFactor < maxZoom)
            {
                zoomFactor += 0.1f;
                ApplyZoom();
            }
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            if (zoomFactor > minZoom)
            {
                zoomFactor -= 0.1f;
                ApplyZoom();
            }
        }

        private void btnZoomReset_Click(object sender, EventArgs e)
        {
            zoomFactor = 1.0f;
            ApplyZoom();
        }

        private void ApplyZoom()
        {
            // Zoom oranını göster
            lblZoomOran.Text = $"{(int)(zoomFactor * 100)}%";

            // PictureBox'ı zoom ile yeniden boyutlandır
            if (originalCanvasSize != Size.Empty)
            {
                int newWidth = (int)(originalCanvasSize.Width * zoomFactor);
                int newHeight = (int)(originalCanvasSize.Height * zoomFactor);
                pbCanvas.Size = new Size(newWidth, newHeight);
            }

            // Yeniden çizimi tetikle
            pbCanvas.Invalidate();
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            // Zoom transformasyonu uygula
            e.Graphics.ScaleTransform(zoomFactor, zoomFactor);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Ok Kalemi
            Pen okKalemi = new Pen(Color.DimGray, 2);
            okKalemi.CustomEndCap = new AdjustableArrowCap(5, 5);

            // İlişkileri Çizme
            foreach (var rel in cizilecekIliskiler)
            {
                // Bezier eğrisi ile yumuşak geçiş
                int ortaX = (rel.StartPoint.X + rel.EndPoint.X) / 2;
                Point p1 = new Point(ortaX, rel.StartPoint.Y);
                Point p2 = new Point(ortaX, rel.EndPoint.Y);

                e.Graphics.DrawBezier(okKalemi, rel.StartPoint, p1, p2, rel.EndPoint);
            }

            // Düğümleri Çiz (Kutular)
            foreach (var node in cizilecekDugumler)
            {
                // Kutu
                e.Graphics.FillRectangle(Brushes.White, node.Rect);
                e.Graphics.DrawRectangle(Pens.SteelBlue, node.Rect);

                // Yazı
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString(node.Text, this.Font, Brushes.Black, node.Rect, sf);
            }
        }

        class NodeGorsel
        {
            public int ID { get; set; }
            public string Text { get; set; }
            public Rectangle Rect { get; set; }
        }

        class IliskiGorsel
        {
            public Point StartPoint { get; set; }
            public Point EndPoint { get; set; }
        }
    }
}