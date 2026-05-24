namespace Tezv2
{
    partial class FrmOnculDiyagrami
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblHat = new System.Windows.Forms.Label();
            this.cmbHat = new System.Windows.Forms.ComboBox();
            this.pnlZoom = new System.Windows.Forms.Panel();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.lblZoomOran = new System.Windows.Forms.Label();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomReset = new System.Windows.Forms.Button();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            this.pnlZoom.SuspendLayout();
            this.pnlCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblHat);
            this.pnlTop.Controls.Add(this.cmbHat);
            this.pnlTop.Controls.Add(this.pnlZoom);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1579, 74);
            this.pnlTop.TabIndex = 0;
            // 
            // lblHat
            // 
            this.lblHat.AutoSize = true;
            this.lblHat.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblHat.Location = new System.Drawing.Point(16, 25);
            this.lblHat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHat.Name = "lblHat";
            this.lblHat.Size = new System.Drawing.Size(193, 25);
            this.lblHat.TabIndex = 1;
            this.lblHat.Text = "Görüntülenecek Hat:";
            // 
            // cmbHat
            // 
            this.cmbHat.BackColor = System.Drawing.Color.White;
            this.cmbHat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbHat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.cmbHat.FormattingEnabled = true;
            this.cmbHat.Location = new System.Drawing.Point(223, 21);
            this.cmbHat.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHat.Name = "cmbHat";
            this.cmbHat.Size = new System.Drawing.Size(399, 33);
            this.cmbHat.TabIndex = 0;
            this.cmbHat.SelectedIndexChanged += new System.EventHandler(this.cmbHat_SelectedIndexChanged);
            // 
            // pnlZoom
            // 
            this.pnlZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlZoom.BackColor = System.Drawing.Color.White;
            this.pnlZoom.Controls.Add(this.btnZoomOut);
            this.pnlZoom.Controls.Add(this.lblZoomOran);
            this.pnlZoom.Controls.Add(this.btnZoomIn);
            this.pnlZoom.Controls.Add(this.btnZoomReset);
            this.pnlZoom.Location = new System.Drawing.Point(1060, 12);
            this.pnlZoom.Margin = new System.Windows.Forms.Padding(4);
            this.pnlZoom.Name = "pnlZoom";
            this.pnlZoom.Size = new System.Drawing.Size(505, 50);
            this.pnlZoom.TabIndex = 2;
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnZoomOut.FlatAppearance.BorderSize = 0;
            this.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomOut.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZoomOut.ForeColor = System.Drawing.Color.White;
            this.btnZoomOut.Location = new System.Drawing.Point(107, 5);
            this.btnZoomOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(80, 40);
            this.btnZoomOut.TabIndex = 3;
            this.btnZoomOut.Text = "−";
            this.btnZoomOut.UseVisualStyleBackColor = false;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // lblZoomOran
            // 
            this.lblZoomOran.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZoomOran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblZoomOran.Location = new System.Drawing.Point(195, 5);
            this.lblZoomOran.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZoomOran.Name = "lblZoomOran";
            this.lblZoomOran.Size = new System.Drawing.Size(100, 40);
            this.lblZoomOran.TabIndex = 2;
            this.lblZoomOran.Text = "%100";
            this.lblZoomOran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnZoomIn.FlatAppearance.BorderSize = 0;
            this.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomIn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZoomIn.ForeColor = System.Drawing.Color.White;
            this.btnZoomIn.Location = new System.Drawing.Point(19, 5);
            this.btnZoomIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(80, 40);
            this.btnZoomIn.TabIndex = 1;
            this.btnZoomIn.Text = "+";
            this.btnZoomIn.UseVisualStyleBackColor = false;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomReset
            // 
            this.btnZoomReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.btnZoomReset.FlatAppearance.BorderSize = 0;
            this.btnZoomReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomReset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZoomReset.ForeColor = System.Drawing.Color.White;
            this.btnZoomReset.Location = new System.Drawing.Point(303, 5);
            this.btnZoomReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnZoomReset.Name = "btnZoomReset";
            this.btnZoomReset.Size = new System.Drawing.Size(187, 40);
            this.btnZoomReset.TabIndex = 0;
            this.btnZoomReset.Text = "SIFIRLA (%100)";
            this.btnZoomReset.UseVisualStyleBackColor = false;
            this.btnZoomReset.Click += new System.EventHandler(this.btnZoomReset_Click);
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.AutoScroll = true;
            this.pnlCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.pnlCanvas.Controls.Add(this.pbCanvas);
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Location = new System.Drawing.Point(0, 74);
            this.pnlCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(1579, 777);
            this.pnlCanvas.TabIndex = 1;
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.White;
            this.pbCanvas.Location = new System.Drawing.Point(0, 0);
            this.pbCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(1579, 777);
            this.pbCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // FrmOnculDiyagrami
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1579, 851);
            this.Controls.Add(this.pnlCanvas);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOnculDiyagrami";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öncül İlişkileri Diyagramı";
            this.Load += new System.EventHandler(this.FrmOnculDiyagrami_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlZoom.ResumeLayout(false);
            this.pnlCanvas.ResumeLayout(false);
            this.pnlCanvas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.ComboBox cmbHat;
        private System.Windows.Forms.Label lblHat;
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Panel pnlZoom;
        private System.Windows.Forms.Button btnZoomReset;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Label lblZoomOran;
    }
}