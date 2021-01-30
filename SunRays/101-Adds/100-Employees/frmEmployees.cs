using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;
using SunRays.HelperClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunRays._101_Adds._100_Employees
{
    public partial class frmEmployees : DevExpress.XtraEditors.XtraForm
    {

        readonly DB_A65D4E_SolarEnergyEntities context = new DB_A65D4E_SolarEnergyEntities();
        readonly Static st = new Static();
        public List<Branch> _branches = new List<Branch>();
        public List<Gender> _Gender = new List<Gender>();
        public List<Job> _Jop = new List<Job>();
        public List<Nationality> _Nationality = new List<Nationality>();
        public List<Department> _Department = new List<Department>();
        public List<Employee_View> _Employee_View = new List<Employee_View>();
        public frmEmployees()
        {
            InitializeComponent();
            //FillGride();
             
        }
         

        private void frmCustomers_Load(object sender, EventArgs e)
        {

        }

        private void gcItemCard_Click(object sender, EventArgs e)
        {

        }

        void FillGride()
        {
            gcEmployeeCard.DataSource = null;
            try
            {

                using (DB_A65D4E_SolarEnergyEntities Contexts = new DB_A65D4E_SolarEnergyEntities())
                {

                    var empData = (from a in Contexts.Employee_View where a.IsDeleted == 0 select a).OrderBy(x => x.Employee_Code).ToList();


                    if (empData.Count > 0 && empData != null)
                    {

                        gcEmployeeCard.DataSource = empData;
                        gcEmployeeCard.RefreshDataSource();

                    }
                    else
                    {

                        gcEmployeeCard.Enabled = false;
                        windowsUIButtonPanel.Buttons.ForEach(x =>
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

            }
            catch
            {


            }



        }
        private void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            if (btn.Caption == "جديد")
            {
                FrmAddEmployees frm = new FrmAddEmployees();
                try
                {

                    var result = _Jop.Where(Job => Job.IsDeleted == 0).ToList();
                    if (result.Count > 0 && result != null)
                    {

                        frm.slkJop.Properties.DataSource = result;
                        frm.slkJop.Properties.ValueMember = "Jop_Code";
                        frm.slkJop.Properties.DisplayMember = "JobName";
                        frm.slkJop.EditValue = result[0].Jop_Code;


                    }
                }
                catch
                {


                }




                try
                {

                    var result = _Department.Where(Department => Department.IsDeleted == 0).ToList();
                    if (result.Count > 0 && result != null)
                    {


                        frm.slkDepartment.Properties.DataSource = result;
                        frm.slkDepartment.Properties.ValueMember = "Department_Code";
                        frm.slkDepartment.Properties.DisplayMember = "DepartmentName";
                        frm.slkDepartment.EditValue = result[0].Department_Code;

                    }
                }
                catch
                {


                }




                try
                {
                    var result = _branches.Where(Branche => Branche.IsDeleted == 0).ToList();
                    if (result.Count > 0 && result != null)
                    {


                        frm.slkBranch.Properties.DataSource = result;
                        frm.slkBranch.Properties.ValueMember = "Branch_Code";
                        frm.slkBranch.Properties.DisplayMember = "BranchName";
                        frm.slkBranch.EditValue = result[0].Branch_Code;

                    }
                }
                catch
                {

                }






                try
                {
                    var result = _Gender.ToList();

                    if (result.Count > 0 && result != null)
                    {

                        frm.slkGender.Properties.DataSource = result;
                        frm.slkGender.Properties.ValueMember = "Id";
                        frm.slkGender.Properties.DisplayMember = "Gender_Name";
                        frm.slkGender.EditValue = result[0].Id;


                    }
                }
                catch
                {

                }





                try
                {
                    var result = _Nationality.Where(Nationalitie => Nationalitie.IsDeleted == 0).ToList();
                    if (result.Count > 0 && result != null)
                    {

                        frm.slkNational.Properties.DataSource = result;
                        frm.slkNational.Properties.ValueMember = "National_Code";
                        frm.slkNational.Properties.DisplayMember = "National_Name";
                        frm.slkNational.EditValue = result[0].Id;


                    }

                }
                catch
                {


                }




                Int64? MaxCode = 1;
                if (_Employee_View != null)
                {
                    MaxCode = _Employee_View.Where(x => x.IsDeleted == 0).Max(u => (Int64?)u.Employee_Code + 1);
                }
                frm.txtEmpCode.Text = MaxCode.ToString();

                frm._Employee_View = _Employee_View;
                frm.ShowDialog();
            }
            else if (btn.Caption == "تعديل")
            {

                //if (gvEmployeeCard.RowCount <= 0)
                //{
                //    return;
                //}

                //frmEditeEmployees frm = new frmEditeEmployees();

                //var x = gvEmployeeCard.GetFocusedRow() as Employee_View;
                //frm.FillBranchSlk();
                //frm.FillJopSlk();
                //frm.FillSexSlk();

                //frm.txtEmpCode.Text = x.Employee_Code.ToString();
                //frm.TxtEmpName.Text = x.Employee_Name.ToString();
                //frm.txtEmpMob1.Text = x.Employee_Mobile_1.ToString();
                //frm.txtEmpMob2.Text = x.Employee_Mobile_2.ToString();

                //frm.TxtEmpEmail.Text = x.Employee_Email.ToString();
                //frm.TxtEmpAddress.Text = x.Employee_Address.ToString();
                //frm.TxtEmpNote.Text = x.Employee_Notes.ToString();
                //frm.slkBranch.EditValue = x.Branch_ID;
                //frm.slkJop.EditValue = x.Jop_Code;
                //frm.slkSex.EditValue = x.SexTypeCode;


                //frm.ShowDialog();

            }
            else if (btn.Caption == "خروج")
            {

                this.Close();


            }
            else if (btn.Caption == "حذف")
            {

                if (gvEmployeeCard.RowCount <= 0)
                {


                    return;
                }
                //    if (MaterialMessageBox.Show("تاكيد الحذف", MessageBoxButtons.YesNo) == DialogResult.OK)
                //{

                //    ItemCardView xx = gvEmployeeCard.GetFocusedRow() as ItemCardView;


                //    using (PointOfSaleEntities Contexts = new PointOfSaleEntities())
                //    {
                //        ItemCard _ItemCard = new ItemCard();
                //        _ItemCard = Contexts.ItemCards.SingleOrDefault(item => item.ItemCode == xx.ItemCode);
                //        Contexts.ItemCards.Remove(_ItemCard);
                //        Contexts.SaveChanges();
                //        var result = (from a in Contexts.ItemCardViews where a.IsDeleted == 0 select a).ToList();
                //        gcEmployeeCard.DataSource = result;
                //        gcEmployeeCard.RefreshDataSource();
                //        MaterialMessageBox.Show("تم الحذف", MessageBoxButtons.OK);
                //        if (gvEmployeeCard.RowCount <= 0)
                //        {
                //            gcEmployeeCard.Enabled = false;
                //            windowsUIButtonPanel.Buttons.ForEach(x =>
                //            {

                //                if (x.Properties.Caption == "تعديل" || x.Properties.Caption == "طباعة" || x.Properties.Caption == "حذف")
                //                {

                //                    x.Properties.Enabled = false;

                //                }
                //                if (x.Properties.Caption == "جديد")
                //                {

                //                    x.Properties.Enabled = true;

                //                }

                //            });

                //            return;
                //        }
                //    }

                //}


            }

            else if (btn.Caption == "طباعة")
            {

            }
        }

        private void اضافةصنفجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddEmployees frm = new FrmAddEmployees();

            try
            {

                var result = _Jop.Where(Job => Job.IsDeleted == 0).ToList();
                if (result.Count > 0 && result != null)
                {

                    frm.slkJop.Properties.DataSource = result;
                    frm.slkJop.Properties.ValueMember = "Jop_Code";
                    frm.slkJop.Properties.DisplayMember = "JobName";
                    frm.slkJop.EditValue = result[0].Jop_Code;


                }
            }
            catch
            {


            }




            try
            {

                var result = _Department.Where(Department => Department.IsDeleted == 0).ToList();
                if (result.Count > 0 && result != null)
                {


                    frm.slkDepartment.Properties.DataSource = result;
                    frm.slkDepartment.Properties.ValueMember = "Department_Code";
                    frm.slkDepartment.Properties.DisplayMember = "DepartmentName";
                    frm.slkDepartment.EditValue = result[0].Department_Code;

                }
            }
            catch
            {


            }




            try
            {
                var result = _branches.Where(Branche => Branche.IsDeleted == 0).ToList();
                if (result.Count > 0 && result != null)
                {


                    frm.slkBranch.Properties.DataSource = result;
                    frm.slkBranch.Properties.ValueMember = "Branch_Code";
                    frm.slkBranch.Properties.DisplayMember = "BranchName";
                    frm.slkBranch.EditValue = result[0].Branch_Code;

                }
            }
            catch
            {

            }






            try
            {
                var result = _Gender.ToList();

                if (result.Count > 0 && result != null)
                {

                    frm.slkGender.Properties.DataSource = result;
                    frm.slkGender.Properties.ValueMember = "Id";
                    frm.slkGender.Properties.DisplayMember = "Gender_Name";
                    frm.slkGender.EditValue = result[0].Id;


                }
            }
            catch
            {

            }





            try
            {
                var result = _Nationality.Where(Nationalitie => Nationalitie.IsDeleted == 0).ToList();
                if (result.Count > 0 && result != null)
                {

                    frm.slkNational.Properties.DataSource = result;
                    frm.slkNational.Properties.ValueMember = "National_Code";
                    frm.slkNational.Properties.DisplayMember = "National_Name";
                    frm.slkNational.EditValue = result[0].Id;


                }

            }
            catch
            {


            }
            Int64? MaxCode = 1;
            if (_Employee_View != null)
            {
                MaxCode = _Employee_View.Where(x => x.IsDeleted == 0).Max(u => (Int64?)u.Employee_Code + 1);
            }
            frm.txtEmpCode.Text = MaxCode.ToString();
            frm._Employee_View = _Employee_View;
            frm.ShowDialog();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void CheckGridDataCount()
        {



        }
    }
}