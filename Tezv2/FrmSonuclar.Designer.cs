namespace Tezv2
{
    partial class FrmSonuclar
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.chartYukDagitimi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowKPI = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCardIstasyon = new System.Windows.Forms.Panel();
            this.lblIstasyonVal = new System.Windows.Forms.Label();
            this.lblIstasyonTitle = new System.Windows.Forms.Label();
            this.pnlCardHedefC = new System.Windows.Forms.Panel();
            this.lblHedefCVal = new System.Windows.Forms.Label();
            this.lblHedefCTitle = new System.Windows.Forms.Label();
            this.pnlCardGercekC = new System.Windows.Forms.Panel();
            this.lblGercekCVal = new System.Windows.Forms.Label();
            this.lblGercekCTitle = new System.Windows.Forms.Label();
            this.pnlCardVerim = new System.Windows.Forms.Panel();
            this.lblVerimVal = new System.Windows.Forms.Label();
            this.lblVerimTitle = new System.Windows.Forms.Label();
            this.pnlCardSI = new System.Windows.Forms.Panel();
            this.lblSIVal = new System.Windows.Forms.Label();
            this.lblSITitle = new System.Windows.Forms.Label();
            this.pnlCardFitness = new System.Windows.Forms.Panel();
            this.lblFitnessVal = new System.Windows.Forms.Label();
            this.lblFitnessTitle = new System.Windows.Forms.Label();
            this.grpDetay = new System.Windows.Forms.GroupBox();
            this.dgvSonuclar = new System.Windows.Forms.DataGridView();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnDiyagram = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartYukDagitimi)).BeginInit();
            this.flowKPI.SuspendLayout();
            this.pnlCardIstasyon.SuspendLayout();
            this.pnlCardHedefC.SuspendLayout();
            this.pnlCardGercekC.SuspendLayout();
            this.pnlCardVerim.SuspendLayout();
            this.pnlCardSI.SuspendLayout();
            this.pnlCardFitness.SuspendLayout();
            this.grpDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonuclar)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.chartYukDagitimi);
            this.pnlTop.Controls.Add(this.flowKPI);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1579, 320);
            this.pnlTop.TabIndex = 0;
            // 
            // chartYukDagitimi
            // 
            this.chartYukDagitimi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chartYukDagitimi.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.Title = "İstasyonlar";
            chartArea2.AxisY.Title = "Süre (sn)";
            chartArea2.BackColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chartYukDagitimi.ChartAreas.Add(chartArea2);
            this.chartYukDagitimi.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartYukDagitimi.Legends.Add(legend2);
            this.chartYukDagitimi.Location = new System.Drawing.Point(773, 0);
            this.chartYukDagitimi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartYukDagitimi.Name = "chartYukDagitimi";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.SteelBlue;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartYukDagitimi.Series.Add(series2);
            this.chartYukDagitimi.Size = new System.Drawing.Size(806, 320);
            this.chartYukDagitimi.TabIndex = 1;
            this.chartYukDagitimi.Text = "İstasyon Yük Dağılımı";
            // 
            // flowKPI
            // 
            this.flowKPI.AutoScroll = true;
            this.flowKPI.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowKPI.Controls.Add(this.pnlCardIstasyon);
            this.flowKPI.Controls.Add(this.pnlCardHedefC);
            this.flowKPI.Controls.Add(this.pnlCardGercekC);
            this.flowKPI.Controls.Add(this.pnlCardVerim);
            this.flowKPI.Controls.Add(this.pnlCardSI);
            this.flowKPI.Controls.Add(this.pnlCardFitness);
            this.flowKPI.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowKPI.Location = new System.Drawing.Point(0, 0);
            this.flowKPI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowKPI.Name = "flowKPI";
            this.flowKPI.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.flowKPI.Size = new System.Drawing.Size(773, 320);
            this.flowKPI.TabIndex = 0;
            // 
            // pnlCardIstasyon
            // 
            this.pnlCardIstasyon.BackColor = System.Drawing.Color.White;
            this.pnlCardIstasyon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardIstasyon.Controls.Add(this.lblIstasyonVal);
            this.pnlCardIstasyon.Controls.Add(this.lblIstasyonTitle);
            this.pnlCardIstasyon.Location = new System.Drawing.Point(17, 16);
            this.pnlCardIstasyon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCardIstasyon.Name = "pnlCardIstasyon";
            this.pnlCardIstasyon.Size = new System.Drawing.Size(226, 123);
            this.pnlCardIstasyon.TabIndex = 1;
            // 
            // lblIstasyonVal
            // 
            this.lblIstasyonVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIstasyonVal.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblIstasyonVal.Location = new System.Drawing.Point(0, 49);
            this.lblIstasyonVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIstasyonVal.Name = "lblIstasyonVal";
            this.lblIstasyonVal.Size = new System.Drawing.Size(224, 49);
            this.lblIstasyonVal.TabIndex = 1;
            this.lblIstasyonVal.Text = "- Adet";
            this.lblIstasyonVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIstasyonTitle
            // 
            this.lblIstasyonTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIstasyonTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIstasyonTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblIstasyonTitle.Location = new System.Drawing.Point(0, 0);
            this.lblIstasyonTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIstasyonTitle.Name = "lblIstasyonTitle";
            this.lblIstasyonTitle.Size = new System.Drawing.Size(224, 37);
            this.lblIstasyonTitle.TabIndex = 0;
            this.lblIstasyonTitle.Text = "İSTASYON SAYISI";
            this.lblIstasyonTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCardHedefC
            // 
            this.pnlCardHedefC.BackColor = System.Drawing.Color.White;
            this.pnlCardHedefC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardHedefC.Controls.Add(this.lblHedefCVal);
            this.pnlCardHedefC.Controls.Add(this.lblHedefCTitle);
            this.pnlCardHedefC.Location = new System.Drawing.Point(251, 16);
            this.pnlCardHedefC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCardHedefC.Name = "pnlCardHedefC";
            this.pnlCardHedefC.Size = new System.Drawing.Size(226, 123);
            this.pnlCardHedefC.TabIndex = 2;
            // 
            // lblHedefCVal
            // 
            this.lblHedefCVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHedefCVal.ForeColor = System.Drawing.Color.Black;
            this.lblHedefCVal.Location = new System.Drawing.Point(0, 49);
            this.lblHedefCVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHedefCVal.Name = "lblHedefCVal";
            this.lblHedefCVal.Size = new System.Drawing.Size(224, 49);
            this.lblHedefCVal.TabIndex = 1;
            this.lblHedefCVal.Text = "- sn";
            this.lblHedefCVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHedefCTitle
            // 
            this.lblHedefCTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHedefCTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHedefCTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblHedefCTitle.Location = new System.Drawing.Point(0, 0);
            this.lblHedefCTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHedefCTitle.Name = "lblHedefCTitle";
            this.lblHedefCTitle.Size = new System.Drawing.Size(224, 37);
            this.lblHedefCTitle.TabIndex = 0;
            this.lblHedefCTitle.Text = "HEDEF ÇEVRİM";
            this.lblHedefCTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCardGercekC
            // 
            this.pnlCardGercekC.BackColor = System.Drawing.Color.White;
            this.pnlCardGercekC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardGercekC.Controls.Add(this.lblGercekCVal);
            this.pnlCardGercekC.Controls.Add(this.lblGercekCTitle);
            this.pnlCardGercekC.Location = new System.Drawing.Point(485, 16);
            this.pnlCardGercekC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCardGercekC.Name = "pnlCardGercekC";
            this.pnlCardGercekC.Size = new System.Drawing.Size(226, 123);
            this.pnlCardGercekC.TabIndex = 3;
            // 
            // lblGercekCVal
            // 
            this.lblGercekCVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGercekCVal.ForeColor = System.Drawing.Color.Black;
            this.lblGercekCVal.Location = new System.Drawing.Point(0, 49);
            this.lblGercekCVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGercekCVal.Name = "lblGercekCVal";
            this.lblGercekCVal.Size = new System.Drawing.Size(224, 49);
            this.lblGercekCVal.TabIndex = 1;
            this.lblGercekCVal.Text = "- sn";
            this.lblGercekCVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGercekCTitle
            // 
            this.lblGercekCTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGercekCTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGercekCTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblGercekCTitle.Location = new System.Drawing.Point(0, 0);
            this.lblGercekCTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGercekCTitle.Name = "lblGercekCTitle";
            this.lblGercekCTitle.Size = new System.Drawing.Size(224, 37);
            this.lblGercekCTitle.TabIndex = 0;
            this.lblGercekCTitle.Text = "GERÇEK ÇEVRİM";
            this.lblGercekCTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCardVerim
            // 
            this.pnlCardVerim.BackColor = System.Drawing.Color.White;
            this.pnlCardVerim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardVerim.Controls.Add(this.lblVerimVal);
            this.pnlCardVerim.Controls.Add(this.lblVerimTitle);
            this.pnlCardVerim.Location = new System.Drawing.Point(17, 147);
            this.pnlCardVerim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCardVerim.Name = "pnlCardVerim";
            this.pnlCardVerim.Size = new System.Drawing.Size(226, 123);
            this.pnlCardVerim.TabIndex = 0;
            // 
            // lblVerimVal
            // 
            this.lblVerimVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVerimVal.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblVerimVal.Location = new System.Drawing.Point(0, 49);
            this.lblVerimVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerimVal.Name = "lblVerimVal";
            this.lblVerimVal.Size = new System.Drawing.Size(224, 49);
            this.lblVerimVal.TabIndex = 1;
            this.lblVerimVal.Text = "%-";
            this.lblVerimVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVerimTitle
            // 
            this.lblVerimTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblVerimTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVerimTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblVerimTitle.Location = new System.Drawing.Point(0, 0);
            this.lblVerimTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerimTitle.Name = "lblVerimTitle";
            this.lblVerimTitle.Size = new System.Drawing.Size(224, 37);
            this.lblVerimTitle.TabIndex = 0;
            this.lblVerimTitle.Text = "HAT VERİMLİLİĞİ";
            this.lblVerimTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCardSI
            // 
            this.pnlCardSI.BackColor = System.Drawing.Color.White;
            this.pnlCardSI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardSI.Controls.Add(this.lblSIVal);
            this.pnlCardSI.Controls.Add(this.lblSITitle);
            this.pnlCardSI.Location = new System.Drawing.Point(251, 147);
            this.pnlCardSI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCardSI.Name = "pnlCardSI";
            this.pnlCardSI.Size = new System.Drawing.Size(226, 123);
            this.pnlCardSI.TabIndex = 5;
            // 
            // lblSIVal
            // 
            this.lblSIVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSIVal.ForeColor = System.Drawing.Color.DimGray;
            this.lblSIVal.Location = new System.Drawing.Point(0, 49);
            this.lblSIVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSIVal.Name = "lblSIVal";
            this.lblSIVal.Size = new System.Drawing.Size(224, 49);
            this.lblSIVal.TabIndex = 1;
            this.lblSIVal.Text = "-";
            this.lblSIVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSITitle
            // 
            this.lblSITitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSITitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSITitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSITitle.Location = new System.Drawing.Point(0, 0);
            this.lblSITitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSITitle.Name = "lblSITitle";
            this.lblSITitle.Size = new System.Drawing.Size(224, 37);
            this.lblSITitle.TabIndex = 0;
            this.lblSITitle.Text = "PÜRÜZSÜZLÜK (SI)";
            this.lblSITitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCardFitness
            // 
            this.pnlCardFitness.BackColor = System.Drawing.Color.White;
            this.pnlCardFitness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardFitness.Controls.Add(this.lblFitnessVal);
            this.pnlCardFitness.Controls.Add(this.lblFitnessTitle);
            this.pnlCardFitness.Location = new System.Drawing.Point(485, 147);
            this.pnlCardFitness.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCardFitness.Name = "pnlCardFitness";
            this.pnlCardFitness.Size = new System.Drawing.Size(226, 123);
            this.pnlCardFitness.TabIndex = 4;
            // 
            // lblFitnessVal
            // 
            this.lblFitnessVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFitnessVal.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblFitnessVal.Location = new System.Drawing.Point(0, 49);
            this.lblFitnessVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFitnessVal.Name = "lblFitnessVal";
            this.lblFitnessVal.Size = new System.Drawing.Size(224, 49);
            this.lblFitnessVal.TabIndex = 1;
            this.lblFitnessVal.Text = "-";
            this.lblFitnessVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFitnessTitle
            // 
            this.lblFitnessTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFitnessTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFitnessTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblFitnessTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFitnessTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFitnessTitle.Name = "lblFitnessTitle";
            this.lblFitnessTitle.Size = new System.Drawing.Size(224, 37);
            this.lblFitnessTitle.TabIndex = 0;
            this.lblFitnessTitle.Text = "UYGUNLUK DEĞERİ";
            this.lblFitnessTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpDetay
            // 
            this.grpDetay.Controls.Add(this.dgvSonuclar);
            this.grpDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetay.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpDetay.Location = new System.Drawing.Point(0, 320);
            this.grpDetay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDetay.Name = "grpDetay";
            this.grpDetay.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDetay.Size = new System.Drawing.Size(1579, 408);
            this.grpDetay.TabIndex = 1;
            this.grpDetay.TabStop = false;
            this.grpDetay.Text = "İstasyon Detayları ve İş Atamaları";
            // 
            // dgvSonuclar
            // 
            this.dgvSonuclar.AllowUserToAddRows = false;
            this.dgvSonuclar.AllowUserToDeleteRows = false;
            this.dgvSonuclar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSonuclar.BackgroundColor = System.Drawing.Color.White;
            this.dgvSonuclar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSonuclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSonuclar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSonuclar.Location = new System.Drawing.Point(4, 34);
            this.dgvSonuclar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSonuclar.MultiSelect = false;
            this.dgvSonuclar.Name = "dgvSonuclar";
            this.dgvSonuclar.ReadOnly = true;
            this.dgvSonuclar.RowHeadersWidth = 51;
            this.dgvSonuclar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSonuclar.Size = new System.Drawing.Size(1571, 375);
            this.dgvSonuclar.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.Controls.Add(this.btnKapat);
            this.pnlBottom.Controls.Add(this.btnExcel);
            this.pnlBottom.Controls.Add(this.btnDiyagram);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 728);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1579, 86);
            this.pnlBottom.TabIndex = 2;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.BackColor = System.Drawing.Color.Crimson;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(1360, 18);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(200, 49);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.BackColor = System.Drawing.Color.SeaGreen;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Location = new System.Drawing.Point(1133, 18);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(200, 49);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.Text = "EXCEL\'E AKTAR";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnDiyagram
            // 
            this.btnDiyagram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiyagram.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDiyagram.FlatAppearance.BorderSize = 0;
            this.btnDiyagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiyagram.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDiyagram.ForeColor = System.Drawing.Color.White;
            this.btnDiyagram.Location = new System.Drawing.Point(907, 18);
            this.btnDiyagram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDiyagram.Name = "btnDiyagram";
            this.btnDiyagram.Size = new System.Drawing.Size(200, 49);
            this.btnDiyagram.TabIndex = 0;
            this.btnDiyagram.Text = "İLİŞKİ DİYAGRAMI";
            this.btnDiyagram.UseVisualStyleBackColor = false;
            this.btnDiyagram.Click += new System.EventHandler(this.btnDiyagram_Click);
            // 
            // FrmSonuclar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1579, 814);
            this.Controls.Add(this.grpDetay);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmSonuclar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sonuç ve Rapor Ekranı";
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartYukDagitimi)).EndInit();
            this.flowKPI.ResumeLayout(false);
            this.pnlCardIstasyon.ResumeLayout(false);
            this.pnlCardHedefC.ResumeLayout(false);
            this.pnlCardGercekC.ResumeLayout(false);
            this.pnlCardVerim.ResumeLayout(false);
            this.pnlCardSI.ResumeLayout(false);
            this.pnlCardFitness.ResumeLayout(false);
            this.grpDetay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonuclar)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.FlowLayoutPanel flowKPI;
        private System.Windows.Forms.Panel pnlCardVerim;
        private System.Windows.Forms.Label lblVerimVal;
        private System.Windows.Forms.Label lblVerimTitle;
        private System.Windows.Forms.Panel pnlCardIstasyon;
        private System.Windows.Forms.Label lblIstasyonVal;
        private System.Windows.Forms.Label lblIstasyonTitle;
        private System.Windows.Forms.Panel pnlCardHedefC;
        private System.Windows.Forms.Label lblHedefCVal;
        private System.Windows.Forms.Label lblHedefCTitle;
        private System.Windows.Forms.Panel pnlCardGercekC;
        private System.Windows.Forms.Label lblGercekCVal;
        private System.Windows.Forms.Label lblGercekCTitle;
        private System.Windows.Forms.Panel pnlCardFitness;
        private System.Windows.Forms.Label lblFitnessVal;
        private System.Windows.Forms.Label lblFitnessTitle;
        private System.Windows.Forms.Panel pnlCardSI;
        private System.Windows.Forms.Label lblSIVal;
        private System.Windows.Forms.Label lblSITitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartYukDagitimi;
        private System.Windows.Forms.GroupBox grpDetay;
        private System.Windows.Forms.DataGridView dgvSonuclar;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnDiyagram; // YENİ EKLENDİ
    }
}