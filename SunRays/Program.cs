using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using SunRays._101_Adds._103_Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SunRays
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}
