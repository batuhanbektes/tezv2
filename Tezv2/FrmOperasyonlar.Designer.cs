namespace Tezv2
{
    partial class FrmOperasyonlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpBilgiler = new System.Windows.Forms.GroupBox();
            this.numSure = new System.Windows.Forms.NumericUpDown();
            this.cmbHatSecimi = new System.Windows.Forms.ComboBox();
            this.txtOpAdi = new System.Windows.Forms.TextBox();
            this.rTxtAciklama = new System.Windows.Forms.RichTextBox();
            this.txtOpKodu = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblOpAdi = new System.Windows.Forms.Label();
            this.lblOpKodu = new System.Windows.Forms.Label();
            this.lblHat = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.grpIslemler = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.grpListe = new System.Windows.Forms.GroupBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.dgvOperasyonlar = new System.Windows.Forms.DataGridView();
            this.grpBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSure)).BeginInit();
            this.grpIslemler.SuspendLayout();
            this.grpListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperasyonlar)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBilgiler
            // 
            this.grpBilgiler.BackColor = System.Drawing.Color.White;
            this.grpBilgiler.Controls.Add(this.numSure);
            this.grpBilgiler.Controls.Add(this.cmbHatSecimi);
            this.grpBilgiler.Controls.Add(this.txtOpAdi);
            this.grpBilgiler.Controls.Add(this.rTxtAciklama);
            this.grpBilgiler.Controls.Add(this.txtOpKodu);
            this.grpBilgiler.Controls.Add(this.lblAciklama);
            this.grpBilgiler.Controls.Add(this.lblSure);
            this.grpBilgiler.Controls.Add(this.lblOpAdi);
            this.grpBilgiler.Controls.Add(this.lblOpKodu);
            this.grpBilgiler.Controls.Add(this.lblHat);
            this.grpBilgiler.Controls.Add(this.txtID);
            this.grpBilgiler.Controls.Add(this.lblID);
            this.grpBilgiler.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBilgiler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.grpBilgiler.Location = new System.Drawing.Point(16, 15);
            this.grpBilgiler.Margin = new System.Windows.Forms.Padding(4);
            this.grpBilgiler.Name = "grpBilgiler";
            this.grpBilgiler.Padding = new System.Windows.Forms.Padding(4);
            this.grpBilgiler.Size = new System.Drawing.Size(467, 492);
            this.grpBilgiler.TabIndex = 0;
            this.grpBilgiler.TabStop = false;
            this.grpBilgiler.Text = "Operasyon Bilgileri";
            // 
            // numSure
            // 
            this.numSure.DecimalPlaces = 2;
            this.numSure.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numSure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.numSure.Location = new System.Drawing.Point(173, 240);
            this.numSure.Margin = new System.Windows.Forms.Padding(4);
            this.numSure.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSure.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numSure.Name = "numSure";
            this.numSure.Size = new System.Drawing.Size(160, 29);
            this.numSure.TabIndex = 3;
            this.numSure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSure.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbHatSecimi
            // 
            this.cmbHatSecimi.BackColor = System.Drawing.Color.White;
            this.cmbHatSecimi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHatSecimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHatSecimi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbHatSecimi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.cmbHatSecimi.FormattingEnabled = true;
            this.cmbHatSecimi.Location = new System.Drawing.Point(173, 92);
            this.cmbHatSecimi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHatSecimi.Name = "cmbHatSecimi";
            this.cmbHatSecimi.Size = new System.Drawing.Size(265, 29);
            this.cmbHatSecimi.TabIndex = 0;
            this.cmbHatSecimi.SelectedIndexChanged += new System.EventHandler(this.cmbHatSecimi_SelectedIndexChanged);
            // 
            // txtOpAdi
            // 
            this.txtOpAdi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOpAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.txtOpAdi.Location = new System.Drawing.Point(173, 191);
            this.txtOpAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpAdi.Name = "txtOpAdi";
            this.txtOpAdi.Size = new System.Drawing.Size(265, 29);
            this.txtOpAdi.TabIndex = 2;
            // 
            // rTxtAciklama
            // 
            this.rTxtAciklama.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rTxtAciklama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.rTxtAciklama.Location = new System.Drawing.Point(173, 289);
            this.rTxtAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.rTxtAciklama.Name = "rTxtAciklama";
            this.rTxtAciklama.Size = new System.Drawing.Size(265, 171);
            this.rTxtAciklama.TabIndex = 4;
            this.rTxtAciklama.Text = "";
            // 
            // txtOpKodu
            // 
            this.txtOpKodu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOpKodu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.txtOpKodu.Location = new System.Drawing.Point(173, 142);
            this.txtOpKodu.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpKodu.Name = "txtOpKodu";
            this.txtOpKodu.Size = new System.Drawing.Size(265, 29);
            this.txtOpKodu.TabIndex = 1;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.lblAciklama.Location = new System.Drawing.Point(27, 293);
            this.lblAciklama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(82, 23);
            this.lblAciklama.TabIndex = 8;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.lblSure.Location = new System.Drawing.Point(27, 242);
            this.lblSure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(85, 23);
            this.lblSure.TabIndex = 7;
            this.lblSure.Text = "Süre (sn):";
            // 
            // lblOpAdi
            // 
            this.lblOpAdi.AutoSize = true;
            this.lblOpAdi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOpAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.lblOpAdi.Location = new System.Drawing.Point(27, 194);
            this.lblOpAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpAdi.Name = "lblOpAdi";
            this.lblOpAdi.Size = new System.Drawing.Size(126, 23);
            this.lblOpAdi.TabIndex = 6;
            this.lblOpAdi.Text = "Operasyon Adı:";
            // 
            // lblOpKodu
            // 
            this.lblOpKodu.AutoSize = true;
            this.lblOpKodu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOpKodu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.lblOpKodu.Location = new System.Drawing.Point(27, 145);
            this.lblOpKodu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpKodu.Name = "lblOpKodu";
            this.lblOpKodu.Size = new System.Drawing.Size(141, 23);
            this.lblOpKodu.TabIndex = 5;
            this.lblOpKodu.Text = "Operasyon Kodu:";
            // 
            // lblHat
            // 
            this.lblHat.AutoSize = true;
            this.lblHat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.lblHat.Location = new System.Drawing.Point(27, 96);
            this.lblHat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHat.Name = "lblHat";
            this.lblHat.Size = new System.Drawing.Size(102, 23);
            this.lblHat.TabIndex = 4;
            this.lblHat.Text = "Hat Seçimi:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.txtID.Location = new System.Drawing.Point(173, 43);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(105, 29);
            this.txtID.TabIndex = 100;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.lblID.Location = new System.Drawing.Point(27, 47);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(118, 23);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Operasyon ID:";
            // 
            // grpIslemler
            // 
            this.grpIslemler.BackColor = System.Drawing.Color.White;
            this.grpIslemler.Controls.Add(this.btnTemizle);
            this.grpIslemler.Controls.Add(this.btnSil);
            this.grpIslemler.Controls.Add(this.btnGuncelle);
            this.grpIslemler.Controls.Add(this.btnEkle);
            this.grpIslemler.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpIslemler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.grpIslemler.Location = new System.Drawing.Point(16, 529);
            this.grpIslemler.Margin = new System.Windows.Forms.Padding(4);
            this.grpIslemler.Name = "grpIslemler";
            this.grpIslemler.Padding = new System.Windows.Forms.Padding(4);
            this.grpIslemler.Size = new System.Drawing.Size(467, 222);
            this.grpIslemler.TabIndex = 1;
            this.grpIslemler.TabStop = false;
            this.grpIslemler.Text = "İşlemler";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(240, 135);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(200, 49);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(27, 135);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(200, 49);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(240, 49);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(200, 49);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(74)))));
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(27, 49);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(200, 49);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // grpListe
            // 
            this.grpListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpListe.BackColor = System.Drawing.Color.White;
            this.grpListe.Controls.Add(this.txtArama);
            this.grpListe.Controls.Add(this.lblArama);
            this.grpListe.Controls.Add(this.dgvOperasyonlar);
            this.grpListe.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpListe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.grpListe.Location = new System.Drawing.Point(507, 15);
            this.grpListe.Margin = new System.Windows.Forms.Padding(4);
            this.grpListe.Name = "grpListe";
            this.grpListe.Padding = new System.Windows.Forms.Padding(4);
            this.grpListe.Size = new System.Drawing.Size(1056, 821);
            this.grpListe.TabIndex = 2;
            this.grpListe.TabStop = false;
            this.grpListe.Text = "Operasyon Listesi";
            // 
            // txtArama
            // 
            this.txtArama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArama.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.txtArama.Location = new System.Drawing.Point(113, 43);
            this.txtArama.Margin = new System.Windows.Forms.Padding(4);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(912, 29);
            this.txtArama.TabIndex = 9;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblArama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.lblArama.Location = new System.Drawing.Point(27, 47);
            this.lblArama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(64, 23);
            this.lblArama.TabIndex = 1;
            this.lblArama.Text = "Arama:";
            // 
            // dgvOperasyonlar
            // 
            this.dgvOperasyonlar.AllowUserToAddRows = false;
            this.dgvOperasyonlar.AllowUserToDeleteRows = false;
            this.dgvOperasyonlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOperasyonlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOperasyonlar.BackgroundColor = System.Drawing.Color.White;
            this.dgvOperasyonlar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOperasyonlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOperasyonlar.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOperasyonlar.Location = new System.Drawing.Point(8, 92);
            this.dgvOperasyonlar.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOperasyonlar.MultiSelect = false;
            this.dgvOperasyonlar.Name = "dgvOperasyonlar";
            this.dgvOperasyonlar.ReadOnly = true;
            this.dgvOperasyonlar.RowHeadersWidth = 51;
            this.dgvOperasyonlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperasyonlar.Size = new System.Drawing.Size(1040, 721);
            this.dgvOperasyonlar.TabIndex = 10;
            this.dgvOperasyonlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOperasyonlar_CellClick);
            // 
            // FrmOperasyonlar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1579, 851);
            this.Controls.Add(this.grpListe);
            this.Controls.Add(this.grpIslemler);
            this.Controls.Add(this.grpBilgiler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOperasyonlar";
            this.Text = "Operasyon Yönetim Ekranı";
            this.Load += new System.EventHandler(this.FrmOperasyonlar_Load);
            this.grpBilgiler.ResumeLayout(false);
            this.grpBilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSure)).EndInit();
            this.grpIslemler.ResumeLayout(false);
            this.grpListe.ResumeLayout(false);
            this.grpListe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperasyonlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBilgiler;
        private System.Windows.Forms.TextBox txtOpAdi;
        private System.Windows.Forms.RichTextBox rTxtAciklama;
        private System.Windows.Forms.TextBox txtOpKodu;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblOpAdi;
        private System.Windows.Forms.Label lblOpKodu;
        private System.Windows.Forms.Label lblHat;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cmbHatSecimi;
        private System.Windows.Forms.NumericUpDown numSure;
        private System.Windows.Forms.GroupBox grpIslemler;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox grpListe;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.DataGridView dgvOperasyonlar;
    }
}