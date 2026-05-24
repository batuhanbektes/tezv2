namespace Tezv2
{
    partial class FrmHatlar
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
            this.txtHatAdi = new System.Windows.Forms.TextBox();
            this.rTxtAciklama = new System.Windows.Forms.RichTextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblHatAdi = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.grpIslemler = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.grpListe = new System.Windows.Forms.GroupBox();
            this.dgvHatlar = new System.Windows.Forms.DataGridView();
            this.grpBilgiler.SuspendLayout();
            this.grpIslemler.SuspendLayout();
            this.grpListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHatlar)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBilgiler
            // 
            this.grpBilgiler.BackColor = System.Drawing.Color.White;
            this.grpBilgiler.Controls.Add(this.txtHatAdi);
            this.grpBilgiler.Controls.Add(this.rTxtAciklama);
            this.grpBilgiler.Controls.Add(this.lblAciklama);
            this.grpBilgiler.Controls.Add(this.lblHatAdi);
            this.grpBilgiler.Controls.Add(this.txtID);
            this.grpBilgiler.Controls.Add(this.lblID);
            this.grpBilgiler.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBilgiler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.grpBilgiler.Location = new System.Drawing.Point(16, 15);
            this.grpBilgiler.Margin = new System.Windows.Forms.Padding(4);
            this.grpBilgiler.Name = "grpBilgiler";
            this.grpBilgiler.Padding = new System.Windows.Forms.Padding(4);
            this.grpBilgiler.Size = new System.Drawing.Size(467, 369);
            this.grpBilgiler.TabIndex = 0;
            this.grpBilgiler.TabStop = false;
            this.grpBilgiler.Text = "Hat Bilgileri";
            // 
            // txtHatAdi
            // 
            this.txtHatAdi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHatAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.txtHatAdi.Location = new System.Drawing.Point(147, 92);
            this.txtHatAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtHatAdi.Name = "txtHatAdi";
            this.txtHatAdi.Size = new System.Drawing.Size(292, 29);
            this.txtHatAdi.TabIndex = 0;
            // 
            // rTxtAciklama
            // 
            this.rTxtAciklama.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rTxtAciklama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.rTxtAciklama.Location = new System.Drawing.Point(147, 142);
            this.rTxtAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.rTxtAciklama.Name = "rTxtAciklama";
            this.rTxtAciklama.Size = new System.Drawing.Size(292, 196);
            this.rTxtAciklama.TabIndex = 1;
            this.rTxtAciklama.Text = "";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.lblAciklama.Location = new System.Drawing.Point(27, 145);
            this.lblAciklama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(82, 23);
            this.lblAciklama.TabIndex = 3;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // lblHatAdi
            // 
            this.lblHatAdi.AutoSize = true;
            this.lblHatAdi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHatAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.lblHatAdi.Location = new System.Drawing.Point(27, 96);
            this.lblHatAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHatAdi.Name = "lblHatAdi";
            this.lblHatAdi.Size = new System.Drawing.Size(71, 23);
            this.lblHatAdi.TabIndex = 2;
            this.lblHatAdi.Text = "Hat Adı:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.txtID.Location = new System.Drawing.Point(147, 43);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(132, 29);
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
            this.lblID.Size = new System.Drawing.Size(63, 23);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Hat ID:";
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
            this.grpIslemler.Location = new System.Drawing.Point(16, 406);
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
            this.btnTemizle.TabIndex = 5;
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
            this.btnSil.TabIndex = 4;
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
            this.btnGuncelle.TabIndex = 3;
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
            this.btnEkle.TabIndex = 2;
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
            this.grpListe.Controls.Add(this.dgvHatlar);
            this.grpListe.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpListe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.grpListe.Location = new System.Drawing.Point(507, 15);
            this.grpListe.Margin = new System.Windows.Forms.Padding(4);
            this.grpListe.Name = "grpListe";
            this.grpListe.Padding = new System.Windows.Forms.Padding(4);
            this.grpListe.Size = new System.Drawing.Size(1056, 825);
            this.grpListe.TabIndex = 2;
            this.grpListe.TabStop = false;
            this.grpListe.Text = "Mevcut Hatlar";
            // 
            // dgvHatlar
            // 
            this.dgvHatlar.AllowUserToAddRows = false;
            this.dgvHatlar.AllowUserToDeleteRows = false;
            this.dgvHatlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHatlar.BackgroundColor = System.Drawing.Color.White;
            this.dgvHatlar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHatlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHatlar.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHatlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHatlar.Location = new System.Drawing.Point(4, 29);
            this.dgvHatlar.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHatlar.MultiSelect = false;
            this.dgvHatlar.Name = "dgvHatlar";
            this.dgvHatlar.ReadOnly = true;
            this.dgvHatlar.RowHeadersWidth = 51;
            this.dgvHatlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHatlar.Size = new System.Drawing.Size(1048, 792);
            this.dgvHatlar.TabIndex = 6;
            this.dgvHatlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHatlar_CellClick);
            // 
            // FrmHatlar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1579, 851);
            this.Controls.Add(this.grpListe);
            this.Controls.Add(this.grpIslemler);
            this.Controls.Add(this.grpBilgiler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHatlar";
            this.Text = "Hat Tanımlama Ekranı";
            this.Load += new System.EventHandler(this.FrmHatlar_Load);
            this.grpBilgiler.ResumeLayout(false);
            this.grpBilgiler.PerformLayout();
            this.grpIslemler.ResumeLayout(false);
            this.grpListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHatlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBilgiler;
        private System.Windows.Forms.TextBox txtHatAdi;
        private System.Windows.Forms.RichTextBox rTxtAciklama;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblHatAdi;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox grpIslemler;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox grpListe;
        private System.Windows.Forms.DataGridView dgvHatlar;
    }
}