using GNUCash_Backups.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;


namespace GNUCash_Backups
{
    public partial class FrmGNUCash : Form
    {
        public FrmGNUCash()

        {
            InitializeComponent();
            MainDirPath = Settings.Default.MainDirPath;
            CloudDirPath = Settings.Default.CloudDirPath;
            ExtraDirPath = Settings.Default.ExtraDirPath;
                     
        }
        public static string MainDirPath = Settings.Default.@MainDirPath;
        private static string CloudDirPath = Settings.Default.@CloudDirPath;
        public static string ExtraDirPath = Settings.Default.@ExtraDirPath;
        public static int originalyear = DateTime.Now.Year;
        public static string year = Convert.ToString(originalyear);
        public static string nameoffile;
        public static string oldyear;
        public static string yearlessone = Convert.ToString(DateTime.Now.Year - 1);
        public static int Choice = 0;
        public static string fileName = "1984-" + year + ".gnucash";
        public static string enobugpg = CloudDirPath + @"\" + fileName + ".gpg";
        public static string ebugpg = CloudDirPath + @"\Backup Files\" + fileName + ".gpg";
        public static string enobureg = CloudDirPath + @"\" + fileName;
        
        private void BtNoBU_Click(object sender, EventArgs e)
        {
            Choice = 1;
            this.Backup();
        }
        private void BtBUCLD_Click(object sender, EventArgs e)
        {
            Choice = 2;
            this.Backup();
        }
        private void BtBUCLDandDrive_Click(object sender, EventArgs e)
        {
            Choice = 3;
            this.Backup();
        }
        private void Backup()
        {
            WindowState = FormWindowState.Minimized;
            try
            {
                // Run GNNUCash Program
                var GNUCash = Process.Start(nameoffile, "/n");
                GNUCash.WaitForExit();
                GNUCash.Close();
                GNUCash.Dispose();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (Choice <= 1)      // Don't do any extra Backups just Close Program.
            {
                this.Close();
            }
            else
            {
                // Copy Copleted Files from D: Drive to E:\ & I:\ Drive.
                try
                {
                    // Delete original encrypted file to avoid delete prompt from encryption bat file
                    File.Delete(enobugpg);
                    File.Delete(ebugpg);

                    File.Copy(nameoffile, enobureg, true);
                    File.Copy(nameoffile, @MainDirPath + @"\Backup Files\" + fileName, true);

                    // Encrypt file stored in cloud
                    Directory.SetCurrentDirectory(CloudDirPath);
                    ProcessStartInfo gpg = new ProcessStartInfo(
                    @"gpg.exe", @"--no-options --yes --recipient ""Charles Maybury"" --encrypt ""*.gnucash""");
                    
                    Process.Start(gpg);
                    // This must be included or following Copy & Delete does not work.                    
                    Thread.Sleep(4000);

                    File.Copy(enobugpg, ebugpg, true);
                    // Delete original Unencrypted file after gpg file created and copy of encrypted file sent to Backup Files.
                    File.Delete(enobureg);
                }
                
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("There was a problem!");
                    Console.WriteLine("Make Sure " + ex + " file exists.");
                    Console.ReadLine();
                }

                catch (DirectoryNotFoundException ex)
                {
                    Console.WriteLine("There was a problem!");
                    Console.WriteLine("Make sure the " + ex + " directory exists.");
                    Console.ReadLine();
                }
                
                this.Close();
                
                if (Choice == 3)     // Extra Backup to ?: Drive

                {
                    System.IO.File.Copy(nameoffile, (ExtraDirPath + @"\" + fileName), true);
                }
                this.Close();
            }
        }
        // Check for change of year to update year in file Name.
        private void FrmGNUCash_Load_1(object sender, EventArgs e)
        {
            if (File.Exists(MainDirPath + @"\" + "1984-" + year + ".gnucash"))
            {
                nameoffile = MainDirPath + @"\" + "1984-" + year + ".gnucash";
                fileName = "1984-" + year + ".gnucash";
            }
            else
            {
                
                nameoffile = (MainDirPath + @"\" + "1984-" + yearlessone + ".gnucash");
                oldyear = (MainDirPath + @"\" + "1984-" + year + ".gnucash");

                File.Copy(@nameoffile, oldyear);
                nameoffile = MainDirPath + @"\" + "1984-" + year + ".gnucash";
                fileName = "1984-" + year + ".gnucash";
            }
         }
        private void MnuMainDir_Click(object sender, EventArgs e)
        {
            MainDirPath = (string)Settings.Default.MainDirPath;
                                       
                FolderBrowserDialog.SelectedPath = MainDirPath;
                FolderBrowserDialog.ShowDialog();
                MainDirPath = FolderBrowserDialog.SelectedPath;
                Directory.CreateDirectory(MainDirPath + @"\Backup Files"); // Add Backup Directory if not exist.
                nameoffile = MainDirPath + @"\" + "1984-" + year + ".gnucash";
                fileName = "1984-" + year + ".gnucash";
                Settings.Default.MainDirPath = MainDirPath;
                Settings.Default.Save();
        }
        private void MnuCloudDir_Click(object sender, EventArgs e)
        {
            CloudDirPath = (string)Settings.Default.CloudDirPath;

            {
                FolderBrowserDialog.SelectedPath = CloudDirPath;
                FolderBrowserDialog.ShowDialog();
                CloudDirPath = FolderBrowserDialog.SelectedPath;
                Directory.CreateDirectory(CloudDirPath + @"\Backup Files"); // Add Backup Directory if not exist.
                Settings.Default.CloudDirPath = CloudDirPath;
                Settings.Default.Save();
                enobugpg = CloudDirPath + @"\" + fileName + ".gpg";
                ebugpg = CloudDirPath + @"\Backup Files\" + fileName + ".gpg";
                enobureg = CloudDirPath + @"\" + fileName;
            }
        }
        private void MnuExtraDir_Click(object sender, EventArgs e)
        {
            ExtraDirPath = (string)Settings.Default.ExtraDirPath;
                                       
                FolderBrowserDialog.SelectedPath = ExtraDirPath;
                FolderBrowserDialog.ShowDialog();
                ExtraDirPath = FolderBrowserDialog.SelectedPath;
                Settings.Default.ExtraDirPath = ExtraDirPath;
                Settings.Default.Save();
                                         
        }
        private void MnuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }
    }
}
