namespace Tezv2
{
    partial class FrmOnculAyarlari
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.cmbHat = new System.Windows.Forms.ComboBox();
            this.lblHatSecimi = new System.Windows.Forms.Label();
            this.grpAnaIsler = new System.Windows.Forms.GroupBox();
            this.dgvKaynakIsler = new System.Windows.Forms.DataGridView();
            this.grpOnculler = new System.Windows.Forms.GroupBox();
            this.lstOnculler = new System.Windows.Forms.CheckedListBox();
            this.lblSeciliIs = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.grpAnaIsler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKaynakIsler)).BeginInit();
            this.grpOnculler.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.cmbHat);
            this.pnlTop.Controls.Add(this.lblHatSecimi);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1579, 74);
            this.pnlTop.TabIndex = 0;
            // 
            // cmbHat
            // 
            this.cmbHat.BackColor = System.Drawing.Color.White;
            this.cmbHat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbHat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.cmbHat.FormattingEnabled = true;
            this.cmbHat.Location = new System.Drawing.Point(147, 22);
            this.cmbHat.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHat.Name = "cmbHat";
            this.cmbHat.Size = new System.Drawing.Size(332, 29);
            this.cmbHat.TabIndex = 0;
            this.cmbHat.SelectedIndexChanged += new System.EventHandler(this.cmbHat_SelectedIndexChanged);
            // 
            // lblHatSecimi
            // 
            this.lblHatSecimi.AutoSize = true;
            this.lblHatSecimi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHatSecimi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblHatSecimi.Location = new System.Drawing.Point(20, 25);
            this.lblHatSecimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHatSecimi.Name = "lblHatSecimi";
            this.lblHatSecimi.Size = new System.Drawing.Size(114, 25);
            this.lblHatSecimi.TabIndex = 0;
            this.lblHatSecimi.Text = "Hat Seçimi:";
            // 
            // grpAnaIsler
            // 
            this.grpAnaIsler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpAnaIsler.BackColor = System.Drawing.Color.White;
            this.grpAnaIsler.Controls.Add(this.dgvKaynakIsler);
            this.grpAnaIsler.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpAnaIsler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.grpAnaIsler.Location = new System.Drawing.Point(16, 86);
            this.grpAnaIsler.Margin = new System.Windows.Forms.Padding(4);
            this.grpAnaIsler.Name = "grpAnaIsler";
            this.grpAnaIsler.Padding = new System.Windows.Forms.Padding(4);
            this.grpAnaIsler.Size = new System.Drawing.Size(733, 677);
            this.grpAnaIsler.TabIndex = 1;
            this.grpAnaIsler.TabStop = false;
            this.grpAnaIsler.Text = "1. Adım: Ana İşlemi Seçiniz (Kime öncül atanacak?)";
            // 
            // dgvKaynakIsler
            // 
            this.dgvKaynakIsler.AllowUserToAddRows = false;
            this.dgvKaynakIsler.AllowUserToDeleteRows = false;
            this.dgvKaynakIsler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKaynakIsler.BackgroundColor = System.Drawing.Color.White;
            this.dgvKaynakIsler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKaynakIsler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKaynakIsler.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKaynakIsler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKaynakIsler.Location = new System.Drawing.Point(4, 29);
            this.dgvKaynakIsler.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKaynakIsler.MultiSelect = false;
            this.dgvKaynakIsler.Name = "dgvKaynakIsler";
            this.dgvKaynakIsler.ReadOnly = true;
            this.dgvKaynakIsler.RowHeadersWidth = 51;
            this.dgvKaynakIsler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKaynakIsler.Size = new System.Drawing.Size(725, 644);
            this.dgvKaynakIsler.TabIndex = 1;
            this.dgvKaynakIsler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKaynakIsler_CellClick);
            // 
            // grpOnculler
            // 
            this.grpOnculler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOnculler.BackColor = System.Drawing.Color.White;
            this.grpOnculler.Controls.Add(this.lstOnculler);
            this.grpOnculler.Controls.Add(this.lblSeciliIs);
            this.grpOnculler.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpOnculler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.grpOnculler.Location = new System.Drawing.Point(773, 86);
            this.grpOnculler.Margin = new System.Windows.Forms.Padding(4);
            this.grpOnculler.Name = "grpOnculler";
            this.grpOnculler.Padding = new System.Windows.Forms.Padding(4);
            this.grpOnculler.Size = new System.Drawing.Size(789, 677);
            this.grpOnculler.TabIndex = 2;
            this.grpOnculler.TabStop = false;
            this.grpOnculler.Text = "2. Adım: Öncülleri İşaretleyiniz";
            // 
            // lstOnculler
            // 
            this.lstOnculler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstOnculler.BackColor = System.Drawing.Color.White;
            this.lstOnculler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstOnculler.CheckOnClick = true;
            this.lstOnculler.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstOnculler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.lstOnculler.FormattingEnabled = true;
            this.lstOnculler.Location = new System.Drawing.Point(27, 74);
            this.lstOnculler.Margin = new System.Windows.Forms.Padding(4);
            this.lstOnculler.Name = "lstOnculler";
            this.lstOnculler.Size = new System.Drawing.Size(732, 571);
            this.lstOnculler.TabIndex = 2;
            // 
            // lblSeciliIs
            // 
            this.lblSeciliIs.AutoSize = true;
            this.lblSeciliIs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeciliIs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSeciliIs.Location = new System.Drawing.Point(21, 37);
            this.lblSeciliIs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeciliIs.Name = "lblSeciliIs";
            this.lblSeciliIs.Size = new System.Drawing.Size(209, 23);
            this.lblSeciliIs.TabIndex = 0;
            this.lblSeciliIs.Text = "Seçili Ana İşlem: [YOK]";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.Controls.Add(this.btnKaydet);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 776);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1579, 75);
            this.pnlBottom.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(1296, 12);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(267, 49);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "İLİŞKİLERİ KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FrmOnculAyarlari
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1579, 851);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.grpOnculler);
            this.Controls.Add(this.grpAnaIsler);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOnculAyarlari";
            this.Text = "Öncül İlişkileri Yönetimi";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpAnaIsler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKaynakIsler)).EndInit();
            this.grpOnculler.ResumeLayout(false);
            this.grpOnculler.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.ComboBox cmbHat;
        private System.Windows.Forms.Label lblHatSecimi;
        private System.Windows.Forms.GroupBox grpAnaIsler;
        private System.Windows.Forms.DataGridView dgvKaynakIsler;
        private System.Windows.Forms.GroupBox grpOnculler;
        private System.Windows.Forms.CheckedListBox lstOnculler;
        private System.Windows.Forms.Label lblSeciliIs;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnKaydet;
    }
}