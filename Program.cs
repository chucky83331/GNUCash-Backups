﻿using System;
using System.IO;
using System.Windows.Forms;


namespace GNUCash_Backups
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        [STAThread]
        
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmGNUCash());
        }
                
    }
}
