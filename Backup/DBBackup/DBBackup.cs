using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.IO;

namespace DBBackupApp
{
    public partial class DBBackup : Form
    {
        DataTable dtServers = SmoApplication.EnumAvailableSqlServers(true);
        private static Server srvr;
        private string DBpath = Application.StartupPath;

        public DBBackup()
        {
            InitializeComponent();
        }

        private void Backup_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            WindowState = FormWindowState.Normal;
            cmbServer.Enabled = false;
            //cmbDataBase.Text = "Administrator";
            cmbDataBase.Enabled = false;

            try
            {
                chk_Insec.Checked = true;

                // If there are any servers
                if (dtServers.Rows.Count > 0)
                {
                    // Loop through each server in the DataTable
                    foreach (DataRow drServer in dtServers.Rows)
                    {
                        cmbServer.Items.Add(drServer["Name"]);
                        cmbServer.Text = Convert.ToString(drServer["Name"]);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: There are no available servers.\nOr there is an error while loading server name", "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }

        private void chk_Insec_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Insec.CheckState == CheckState.Checked)
            {
                txt_username.Enabled = false;
                txt_username.Text = string.Empty;

                txt_password.Enabled = false;
                txt_password.Text = string.Empty;
            }
            if (chk_Insec.CheckState == CheckState.Unchecked)
            {
                txt_username.Enabled = true;
                txt_password.Enabled = true;
            }
        }

        private void server_change_Click(object sender, EventArgs e)
        {
            cmbServer.Enabled = true;
        }

        private void cmbDataBase_Click(object sender, EventArgs e)
        {
            cmbDataBase.Items.Clear();
            try
            {
                if (cmbServer.SelectedItem != null && cmbServer.SelectedItem.ToString() != "")
                {
                    this.Cursor = Cursors.WaitCursor;
                    // Create a new connection to the selected server name
                    ServerConnection srvConn = new ServerConnection(cmbServer.SelectedItem.ToString());
                    // Log in using SQL authentication instead of Windows authentication
                    srvConn.LoginSecure = true;
                    if (chk_Insec.CheckState == CheckState.Checked)
                    {
                        // Create a new SQL Server object using the connection we created
                        srvr = new Server(srvConn);
                        // Loop through the databases list
                        foreach (Database dbServer in srvr.Databases)
                        {
                            // Add database to combobox
                            cmbDataBase.Items.Add(dbServer.Name);
                        }
                    }
                    if (chk_Insec.CheckState == CheckState.Unchecked)
                    {
                        // Give the login username
                        srvConn.Login = txt_username.Text;
                        // Give the login password
                        srvConn.Password = txt_password.Text;
                        // Create a new SQL Server object using the connection we created
                        srvr = new Server(srvConn);
                        // Loop through the databases list
                        foreach (Database dbServer in srvr.Databases)
                        {
                            // Add database to combobox
                            cmbDataBase.Items.Add(dbServer.Name);
                        }
                    }
                }
                else
                {
                    // A server was not selected, show an error message
                    MessageBox.Show("ERROR: Contact Administrator!!", "Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: An error ocurred while loading the avaiable DataBasees", "Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }

        private void db_change_Click(object sender, EventArgs e)
        {
            cmbDataBase.Enabled = true;
        }

        private void cmbServer_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbServer.Enabled = false;
        }

        private void cmbDataBase_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbDataBase.Enabled = false;
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            if (cmbDataBase.SelectedIndex.ToString().Equals(""))
            {
                MessageBox.Show("Please choose Database", "Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (srvr != null)
            {
                try
                {
                    btn_backup.Enabled = false;
                    btn_restore.Enabled = false;
                    db_change.Enabled = false;
                    server_change.Enabled = false;

                    //Use this line if you have already created a bakup file.
                    File.Delete(DBpath + "\\backup.bak");
                    this.Cursor = Cursors.WaitCursor;
                    // If the user has chosen a path where to save the backup file
                    // Create a new backup operation
                    Backup bkpDatabase = new Backup();
                    // Set the backup type to a database backup
                    bkpDatabase.Action = BackupActionType.Database;
                    // Set the database that we want to perform a backup on
                    bkpDatabase.Database = cmbDataBase.SelectedItem.ToString();
                    // Set the backup device to a file
                    BackupDeviceItem bkpDevice = new BackupDeviceItem(DBpath + "\\Backup.bak", DeviceType.File);
                    // Add the backup device to the backup
                    bkpDatabase.Devices.Add(bkpDevice);
                    // Perform the backup
                    bkpDatabase.SqlBackup(srvr);
                    MessageBox.Show("Bakup of Database " + cmbDataBase.Text + " successfully created", "Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR: An error ocurred while backing up DataBase"+x, "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.Cursor = Cursors.Arrow;

                    btn_backup.Enabled = true;
                    btn_restore.Enabled = true;
                    db_change.Enabled = true;
                    server_change.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("ERROR: A connection to a SQL server was not established.", "Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Arrow;
            }
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            if (cmbDataBase.SelectedIndex.ToString().Equals(""))
            {
                MessageBox.Show("Please choose Database", "Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // If there was a SQL connection created
            if (srvr != null)
            {
                try
                {
                    btn_backup.Enabled = false;
                    btn_restore.Enabled = false;
                    db_change.Enabled = false;
                    server_change.Enabled = false;

                    this.Cursor = Cursors.WaitCursor;
                    // If the user has chosen the file from which he wants the database to be restored
                    // Create a new database restore operation
                    Restore rstDatabase = new Restore();
                    // Set the restore type to a database restore
                    rstDatabase.Action = RestoreActionType.Database;
                    // Set the database that we want to perform the restore on
                    rstDatabase.Database = cmbDataBase.SelectedItem.ToString();
                    // Set the backup device from which we want to restore, to a file
                    BackupDeviceItem bkpDevice = new BackupDeviceItem(DBpath + "\\Backup.bak", DeviceType.File);
                    // Add the backup device to the restore type
                    rstDatabase.Devices.Add(bkpDevice);
                    // If the database already exists, replace it
                    rstDatabase.ReplaceDatabase = true;
                    // Perform the restore
                    rstDatabase.SqlRestore(srvr);
                    MessageBox.Show("Database " + cmbDataBase.Text + " succefully restored", "Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR: An error ocurred while restoring the database", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.Cursor = Cursors.Arrow;

                    btn_backup.Enabled = true;
                    btn_restore.Enabled = true;
                    db_change.Enabled = true;
                    server_change.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("ERROR: A connection to a SQL server was not established.", "Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Arrow;
            }
        }
    }
}
