using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IrgaMonitor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
		/// 
//		static MainForm ChildWindow = new MainForm();
//		static Settings SettingsWindow = new Settings();

        [STAThread]
					
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
        }
    }
}