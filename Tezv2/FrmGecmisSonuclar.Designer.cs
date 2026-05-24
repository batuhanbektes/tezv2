namespace Tezv2
{
    partial class FrmGecmisSonuclar
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.chkTarihAraligi = new System.Windows.Forms.CheckBox();
            this.lblHatFiltre = new System.Windows.Forms.Label();
            this.cmbHatFiltre = new System.Windows.Forms.ComboBox();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnTumunuExcel = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDetayGor = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.dtBitis);
            this.pnlTop.Controls.Add(this.dtBaslangic);
            this.pnlTop.Controls.Add(this.chkTarihAraligi);
            this.pnlTop.Controls.Add(this.lblHatFiltre);
            this.pnlTop.Controls.Add(this.cmbHatFiltre);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1561, 98);
            this.pnlTop.TabIndex = 0;
            // 
            // dtBitis
            // 
            this.dtBitis.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.dtBitis.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtBitis.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.dtBitis.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtBitis.Enabled = false;
            this.dtBitis.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBitis.Location = new System.Drawing.Point(560, 46);
            this.dtBitis.Margin = new System.Windows.Forms.Padding(4);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(145, 29);
            this.dtBitis.TabIndex = 6;
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.dtBaslangic.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtBaslangic.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.dtBaslangic.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtBaslangic.Enabled = false;
            this.dtBaslangic.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBaslangic.Location = new System.Drawing.Point(400, 46);
            this.dtBaslangic.Margin = new System.Windows.Forms.Padding(4);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(145, 29);
            this.dtBaslangic.TabIndex = 5;
            // 
            // chkTarihAraligi
            // 
            this.chkTarihAraligi.AutoSize = true;
            this.chkTarihAraligi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkTarihAraligi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.chkTarihAraligi.Location = new System.Drawing.Point(400, 15);
            this.chkTarihAraligi.Margin = new System.Windows.Forms.Padding(4);
            this.chkTarihAraligi.Name = "chkTarihAraligi";
            this.chkTarihAraligi.Size = new System.Drawing.Size(176, 26);
            this.chkTarihAraligi.TabIndex = 4;
            this.chkTarihAraligi.Text = "Tarih Aralığı Filtrele";
            this.chkTarihAraligi.UseVisualStyleBackColor = true;
            this.chkTarihAraligi.CheckedChanged += new System.EventHandler(this.chkTarihAraligi_CheckedChanged);
            // 
            // lblHatFiltre
            // 
            this.lblHatFiltre.AutoSize = true;
            this.lblHatFiltre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHatFiltre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblHatFiltre.Location = new System.Drawing.Point(27, 18);
            this.lblHatFiltre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHatFiltre.Name = "lblHatFiltre";
            this.lblHatFiltre.Size = new System.Drawing.Size(137, 23);
            this.lblHatFiltre.TabIndex = 2;
            this.lblHatFiltre.Text = "Hata Göre Filtrele";
            // 
            // cmbHatFiltre
            // 
            this.cmbHatFiltre.BackColor = System.Drawing.Color.White;
            this.cmbHatFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHatFiltre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHatFiltre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbHatFiltre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.cmbHatFiltre.FormattingEnabled = true;
            this.cmbHatFiltre.Location = new System.Drawing.Point(27, 46);
            this.cmbHatFiltre.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHatFiltre.Name = "cmbHatFiltre";
            this.cmbHatFiltre.Size = new System.Drawing.Size(332, 29);
            this.cmbHatFiltre.TabIndex = 0;
            this.cmbHatFiltre.SelectedIndexChanged += new System.EventHandler(this.cmbHatFiltre_SelectedIndexChanged);
            // 
            // dgvListe
            // 
            this.dgvListe.AllowUserToAddRows = false;
            this.dgvListe.AllowUserToDeleteRows = false;
            this.dgvListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListe.BackgroundColor = System.Drawing.Color.White;
            this.dgvListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListe.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListe.Location = new System.Drawing.Point(0, 98);
            this.dgvListe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListe.MultiSelect = false;
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.ReadOnly = true;
            this.dgvListe.RowHeadersWidth = 51;
            this.dgvListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListe.Size = new System.Drawing.Size(1561, 620);
            this.dgvListe.TabIndex = 1;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.Controls.Add(this.btnTumunuExcel);
            this.pnlBottom.Controls.Add(this.btnSil);
            this.pnlBottom.Controls.Add(this.btnDetayGor);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 718);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1561, 86);
            this.pnlBottom.TabIndex = 2;
            // 
            // btnTumunuExcel
            // 
            this.btnTumunuExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTumunuExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnTumunuExcel.FlatAppearance.BorderSize = 0;
            this.btnTumunuExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTumunuExcel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumunuExcel.ForeColor = System.Drawing.Color.White;
            this.btnTumunuExcel.Location = new System.Drawing.Point(1041, 18);
            this.btnTumunuExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnTumunuExcel.Name = "btnTumunuExcel";
            this.btnTumunuExcel.Size = new System.Drawing.Size(240, 49);
            this.btnTumunuExcel.TabIndex = 2;
            this.btnTumunuExcel.Text = "LİSTEYİ EXCEL\'E AL";
            this.btnTumunuExcel.UseVisualStyleBackColor = false;
            this.btnTumunuExcel.Click += new System.EventHandler(this.btnTumunuExcel_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(27, 18);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(160, 49);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "KAYDI SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDetayGor
            // 
            this.btnDetayGor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetayGor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnDetayGor.FlatAppearance.BorderSize = 0;
            this.btnDetayGor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetayGor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDetayGor.ForeColor = System.Drawing.Color.White;
            this.btnDetayGor.Location = new System.Drawing.Point(1294, 18);
            this.btnDetayGor.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetayGor.Name = "btnDetayGor";
            this.btnDetayGor.Size = new System.Drawing.Size(240, 49);
            this.btnDetayGor.TabIndex = 0;
            this.btnDetayGor.Text = "DETAYLARI GÖR";
            this.btnDetayGor.UseVisualStyleBackColor = false;
            this.btnDetayGor.Click += new System.EventHandler(this.btnDetayGor_Click);
            // 
            // FrmGecmisSonuclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1561, 804);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGecmisSonuclar";
            this.Text = "Geçmiş Simülasyon Sonuçları";
            this.Load += new System.EventHandler(this.FrmGecmisSonuclar_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnDetayGor;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox cmbHatFiltre;
        private System.Windows.Forms.Label lblHatFiltre;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.CheckBox chkTarihAraligi;
        private System.Windows.Forms.Button btnTumunuExcel;
    }
}