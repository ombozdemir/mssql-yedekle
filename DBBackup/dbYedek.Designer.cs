namespace DBBackupApp
{
    partial class DBBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBBackup));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFtpYukle = new System.Windows.Forms.Button();
            this.lbReport = new System.Windows.Forms.Label();
            this.btnSikistir = new System.Windows.Forms.Button();
            this.lstDurum = new System.Windows.Forms.ListBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pb_status = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnOku = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAyarlar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFtpYukle);
            this.groupBox1.Controls.Add(this.lbReport);
            this.groupBox1.Controls.Add(this.btnSikistir);
            this.groupBox1.Controls.Add(this.lstDurum);
            this.groupBox1.Controls.Add(this.btnUpload);
            this.groupBox1.Controls.Add(this.pb_status);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnFtpYukle
            // 
            this.btnFtpYukle.Location = new System.Drawing.Point(400, 20);
            this.btnFtpYukle.Name = "btnFtpYukle";
            this.btnFtpYukle.Size = new System.Drawing.Size(192, 62);
            this.btnFtpYukle.TabIndex = 30;
            this.btnFtpYukle.Text = "Yükle";
            this.btnFtpYukle.UseVisualStyleBackColor = true;
            this.btnFtpYukle.Click += new System.EventHandler(this.btnFtpYukle_Click);
            // 
            // lbReport
            // 
            this.lbReport.AutoSize = true;
            this.lbReport.Location = new System.Drawing.Point(365, 317);
            this.lbReport.Name = "lbReport";
            this.lbReport.Size = new System.Drawing.Size(16, 15);
            this.lbReport.TabIndex = 29;
            this.lbReport.Text = "...";
            // 
            // btnSikistir
            // 
            this.btnSikistir.Location = new System.Drawing.Point(199, 20);
            this.btnSikistir.Name = "btnSikistir";
            this.btnSikistir.Size = new System.Drawing.Size(169, 62);
            this.btnSikistir.TabIndex = 28;
            this.btnSikistir.Text = "Sýkýþtýr";
            this.btnSikistir.UseVisualStyleBackColor = true;
            this.btnSikistir.Click += new System.EventHandler(this.btnSikistir_Click);
            // 
            // lstDurum
            // 
            this.lstDurum.FormattingEnabled = true;
            this.lstDurum.ItemHeight = 15;
            this.lstDurum.Location = new System.Drawing.Point(252, 107);
            this.lstDurum.Name = "lstDurum";
            this.lstDurum.Size = new System.Drawing.Size(340, 184);
            this.lstDurum.TabIndex = 27;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(6, 20);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(164, 62);
            this.btnUpload.TabIndex = 26;
            this.btnUpload.Text = "Oluþtur";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pb_status
            // 
            this.pb_status.Image = ((System.Drawing.Image)(resources.GetObject("pb_status.Image")));
            this.pb_status.Location = new System.Drawing.Point(6, 107);
            this.pb_status.Name = "pb_status";
            this.pb_status.Size = new System.Drawing.Size(226, 189);
            this.pb_status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_status.TabIndex = 8;
            this.pb_status.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(622, 346);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(614, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = ".";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnOku);
            this.tabPage2.Controls.Add(this.btnKaydet);
            this.tabPage2.Controls.Add(this.txtAyarlar);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(614, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ayarlar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnOku
            // 
            this.btnOku.Location = new System.Drawing.Point(426, 6);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(180, 98);
            this.btnOku.TabIndex = 2;
            this.btnOku.Text = "OKU";
            this.btnOku.UseVisualStyleBackColor = true;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(426, 122);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(180, 98);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAyarlar
            // 
            this.txtAyarlar.Location = new System.Drawing.Point(6, 6);
            this.txtAyarlar.Multiline = true;
            this.txtAyarlar.Name = "txtAyarlar";
            this.txtAyarlar.Size = new System.Drawing.Size(414, 309);
            this.txtAyarlar.TabIndex = 0;
            // 
            // DBBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 346);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DBBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "test sistem";
            this.Load += new System.EventHandler(this.Backup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pb_status;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.ListBox lstDurum;
        private System.Windows.Forms.Button btnSikistir;
        private System.Windows.Forms.Label lbReport;
        private System.Windows.Forms.Button btnFtpYukle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAyarlar;
        private System.Windows.Forms.Button btnOku;
    }
}