
using DevExpress.Data.Linq.Helpers;
using DevExpress.Emf;
using DevExpress.Utils.Extensions;
using DevExpress.XtraSplashScreen;
using FastReport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Timers;
using DevExpress.Utils;



using SunRays.HelperClass;
using DevExpress.XtraBars.Ribbon;

namespace SunRays._100_General
{
    public partial class FrmMain : MaterialSkin.Controls.MaterialForm
    {
        readonly DB_A65D4E_SolarEnergyEntities context = new DB_A65D4E_SolarEnergyEntities();
        readonly Static st = new Static();
        public FrmMain()
        {
            InitializeComponent();
            RibbonControl s = new RibbonControl();
            s.BackColor = Color.Red;
        }

        private void BtRefersh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
      
        }

        void Authentication()
        {
             
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Authentication();
        }

        private void BtnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
           
        }

       

        private void BarAddUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        
        }
        private void BrAddauthentication_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
      
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
       
        }

        private void BrAddCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        
        }
    }
}
