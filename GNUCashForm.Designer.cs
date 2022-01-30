using System;

namespace GNUCash_Backups
{
    partial class FrmGNUCash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGNUCash));
            this.BtNoBU = new System.Windows.Forms.Button();
            this.BtBUCLD = new System.Windows.Forms.Button();
            this.BtBUCLDandDrive = new System.Windows.Forms.Button();
            this.TxHeader1 = new System.Windows.Forms.TextBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxHeader2 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MnuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMainDir = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCloudDir = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExtraDir = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.MnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtNoBU
            // 
            this.BtNoBU.BackColor = System.Drawing.Color.Chocolate;
            this.BtNoBU.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtNoBU.FlatAppearance.BorderSize = 40;
            this.BtNoBU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtNoBU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtNoBU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtNoBU.Location = new System.Drawing.Point(45, 192);
            this.BtNoBU.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtNoBU.Name = "BtNoBU";
            this.BtNoBU.Size = new System.Drawing.Size(468, 62);
            this.BtNoBU.TabIndex = 1;
            this.BtNoBU.TabStop = false;
            this.BtNoBU.Text = "Backup Only on Main Drive ";
            this.BtNoBU.UseVisualStyleBackColor = false;
            this.BtNoBU.Click += new System.EventHandler(this.BtNoBU_Click);
            // 
            // BtBUCLD
            // 
            this.BtBUCLD.BackColor = System.Drawing.Color.Chocolate;
            this.BtBUCLD.CausesValidation = false;
            this.BtBUCLD.FlatAppearance.BorderSize = 40;
            this.BtBUCLD.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtBUCLD.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtBUCLD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtBUCLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBUCLD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtBUCLD.Location = new System.Drawing.Point(45, 311);
            this.BtBUCLD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtBUCLD.Name = "BtBUCLD";
            this.BtBUCLD.Size = new System.Drawing.Size(468, 62);
            this.BtBUCLD.TabIndex = 2;
            this.BtBUCLD.TabStop = false;
            this.BtBUCLD.Text = "Backup on Second Drive and Cloud";
            this.BtBUCLD.UseVisualStyleBackColor = false;
            this.BtBUCLD.Click += new System.EventHandler(this.BtBUCLD_Click);
            // 
            // BtBUCLDandDrive
            // 
            this.BtBUCLDandDrive.BackColor = System.Drawing.Color.Chocolate;
            this.BtBUCLDandDrive.FlatAppearance.BorderSize = 40;
            this.BtBUCLDandDrive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtBUCLDandDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBUCLDandDrive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtBUCLDandDrive.Location = new System.Drawing.Point(45, 429);
            this.BtBUCLDandDrive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtBUCLDandDrive.Name = "BtBUCLDandDrive";
            this.BtBUCLDandDrive.Size = new System.Drawing.Size(468, 62);
            this.BtBUCLDandDrive.TabIndex = 3;
            this.BtBUCLDandDrive.Text = "Backup Cloud and Two Other Drives";
            this.BtBUCLDandDrive.UseVisualStyleBackColor = false;
            this.BtBUCLDandDrive.Click += new System.EventHandler(this.BtBUCLDandDrive_Click);
            // 
            // TxHeader1
            // 
            this.TxHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxHeader1.Location = new System.Drawing.Point(22, 57);
            this.TxHeader1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxHeader1.Multiline = true;
            this.TxHeader1.Name = "TxHeader1";
            this.TxHeader1.ReadOnly = true;
            this.TxHeader1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxHeader1.Size = new System.Drawing.Size(514, 36);
            this.TxHeader1.TabIndex = 0;
            this.TxHeader1.TabStop = false;
            this.TxHeader1.Text = "GNUCash Backup Program";
            this.TxHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PictureBox2
            // 
            this.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox2.Location = new System.Drawing.Point(12, 45);
            this.PictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(538, 95);
            this.PictureBox2.TabIndex = 6;
            this.PictureBox2.TabStop = false;
            // 
            // TxHeader2
            // 
            this.TxHeader2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxHeader2.Location = new System.Drawing.Point(22, 105);
            this.TxHeader2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxHeader2.Multiline = true;
            this.TxHeader2.Name = "TxHeader2";
            this.TxHeader2.ReadOnly = true;
            this.TxHeader2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxHeader2.Size = new System.Drawing.Size(514, 22);
            this.TxHeader2.TabIndex = 11;
            this.TxHeader2.TabStop = false;
            this.TxHeader2.Text = "(c)  Charles E Maybury";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(33, 288);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(493, 106);
            this.textBox2.TabIndex = 13;
            this.textBox2.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(33, 408);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(493, 106);
            this.textBox3.TabIndex = 14;
            this.textBox3.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox1.Location = new System.Drawing.Point(12, 148);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(538, 382);
            this.PictureBox1.TabIndex = 5;
            this.PictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 169);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(493, 106);
            this.textBox1.TabIndex = 15;
            this.textBox1.TabStop = false;
            // 
            // MnuStrip
            // 
            this.MnuStrip.AutoSize = false;
            this.MnuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MnuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSetup});
            this.MnuStrip.Location = new System.Drawing.Point(0, 0);
            this.MnuStrip.Name = "MnuStrip";
            this.MnuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MnuStrip.Size = new System.Drawing.Size(567, 37);
            this.MnuStrip.TabIndex = 16;
            this.MnuStrip.Text = "menuStrip1";
            this.MnuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MnuStrip_ItemClicked);
            // 
            // mnuSetup
            // 
            this.mnuSetup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuMainDir,
            this.MnuCloudDir,
            this.MnuExtraDir});
            this.mnuSetup.Name = "mnuSetup";
            this.mnuSetup.Size = new System.Drawing.Size(163, 33);
            this.mnuSetup.Text = "Setup Directories";
            // 
            // MnuMainDir
            // 
            this.MnuMainDir.Name = "MnuMainDir";
            this.MnuMainDir.Size = new System.Drawing.Size(342, 34);
            this.MnuMainDir.Text = "Select Main Directory";
            this.MnuMainDir.ToolTipText = "Select the Main Directory to store GNUCash File. ";
            this.MnuMainDir.Click += new System.EventHandler(this.MnuMainDir_Click);
            // 
            // MnuCloudDir
            // 
            this.MnuCloudDir.Name = "MnuCloudDir";
            this.MnuCloudDir.Size = new System.Drawing.Size(342, 34);
            this.MnuCloudDir.Text = "Select Cloud Directory";
            this.MnuCloudDir.ToolTipText = "Select the Extra Backup Drive to store GNUCash File. ";
            this.MnuCloudDir.Click += new System.EventHandler(this.MnuCloudDir_Click);
            // 
            // MnuExtraDir
            // 
            this.MnuExtraDir.Name = "MnuExtraDir";
            this.MnuExtraDir.Size = new System.Drawing.Size(342, 34);
            this.MnuExtraDir.Text = "Select Extra Backup Directory";
            this.MnuExtraDir.Click += new System.EventHandler(this.MnuExtraDir_Click);
            // 
            // FrmGNUCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(567, 545);
            this.Controls.Add(this.TxHeader2);
            this.Controls.Add(this.TxHeader1);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.BtBUCLD);
            this.Controls.Add(this.BtBUCLDandDrive);
            this.Controls.Add(this.BtNoBU);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.MnuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MnuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGNUCash";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.FrmGNUCash_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.MnuStrip.ResumeLayout(false);
            this.MnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
                
        private void FrmGNUCash_Load(object sender, EventArgs e)
        {
        //    throw new NotImplementedException();
        }
                                
        #endregion

        private System.Windows.Forms.Button BtNoBU;
        private System.Windows.Forms.Button BtBUCLD;
        private System.Windows.Forms.Button BtBUCLDandDrive;
        private System.Windows.Forms.TextBox TxHeader1;
        private System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.TextBox TxHeader2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip MnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuSetup;
        private System.Windows.Forms.ToolStripMenuItem MnuMainDir;
        private System.Windows.Forms.ToolStripMenuItem MnuCloudDir;
        private System.Windows.Forms.ToolStripMenuItem MnuExtraDir;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
    }
}

