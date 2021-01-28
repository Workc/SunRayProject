
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
        //readonly PointOfSaleEntities db = new PointOfSaleEntities();
        readonly Static st = new Static();
        public FrmMain()
        {
            InitializeComponent();
            RibbonControl s = new RibbonControl();
            s.BackColor = Color.Red;
        }

        //private void BtRefersh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    RbAddCustomer.Visible = false;
        //    RbAddUser.Visible = false;
        //    RbAuth.Visible = false;
        //}

        void Authentication()
        {
            //Int64 User_Code = st.User_Code();
            //List<User_View> User;
            //User = db.User_View.Where(View => View.Employee_Code == User_Code && (View.UserFlag == true)).ToList();
            //foreach (var item in User)
            //{
            //    BarStaticItem3.Caption = item.Employee_Name;
            //    barStaticItem10.Caption = item.Employee_Name;
            //    BarStaticItem3.Appearance.ForeColor = Color.Red;
            //    barStaticItem10.Appearance.ForeColor = Color.Red;
            //}

            //var result = db.Auth_View.Where(View => View.User_Code == User_Code && (View.User_IsDeleted == 0)).ToList();
            //for (var i = 0; i < result.Count; i++)
            //{
            //    string _TabName = result[i].Tab_Name;
            //    switch (_TabName)
            //    {
            //        case "RbAuth":
            //            RbAuth.Visible = true;
            //            break;
            //        case "RbAddUser":
            //            RbAddUser.Visible = true;
            //            break;
            //        default:
            //            break;
            //    }
            //}

            //if (RbAddCustomer.Visible == false && RbAddUser.Visible == false && RbAuth.Visible == false)
            //{
            //    TbAdd.Visible = false;
            //}
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Authentication();
        }

        private void BtnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            //    FrmLogin frm = new FrmLogin();
            //    frm.ShowDialog();
        }

       

        //private void BarAddUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    frmUser frm = new frmUser();
        //    frm.ShowDialog();
        //}
        //private void BrAddauthentication_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    FrmAuthentication frm = new FrmAuthentication();
        //    frm.ShowDialog();
        //}

        //private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    frmEmployees frm = new frmEmployees();
        //    frm.ShowDialog();
        //}

        //private void BrAddCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    frmCustomer frm = new frmCustomer();
        //    frm.ShowDialog();
        //}
    }
}
