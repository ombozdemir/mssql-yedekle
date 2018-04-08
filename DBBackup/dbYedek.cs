using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.IO;
using System.Net;
using System.IO.Compression;
using Ionic.Zip;
using System.Threading;
using WinSCP;

namespace DBBackupApp
{
    public partial class DBBackup : Form
    {
        DataTable dtServers = SmoApplication.EnumAvailableSqlServers(true);
        private static Server srvr;
        private string DBpath = @"c:\dbyedek";// Application.StartupPath;
        private string infPath = Application.StartupPath;
        public string server_name;
        public string ftp_name;
        public string ftp_pass;
        public string ftp_url;
        public string yedek_zamani;
        public string[] dbi = new string[10];
        private System.Threading.Timer timer;   

        public DBBackup()
        {
            InitializeComponent();
 
        }

        private void Backup_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            WindowState = FormWindowState.Normal;
            this.Cursor = Cursors.Default;
            string[] lines = System.IO.File.ReadAllLines(infPath + @"\conf.txt");
            server_name = lines[0].ToString();
            ftp_name = lines[1].ToString();
            ftp_pass = lines[2].ToString();
            ftp_url = lines[3].ToString();
            yedek_zamani = lines[4].ToString();
            for (int i = 1; i < 10; i++)
            {
                dbi[i] = lines[4 + i].ToString();
            }
            string[] zamans;
            char[] delimiters = new char[] { ':' };
            zamans = yedek_zamani.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
           // SetUpTimer(new TimeSpan(Convert.ToInt16(zamans[0]), Convert.ToInt16(zamans[1]), Convert.ToInt16(zamans[2])));
        }
        private void SetUpTimer(TimeSpan alertTime)
        {
            /*
            DateTime current = DateTime.Now;
            TimeSpan timeToGo = alertTime - current.TimeOfDay;
            if (timeToGo < TimeSpan.Zero)
            {
                return; 
            }
            this.timer = new System.Threading.Timer(x =>
            {
                this.SomeMethodRunsAt1900();
            }, null, timeToGo, Timeout.InfiniteTimeSpan);
             * */
        }

        private void SomeMethodRunsAt1900()
        {
            //zamanlama yapýlacak
        }
   
        private void uploadFile(string FTPAddress, string filePath, string username, string password)
        {
            //Create FTP request
            FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(FTPAddress + "/Public/" + Path.GetFileName(filePath));

            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(username, password);
            request.UsePassive = true;
            request.UseBinary = true;
            request.KeepAlive = true;
            request.Timeout = 99999999;


            //Load the file
            FileStream stream = File.OpenRead(filePath);
            byte[] buffer = new byte[stream.Length];

            stream.Read(buffer, 0, buffer.Length);
            stream.Close();

            //Upload file
            Stream reqStream = request.GetRequestStream();
            reqStream.Write(buffer, 0, buffer.Length);
            reqStream.Close();

            MessageBox.Show("Yükleme baþarýlý");
        }
        private void clearFolder(string FolderName)
        {
            DirectoryInfo dir = new DirectoryInfo(FolderName);

            foreach (FileInfo fi in dir.GetFiles())
            {
                fi.Delete();
            }

            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                clearFolder(di.FullName);
                di.Delete();
            }
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            clearFolder(DBpath);

            lstDurum.Items.Clear();
            this.Cursor = Cursors.WaitCursor;
            ServerConnection srvConn = new ServerConnection(server_name);
            srvConn.LoginSecure = true;
            srvr = new Server(srvConn);

            try
            {
                for (int i = 1; i < 10; i++)
                {
                    if (dbi[i] != "")
                    {
 
                        File.Delete(DBpath + dbi[i]);
                        this.Cursor = Cursors.WaitCursor;
                        Backup bkpDatabase = new Backup();
                        bkpDatabase.Action = BackupActionType.Database;
                        bkpDatabase.Database = dbi[i];
                        BackupDeviceItem bkpDevice = new BackupDeviceItem(DBpath + @"\"+dbi[i], DeviceType.File);
                        bkpDatabase.Devices.Add(bkpDevice);
                        bkpDatabase.SqlBackup(srvr);
                        DateTime now = DateTime.Now;
                        lstDurum.Items.Add(dbi[i] + " Datasý yedeði oluþturuldu ->" + now.ToShortTimeString());
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Hata: Yedek oluþturulamadý " + x, "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
 
            }

         
            
        }

        private void btnFtpYukle_Click(object sender, EventArgs e)
        {

            ftp_pass = ftp_pass.Replace("~", "");
            ftp_pass = ftp_pass.Replace("*", "");
            ftp_pass = ftp_pass.Replace(" ", "");
            ftp_pass = ftp_pass.Replace("bzdmr", "");
            ftp_pass = Reverse(ftp_pass);
            btnUpload.Enabled = false;
            Application.DoEvents();
            DateTime now2 = DateTime.Now;
            string gun_rakami = DateTime.Now.Day.ToString();

           // uploadFile(@"ftp:\\" + ftp_url, @"c:\dbyedekupload\yedek-"+gun_rakami+".zip", ftp_name, ftp_pass);

            SessionOptions sessionOptions = new SessionOptions
            {
                Protocol = WinSCP.Protocol.Ftp,
                HostName = "bzdmr",
                UserName = "bzdmr",
                Password = "bzdmr",
            };

            using (Session session = new Session())
            {
                // Connect
                session.Open(sessionOptions);

                // Upload files
                TransferOptions transferOptions = new TransferOptions();
                transferOptions.TransferMode = TransferMode.Binary;

                TransferOperationResult transferResult;
                transferResult = session.PutFiles(@"c:\dbyedek\*", "/yedek/", false, transferOptions);

                // Throw on any error
                transferResult.Check();

                // Print results
                foreach (TransferEventArgs transfer in transferResult.Transfers)
                {
                    lstDurum.Items.Add("Yedekleme  sunucuya yüklendindý ->" + now2.ToShortTimeString());

                }
            }


            btnUpload.Enabled = true;
            lstDurum.Items.Add("Yedekleme uzak sunucuya yüklendindý ->" + now2.ToShortTimeString());

        }

        public string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            txtAyarlar.Clear();
            string[] lines1 = System.IO.File.ReadAllLines(infPath + @"\conf.txt");

            for (int i = 0; i < lines1.Length; i++)
            {
                txtAyarlar.Text+= lines1[i].ToString()+"\r\n";
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(infPath + @"\conf.txt", txtAyarlar.Text);
        }
     
        private void btnSikistir_Click(object sender, EventArgs e)
        {
            Array.ForEach(Directory.GetFiles(@"c:\dbyedekupload\"),
 delegate(string path) { File.Delete(path); });

            DateTime now3 = DateTime.Now;
            string gun_rakami = DateTime.Now.Day.ToString();

            string DirectoryToZip = @"c:\dbyedek";
            string ZipFileToCreate = @"c:\dbyedekupload\yedek-" + gun_rakami + ".zip";
            try
            {
                using (ZipFile zip = new ZipFile())
                {
                    String[] filenames = System.IO.Directory.GetFiles(DirectoryToZip);
                    foreach (String filename in filenames)
                    {
                        ZipEntry ee = zip.AddFile(filename);
                    }

                    zip.Save(ZipFileToCreate);
                }

                lstDurum.Items.Add("Yedek kalasörü sýkýstýrýldý ->" + now3.ToShortTimeString());
            }
            catch (System.Exception ex1)
            {
                System.Console.Error.WriteLine("exception: " + ex1);
                lstDurum.Items.Add("Yedek kalasörü sýkýstýrma hatasý ->" + now3.ToShortTimeString());
            }
        }


    }
}
