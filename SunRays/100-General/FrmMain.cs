
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
using SunRays._101_Adds._100_Employees;

namespace SunRays._100_General
{
    public partial class FrmMain : MaterialSkin.Controls.MaterialForm
    {
        readonly DB_A65D4E_SolarEnergyEntities context = new DB_A65D4E_SolarEnergyEntities();
        readonly Static st = new Static();

        // FIll Employee Lists
        public List<Branch> _branches = new List<Branch>();
        public List<Gender> _Gender = new List<Gender>();
        public List<Job> _Jop = new List<Job>();
        public List<Nationality> _Nationality = new List<Nationality>();
        public List<Department> _Department = new List<Department>();
        public List<Employee_View> _Employee_View = new List<Employee_View>();


        public FrmMain()
        {
            InitializeComponent();
            RibbonControl s = new RibbonControl();
            FillLists();

        }


        void FillLists()
        {

            _branches = context.Branches.Where(x => x.IsDeleted == 0).ToList();
            _Gender = context.Genders.ToList();
            _Jop = context.Jobs.Where(x => x.IsDeleted == 0).ToList();
            _Nationality = context.Nationalities.Where(x => x.IsDeleted == 0).ToList();
            _Department = context.Departments.Where(x => x.IsDeleted == 0).ToList();
            _Employee_View = context.Employee_View.Where(x => x.IsDeleted == 0).ToList();
             


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

        private void barButtonItem21_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEmployees frm = new frmEmployees();
            frm._branches = _branches;
            frm._Department = _Department;
            frm._Jop = _Jop;
            frm._branches = _branches;
            frm._Gender = _Gender;
            frm._Nationality = _Nationality;
            try
            {

                    if (_Employee_View.Count > 0 && _Employee_View != null)
                    {

                        frm.gcEmployeeCard.DataSource = _Employee_View;
                        frm.gcEmployeeCard.RefreshDataSource();

                    }
                    else
                    {

                        frm.gcEmployeeCard.Enabled = false;
                        frm.windowsUIButtonPanel.Buttons.ForEach(x =>
                        {

                            if (x.Properties.Caption == "تعديل" || x.Properties.Caption == "طباعة" || x.Properties.Caption == "حذف")
                            {

                                x.Properties.Enabled = false;

                            }
                            if (x.Properties.Caption == "جديد")
                            {

                                x.Properties.Enabled = true;

                            }

                        });




                    }
                 

            }
            catch
            {


            }
            frm.ShowDialog();
        }
    }
}
