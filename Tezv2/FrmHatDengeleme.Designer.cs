namespace Tezv2
{
    partial class FrmHatDengeleme
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
            this.grpGirdiler = new System.Windows.Forms.GroupBox();
            this.lblUyari = new System.Windows.Forms.Label();
            this.numHedefSure = new System.Windows.Forms.NumericUpDown();
            this.lblHedefSure = new System.Windows.Forms.Label();
            this.cmbHat = new System.Windows.Forms.ComboBox();
            this.lblHat = new System.Windows.Forms.Label();
            this.grpAyarlar = new System.Windows.Forms.GroupBox();
            this.grpDurdurma = new System.Windows.Forms.GroupBox();
            this.numUygunlukLimiti = new System.Windows.Forms.NumericUpDown();
            this.rdbUygunluk = new System.Windows.Forms.RadioButton();
            this.rdbIterasyon = new System.Windows.Forms.RadioButton();
            this.numIterasyon = new System.Windows.Forms.NumericUpDown();
            this.grpParametreler = new System.Windows.Forms.GroupBox();
            this.numTurnuvaBoyutu = new System.Windows.Forms.NumericUpDown();
            this.numPopulasyon = new System.Windows.Forms.NumericUpDown();
            this.lblTurnuva = new System.Windows.Forms.Label();
            this.lblPopulasyon = new System.Windows.Forms.Label();
            this.grpAdaptifAyarlar = new System.Windows.Forms.GroupBox();
            this.numMutasyonOran = new System.Windows.Forms.NumericUpDown();
            this.lblMutasyon = new System.Windows.Forms.Label();
            this.trkMutasyon = new System.Windows.Forms.TrackBar();
            this.numCaprazlamaOran = new System.Windows.Forms.NumericUpDown();
            this.lblCaprazlama = new System.Windows.Forms.Label();
            this.trkCaprazlama = new System.Windows.Forms.TrackBar();
            this.chkAdaptif = new System.Windows.Forms.CheckBox();
            this.grpBilgi = new System.Windows.Forms.GroupBox();
            this.lblBilgi4 = new System.Windows.Forms.Label();
            this.lblBilgi3 = new System.Windows.Forms.Label();
            this.lblBilgi2 = new System.Windows.Forms.Label();
            this.lblBilgi1 = new System.Windows.Forms.Label();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.prgIlerleme = new System.Windows.Forms.ProgressBar();
            this.lblGecenSure = new System.Windows.Forms.Label();
            this.lblAnlikMutasyon = new System.Windows.Forms.Label();
            this.lblAnlikCaprazlama = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.chartFitness = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpGirdiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHedefSure)).BeginInit();
            this.grpAyarlar.SuspendLayout();
            this.grpDurdurma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUygunlukLimiti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIterasyon)).BeginInit();
            this.grpParametreler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTurnuvaBoyutu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulasyon)).BeginInit();
            this.grpAdaptifAyarlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMutasyonOran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkMutasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCaprazlamaOran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkCaprazlama)).BeginInit();
            this.grpBilgi.SuspendLayout();
            this.pnlAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFitness)).BeginInit();
            this.SuspendLayout();
            // 
            // grpGirdiler
            // 
            this.grpGirdiler.BackColor = System.Drawing.Color.White;
            this.grpGirdiler.Controls.Add(this.lblUyari);
            this.grpGirdiler.Controls.Add(this.numHedefSure);
            this.grpGirdiler.Controls.Add(this.lblHedefSure);
            this.grpGirdiler.Controls.Add(this.cmbHat);
            this.grpGirdiler.Controls.Add(this.lblHat);
            this.grpGirdiler.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpGirdiler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.grpGirdiler.Location = new System.Drawing.Point(12, 12);
            this.grpGirdiler.Name = "grpGirdiler";
            this.grpGirdiler.Size = new System.Drawing.Size(304, 287);
            this.grpGirdiler.TabIndex = 0;
            this.grpGirdiler.TabStop = false;
            this.grpGirdiler.Text = "1. Simülasyon Girdileri";
            // 
            // lblUyari
            // 
            this.lblUyari.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.lblUyari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(145)))), ((int)(((byte)(160)))));
            this.lblUyari.Location = new System.Drawing.Point(15, 155);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(277, 106);
            this.lblUyari.TabIndex = 6;
            this.lblUyari.Text = "Lütfen analiz edilecek hattı seçiniz.";
            // 
            // numHedefSure
            // 
            this.numHedefSure.DecimalPlaces = 2;
            this.numHedefSure.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numHedefSure.Location = new System.Drawing.Point(15, 117);
            this.numHedefSure.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numHedefSure.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numHedefSure.Name = "numHedefSure";
            this.numHedefSure.Size = new System.Drawing.Size(277, 27);
            this.numHedefSure.TabIndex = 3;
            this.numHedefSure.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblHedefSure
            // 
            this.lblHedefSure.AutoSize = true;
            this.lblHedefSure.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHedefSure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.lblHedefSure.Location = new System.Drawing.Point(15, 95);
            this.lblHedefSure.Name = "lblHedefSure";
            this.lblHedefSure.Size = new System.Drawing.Size(197, 20);
            this.lblHedefSure.TabIndex = 2;
            this.lblHedefSure.Text = "Hedef Çevrim Süresi (C) - sn:";
            // 
            // cmbHat
            // 
            this.cmbHat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbHat.Location = new System.Drawing.Point(15, 52);
            this.cmbHat.Name = "cmbHat";
            this.cmbHat.Size = new System.Drawing.Size(277, 28);
            this.cmbHat.TabIndex = 1;
            this.cmbHat.SelectedIndexChanged += new System.EventHandler(this.cmbHat_SelectedIndexChanged);
            // 
            // lblHat
            // 
            this.lblHat.AutoSize = true;
            this.lblHat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.lblHat.Location = new System.Drawing.Point(15, 30);
            this.lblHat.Name = "lblHat";
            this.lblHat.Size = new System.Drawing.Size(193, 20);
            this.lblHat.TabIndex = 0;
            this.lblHat.Text = "Dengelenecek Hattı Seçiniz:";
            // 
            // grpAyarlar
            // 
            this.grpAyarlar.BackColor = System.Drawing.Color.White;
            this.grpAyarlar.Controls.Add(this.grpDurdurma);
            this.grpAyarlar.Controls.Add(this.grpParametreler);
            this.grpAyarlar.Controls.Add(this.grpAdaptifAyarlar);
            this.grpAyarlar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpAyarlar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.grpAyarlar.Location = new System.Drawing.Point(322, 12);
            this.grpAyarlar.Name = "grpAyarlar";
            this.grpAyarlar.Size = new System.Drawing.Size(1245, 287);
            this.grpAyarlar.TabIndex = 1;
            this.grpAyarlar.TabStop = false;
            this.grpAyarlar.Text = "2. Algoritma Ayarları";
            // 
            // grpDurdurma
            // 
            this.grpDurdurma.Controls.Add(this.numUygunlukLimiti);
            this.grpDurdurma.Controls.Add(this.rdbUygunluk);
            this.grpDurdurma.Controls.Add(this.rdbIterasyon);
            this.grpDurdurma.Controls.Add(this.numIterasyon);
            this.grpDurdurma.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpDurdurma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.grpDurdurma.Location = new System.Drawing.Point(15, 30);
            this.grpDurdurma.Name = "grpDurdurma";
            this.grpDurdurma.Size = new System.Drawing.Size(313, 245);
            this.grpDurdurma.TabIndex = 1;
            this.grpDurdurma.TabStop = false;
            this.grpDurdurma.Text = "Durdurma Kriteri";
            // 
            // numUygunlukLimiti
            // 
            this.numUygunlukLimiti.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numUygunlukLimiti.Location = new System.Drawing.Point(15, 135);
            this.numUygunlukLimiti.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUygunlukLimiti.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUygunlukLimiti.Name = "numUygunlukLimiti";
            this.numUygunlukLimiti.Size = new System.Drawing.Size(245, 27);
            this.numUygunlukLimiti.TabIndex = 3;
            this.numUygunlukLimiti.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // rdbUygunluk
            // 
            this.rdbUygunluk.AutoSize = true;
            this.rdbUygunluk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.rdbUygunluk.Location = new System.Drawing.Point(15, 108);
            this.rdbUygunluk.Name = "rdbUygunluk";
            this.rdbUygunluk.Size = new System.Drawing.Size(255, 24);
            this.rdbUygunluk.TabIndex = 2;
            this.rdbUygunluk.Text = "Uygunluk Hesaplama Limiti (Eval.)";
            this.rdbUygunluk.UseVisualStyleBackColor = true;
            // 
            // rdbIterasyon
            // 
            this.rdbIterasyon.AutoSize = true;
            this.rdbIterasyon.Checked = true;
            this.rdbIterasyon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.rdbIterasyon.Location = new System.Drawing.Point(15, 35);
            this.rdbIterasyon.Name = "rdbIterasyon";
            this.rdbIterasyon.Size = new System.Drawing.Size(178, 24);
            this.rdbIterasyon.TabIndex = 0;
            this.rdbIterasyon.TabStop = true;
            this.rdbIterasyon.Text = "İterasyon (Nesil) Sayısı";
            this.rdbIterasyon.UseVisualStyleBackColor = true;
            // 
            // numIterasyon
            // 
            this.numIterasyon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numIterasyon.Location = new System.Drawing.Point(15, 62);
            this.numIterasyon.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numIterasyon.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numIterasyon.Name = "numIterasyon";
            this.numIterasyon.Size = new System.Drawing.Size(245, 27);
            this.numIterasyon.TabIndex = 1;
            this.numIterasyon.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // grpParametreler
            // 
            this.grpParametreler.Controls.Add(this.numTurnuvaBoyutu);
            this.grpParametreler.Controls.Add(this.numPopulasyon);
            this.grpParametreler.Controls.Add(this.lblTurnuva);
            this.grpParametreler.Controls.Add(this.lblPopulasyon);
            this.grpParametreler.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpParametreler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.grpParametreler.Location = new System.Drawing.Point(334, 30);
            this.grpParametreler.Name = "grpParametreler";
            this.grpParametreler.Size = new System.Drawing.Size(339, 245);
            this.grpParametreler.TabIndex = 2;
            this.grpParametreler.TabStop = false;
            this.grpParametreler.Text = "GA Parametreleri";
            // 
            // numTurnuvaBoyutu
            // 
            this.numTurnuvaBoyutu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numTurnuvaBoyutu.Location = new System.Drawing.Point(193, 63);
            this.numTurnuvaBoyutu.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numTurnuvaBoyutu.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numTurnuvaBoyutu.Name = "numTurnuvaBoyutu";
            this.numTurnuvaBoyutu.Size = new System.Drawing.Size(110, 27);
            this.numTurnuvaBoyutu.TabIndex = 1;
            this.numTurnuvaBoyutu.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numPopulasyon
            // 
            this.numPopulasyon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numPopulasyon.Location = new System.Drawing.Point(208, 28);
            this.numPopulasyon.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numPopulasyon.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numPopulasyon.Name = "numPopulasyon";
            this.numPopulasyon.Size = new System.Drawing.Size(95, 27);
            this.numPopulasyon.TabIndex = 1;
            this.numPopulasyon.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblTurnuva
            // 
            this.lblTurnuva.AutoSize = true;
            this.lblTurnuva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.lblTurnuva.Location = new System.Drawing.Point(15, 65);
            this.lblTurnuva.Name = "lblTurnuva";
            this.lblTurnuva.Size = new System.Drawing.Size(114, 20);
            this.lblTurnuva.TabIndex = 0;
            this.lblTurnuva.Text = "Turnuva Boyutu:";
            // 
            // lblPopulasyon
            // 
            this.lblPopulasyon.AutoSize = true;
            this.lblPopulasyon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.lblPopulasyon.Location = new System.Drawing.Point(15, 30);
            this.lblPopulasyon.Name = "lblPopulasyon";
            this.lblPopulasyon.Size = new System.Drawing.Size(159, 20);
            this.lblPopulasyon.TabIndex = 0;
            this.lblPopulasyon.Text = "Popülasyon Büyüklüğü:";
            // 
            // grpAdaptifAyarlar
            // 
            this.grpAdaptifAyarlar.Controls.Add(this.numMutasyonOran);
            this.grpAdaptifAyarlar.Controls.Add(this.lblMutasyon);
            this.grpAdaptifAyarlar.Controls.Add(this.trkMutasyon);
            this.grpAdaptifAyarlar.Controls.Add(this.numCaprazlamaOran);
            this.grpAdaptifAyarlar.Controls.Add(this.lblCaprazlama);
            this.grpAdaptifAyarlar.Controls.Add(this.trkCaprazlama);
            this.grpAdaptifAyarlar.Controls.Add(this.chkAdaptif);
            this.grpAdaptifAyarlar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpAdaptifAyarlar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.grpAdaptifAyarlar.Location = new System.Drawing.Point(679, 30);
            this.grpAdaptifAyarlar.Name = "grpAdaptifAyarlar";
            this.grpAdaptifAyarlar.Size = new System.Drawing.Size(560, 245);
            this.grpAdaptifAyarlar.TabIndex = 3;
            this.grpAdaptifAyarlar.TabStop = false;
            this.grpAdaptifAyarlar.Text = "Adaptif Seçim Ayarları";
            // 
            // numMutasyonOran
            // 
            this.numMutasyonOran.DecimalPlaces = 1;
            this.numMutasyonOran.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.numMutasyonOran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numMutasyonOran.Location = new System.Drawing.Point(448, 99);
            this.numMutasyonOran.Name = "numMutasyonOran";
            this.numMutasyonOran.Size = new System.Drawing.Size(95, 27);
            this.numMutasyonOran.TabIndex = 10;
            this.numMutasyonOran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMutasyonOran.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblMutasyon
            // 
            this.lblMutasyon.AutoSize = true;
            this.lblMutasyon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.lblMutasyon.Location = new System.Drawing.Point(13, 68);
            this.lblMutasyon.Name = "lblMutasyon";
            this.lblMutasyon.Size = new System.Drawing.Size(142, 20);
            this.lblMutasyon.TabIndex = 8;
            this.lblMutasyon.Text = "Mutasyon Oranı (%):";
            // 
            // trkMutasyon
            // 
            this.trkMutasyon.Location = new System.Drawing.Point(13, 91);
            this.trkMutasyon.Maximum = 100;
            this.trkMutasyon.Name = "trkMutasyon";
            this.trkMutasyon.Size = new System.Drawing.Size(430, 56);
            this.trkMutasyon.TabIndex = 9;
            this.trkMutasyon.TickFrequency = 10;
            this.trkMutasyon.Value = 5;
            // 
            // numCaprazlamaOran
            // 
            this.numCaprazlamaOran.DecimalPlaces = 1;
            this.numCaprazlamaOran.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.numCaprazlamaOran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(122)))), ((int)(((byte)(74)))));
            this.numCaprazlamaOran.Location = new System.Drawing.Point(448, 183);
            this.numCaprazlamaOran.Name = "numCaprazlamaOran";
            this.numCaprazlamaOran.Size = new System.Drawing.Size(95, 27);
            this.numCaprazlamaOran.TabIndex = 13;
            this.numCaprazlamaOran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCaprazlamaOran.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // lblCaprazlama
            // 
            this.lblCaprazlama.AutoSize = true;
            this.lblCaprazlama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.lblCaprazlama.Location = new System.Drawing.Point(13, 152);
            this.lblCaprazlama.Name = "lblCaprazlama";
            this.lblCaprazlama.Size = new System.Drawing.Size(157, 20);
            this.lblCaprazlama.TabIndex = 11;
            this.lblCaprazlama.Text = "Çaprazlama Oranı (%):";
            // 
            // trkCaprazlama
            // 
            this.trkCaprazlama.Location = new System.Drawing.Point(13, 175);
            this.trkCaprazlama.Maximum = 100;
            this.trkCaprazlama.Name = "trkCaprazlama";
            this.trkCaprazlama.Size = new System.Drawing.Size(430, 56);
            this.trkCaprazlama.TabIndex = 12;
            this.trkCaprazlama.TickFrequency = 10;
            this.trkCaprazlama.Value = 80;
            // 
            // chkAdaptif
            // 
            this.chkAdaptif.AutoSize = true;
            this.chkAdaptif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.chkAdaptif.Location = new System.Drawing.Point(17, 36);
            this.chkAdaptif.Name = "chkAdaptif";
            this.chkAdaptif.Size = new System.Drawing.Size(319, 24);
            this.chkAdaptif.TabIndex = 2;
            this.chkAdaptif.Text = "Adaptif Parametre Kullan (Dinamik Oranlar)";
            this.chkAdaptif.UseVisualStyleBackColor = true;
            // 
            // grpBilgi
            // 
            this.grpBilgi.BackColor = System.Drawing.Color.White;
            this.grpBilgi.Controls.Add(this.lblBilgi4);
            this.grpBilgi.Controls.Add(this.lblBilgi3);
            this.grpBilgi.Controls.Add(this.lblBilgi2);
            this.grpBilgi.Controls.Add(this.lblBilgi1);
            this.grpBilgi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpBilgi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.grpBilgi.Location = new System.Drawing.Point(12, 305);
            this.grpBilgi.Name = "grpBilgi";
            this.grpBilgi.Size = new System.Drawing.Size(304, 436);
            this.grpBilgi.TabIndex = 0;
            this.grpBilgi.TabStop = false;
            this.grpBilgi.Text = "Genetik Algoritma Bilgisi";
            // 
            // lblBilgi4
            // 
            this.lblBilgi4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBilgi4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.lblBilgi4.Location = new System.Drawing.Point(15, 181);
            this.lblBilgi4.Name = "lblBilgi4";
            this.lblBilgi4.Size = new System.Drawing.Size(340, 36);
            this.lblBilgi4.TabIndex = 3;
            this.lblBilgi4.Text = "• Mutasyon:\r\nScramble Sublist Mutation (SSM)";
            // 
            // lblBilgi3
            // 
            this.lblBilgi3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBilgi3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.lblBilgi3.Location = new System.Drawing.Point(15, 130);
            this.lblBilgi3.Name = "lblBilgi3";
            this.lblBilgi3.Size = new System.Drawing.Size(340, 36);
            this.lblBilgi3.TabIndex = 2;
            this.lblBilgi3.Text = "• Çaprazlama:\r\nSingle Point Crossover (SPX)";
            // 
            // lblBilgi2
            // 
            this.lblBilgi2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBilgi2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.lblBilgi2.Location = new System.Drawing.Point(15, 79);
            this.lblBilgi2.Name = "lblBilgi2";
            this.lblBilgi2.Size = new System.Drawing.Size(340, 36);
            this.lblBilgi2.TabIndex = 1;
            this.lblBilgi2.Text = "• Seçim:\r\nTurnuva Yöntemi";
            // 
            // lblBilgi1
            // 
            this.lblBilgi1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBilgi1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.lblBilgi1.Location = new System.Drawing.Point(15, 28);
            this.lblBilgi1.Name = "lblBilgi1";
            this.lblBilgi1.Size = new System.Drawing.Size(340, 36);
            this.lblBilgi1.TabIndex = 0;
            this.lblBilgi1.Text = "• Kodlama:\r\nÖncül Kısıtlı Rastgele Sıralama";
            // 
            // pnlAction
            // 
            this.pnlAction.BackColor = System.Drawing.Color.White;
            this.pnlAction.Controls.Add(this.prgIlerleme);
            this.pnlAction.Controls.Add(this.lblGecenSure);
            this.pnlAction.Controls.Add(this.lblAnlikMutasyon);
            this.pnlAction.Controls.Add(this.lblAnlikCaprazlama);
            this.pnlAction.Controls.Add(this.btnHesapla);
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAction.Location = new System.Drawing.Point(0, 757);
            this.pnlAction.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(1579, 94);
            this.pnlAction.TabIndex = 3;
            // 
            // prgIlerleme
            // 
            this.prgIlerleme.Location = new System.Drawing.Point(255, 22);
            this.prgIlerleme.Name = "prgIlerleme";
            this.prgIlerleme.Size = new System.Drawing.Size(704, 30);
            this.prgIlerleme.TabIndex = 5;
            // 
            // lblGecenSure
            // 
            this.lblGecenSure.AutoSize = true;
            this.lblGecenSure.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGecenSure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblGecenSure.Location = new System.Drawing.Point(20, 24);
            this.lblGecenSure.Name = "lblGecenSure";
            this.lblGecenSure.Size = new System.Drawing.Size(199, 25);
            this.lblGecenSure.TabIndex = 4;
            this.lblGecenSure.Text = "Geçen Süre: 00:00.00";
            // 
            // lblAnlikMutasyon
            // 
            this.lblAnlikMutasyon.AutoSize = true;
            this.lblAnlikMutasyon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAnlikMutasyon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblAnlikMutasyon.Location = new System.Drawing.Point(971, 22);
            this.lblAnlikMutasyon.Name = "lblAnlikMutasyon";
            this.lblAnlikMutasyon.Size = new System.Drawing.Size(144, 21);
            this.lblAnlikMutasyon.TabIndex = 6;
            this.lblAnlikMutasyon.Text = "Anlık Mutasyon: -";
            this.lblAnlikMutasyon.Visible = false;
            // 
            // lblAnlikCaprazlama
            // 
            this.lblAnlikCaprazlama.AutoSize = true;
            this.lblAnlikCaprazlama.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAnlikCaprazlama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(122)))), ((int)(((byte)(74)))));
            this.lblAnlikCaprazlama.Location = new System.Drawing.Point(971, 49);
            this.lblAnlikCaprazlama.Name = "lblAnlikCaprazlama";
            this.lblAnlikCaprazlama.Size = new System.Drawing.Size(158, 21);
            this.lblAnlikCaprazlama.TabIndex = 7;
            this.lblAnlikCaprazlama.Text = "Anlık Çaprazlama: -";
            this.lblAnlikCaprazlama.Visible = false;
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnHesapla.FlatAppearance.BorderSize = 0;
            this.btnHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapla.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnHesapla.ForeColor = System.Drawing.Color.White;
            this.btnHesapla.Location = new System.Drawing.Point(1215, 12);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(351, 63);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "HESAPLAMAYI BAŞLAT";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // chartFitness
            // 
            chartArea2.AxisX.Title = "İterasyon";
            chartArea2.AxisY.Title = "Fitness";
            chartArea2.Name = "ChartArea1";
            this.chartFitness.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartFitness.Legends.Add(legend2);
            this.chartFitness.Location = new System.Drawing.Point(322, 305);
            this.chartFitness.Name = "chartFitness";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFitness.Series.Add(series2);
            this.chartFitness.Size = new System.Drawing.Size(1244, 436);
            this.chartFitness.TabIndex = 2;
            this.chartFitness.Text = "Fitness Gelişimi";
            // 
            // FrmHatDengeleme
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1579, 851);
            this.Controls.Add(this.chartFitness);
            this.Controls.Add(this.grpAyarlar);
            this.Controls.Add(this.grpBilgi);
            this.Controls.Add(this.grpGirdiler);
            this.Controls.Add(this.pnlAction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHatDengeleme";
            this.Text = "Simülasyon ve Dengeleme Kokpiti";
            this.Load += new System.EventHandler(this.FrmHatDengeleme_Load);
            this.grpGirdiler.ResumeLayout(false);
            this.grpGirdiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHedefSure)).EndInit();
            this.grpAyarlar.ResumeLayout(false);
            this.grpDurdurma.ResumeLayout(false);
            this.grpDurdurma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUygunlukLimiti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIterasyon)).EndInit();
            this.grpParametreler.ResumeLayout(false);
            this.grpParametreler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTurnuvaBoyutu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulasyon)).EndInit();
            this.grpAdaptifAyarlar.ResumeLayout(false);
            this.grpAdaptifAyarlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMutasyonOran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkMutasyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCaprazlamaOran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkCaprazlama)).EndInit();
            this.grpBilgi.ResumeLayout(false);
            this.pnlAction.ResumeLayout(false);
            this.pnlAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFitness)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGirdiler;
        private System.Windows.Forms.Label lblHat;
        private System.Windows.Forms.ComboBox cmbHat;
        private System.Windows.Forms.NumericUpDown numHedefSure;
        private System.Windows.Forms.Label lblHedefSure;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.GroupBox grpAyarlar;
        private System.Windows.Forms.GroupBox grpDurdurma;
        private System.Windows.Forms.NumericUpDown numUygunlukLimiti;
        private System.Windows.Forms.RadioButton rdbUygunluk;
        private System.Windows.Forms.RadioButton rdbIterasyon;
        private System.Windows.Forms.NumericUpDown numIterasyon;
        private System.Windows.Forms.GroupBox grpParametreler;
        private System.Windows.Forms.NumericUpDown numPopulasyon;
        private System.Windows.Forms.Label lblPopulasyon;
        private System.Windows.Forms.GroupBox grpAdaptifAyarlar;
        private System.Windows.Forms.NumericUpDown numTurnuvaBoyutu;
        private System.Windows.Forms.Label lblTurnuva;
        private System.Windows.Forms.CheckBox chkAdaptif;
        private System.Windows.Forms.GroupBox grpBilgi;
        private System.Windows.Forms.Label lblBilgi4;
        private System.Windows.Forms.Label lblBilgi3;
        private System.Windows.Forms.Label lblBilgi2;
        private System.Windows.Forms.Label lblBilgi1;
        private System.Windows.Forms.Panel pnlAction;
        private System.Windows.Forms.ProgressBar prgIlerleme;
        private System.Windows.Forms.Label lblGecenSure;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblAnlikMutasyon;
        private System.Windows.Forms.Label lblAnlikCaprazlama;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFitness;
        private System.Windows.Forms.NumericUpDown numMutasyonOran;
        private System.Windows.Forms.Label lblMutasyon;
        private System.Windows.Forms.TrackBar trkMutasyon;
        private System.Windows.Forms.NumericUpDown numCaprazlamaOran;
        private System.Windows.Forms.Label lblCaprazlama;
        private System.Windows.Forms.TrackBar trkCaprazlama;
    }
}