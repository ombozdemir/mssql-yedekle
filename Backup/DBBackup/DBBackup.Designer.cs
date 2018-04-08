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
            this.cmbDataBase = new System.Windows.Forms.ComboBox();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.chk_Insec = new System.Windows.Forms.CheckBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_status = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.db_change = new System.Windows.Forms.Button();
            this.server_change = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_restore = new System.Windows.Forms.Button();
            this.btn_backup = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDataBase);
            this.groupBox1.Controls.Add(this.cmbServer);
            this.groupBox1.Controls.Add(this.chk_Insec);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pb_status);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.db_change);
            this.groupBox1.Controls.Add(this.server_change);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_restore);
            this.groupBox1.Controls.Add(this.btn_backup);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // cmbDataBase
            // 
            this.cmbDataBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBase.FormattingEnabled = true;
            this.cmbDataBase.Location = new System.Drawing.Point(323, 157);
            this.cmbDataBase.Name = "cmbDataBase";
            this.cmbDataBase.Size = new System.Drawing.Size(166, 23);
            this.cmbDataBase.TabIndex = 15;
            this.cmbDataBase.SelectedValueChanged += new System.EventHandler(this.cmbDataBase_SelectedValueChanged);
            this.cmbDataBase.Click += new System.EventHandler(this.cmbDataBase_Click);
            // 
            // cmbServer
            // 
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(323, 30);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(166, 23);
            this.cmbServer.TabIndex = 14;
            this.cmbServer.SelectedValueChanged += new System.EventHandler(this.cmbServer_SelectedValueChanged);
            // 
            // chk_Insec
            // 
            this.chk_Insec.AutoSize = true;
            this.chk_Insec.Location = new System.Drawing.Point(323, 125);
            this.chk_Insec.Name = "chk_Insec";
            this.chk_Insec.Size = new System.Drawing.Size(127, 19);
            this.chk_Insec.TabIndex = 13;
            this.chk_Insec.Text = "Integrated Security";
            this.chk_Insec.UseVisualStyleBackColor = true;
            this.chk_Insec.CheckedChanged += new System.EventHandler(this.chk_Insec_CheckedChanged);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(323, 64);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(166, 21);
            this.txt_username.TabIndex = 12;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(323, 98);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(166, 21);
            this.txt_password.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "User Name";
            // 
            // pb_status
            // 
            this.pb_status.Image = ((System.Drawing.Image)(resources.GetObject("pb_status.Image")));
            this.pb_status.Location = new System.Drawing.Point(6, 20);
            this.pb_status.Name = "pb_status";
            this.pb_status.Size = new System.Drawing.Size(226, 189);
            this.pb_status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_status.TabIndex = 8;
            this.pb_status.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Database";
            // 
            // db_change
            // 
            this.db_change.Location = new System.Drawing.Point(495, 157);
            this.db_change.Name = "db_change";
            this.db_change.Size = new System.Drawing.Size(61, 23);
            this.db_change.TabIndex = 3;
            this.db_change.Text = "Change";
            this.db_change.UseVisualStyleBackColor = true;
            this.db_change.Click += new System.EventHandler(this.db_change_Click);
            // 
            // server_change
            // 
            this.server_change.Location = new System.Drawing.Point(495, 29);
            this.server_change.Name = "server_change";
            this.server_change.Size = new System.Drawing.Size(61, 23);
            this.server_change.TabIndex = 3;
            this.server_change.Text = "Change";
            this.server_change.UseVisualStyleBackColor = true;
            this.server_change.Click += new System.EventHandler(this.server_change_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Name";
            // 
            // btn_restore
            // 
            this.btn_restore.Location = new System.Drawing.Point(414, 186);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(85, 30);
            this.btn_restore.TabIndex = 0;
            this.btn_restore.Text = "Restore";
            this.btn_restore.UseVisualStyleBackColor = true;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // btn_backup
            // 
            this.btn_backup.Location = new System.Drawing.Point(323, 186);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(85, 30);
            this.btn_backup.TabIndex = 0;
            this.btn_backup.Text = "Backup";
            this.btn_backup.UseVisualStyleBackColor = true;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // DBBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 244);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DBBackup";
            this.Text = "Backup/Restore DataBase";
            this.Load += new System.EventHandler(this.Backup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button server_change;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button db_change;
        private System.Windows.Forms.PictureBox pb_status;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk_Insec;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.ComboBox cmbDataBase;
    }
}