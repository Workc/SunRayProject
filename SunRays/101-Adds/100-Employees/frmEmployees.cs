using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;
using SunRays.HelperClass;
using SunRays.HelperClass._103_MaterialSkin;
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
                        frm.slkGender.Properties.ValueMember = "Gender_Id";
                        frm.slkGender.Properties.DisplayMember = "Gender_Name";
                        frm.slkGender.EditValue = result[0].Gender_Id;


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
                if (_Employee_View != null && _Employee_View.Count > 0)
                {
                    MaxCode   = _Employee_View.Where(xx => xx.IsDeleted == 0).Max(u => (Int64?)u.Employee_Code + 1);
                    
                }
                frm.txtEmpCode.Text = MaxCode.ToString();

                frm._Employee_View = _Employee_View;
                frm.ShowDialog();
            }
            else if (btn.Caption == "تعديل")
            {
                if (gvEmployeeCard.RowCount <= 0)
                {
                    return;
                }

                frmEditeEmployees frm = new frmEditeEmployees();
                var x = gvEmployeeCard.GetFocusedRow() as Employee_View;
                using (DB_A65D4E_SolarEnergyEntities context4 = new DB_A65D4E_SolarEnergyEntities())
                {
                    var emp = context.Employee_View.Where(xx => xx.IsDeleted == 0 && xx.Employee_Code == x.Employee_Code).SingleOrDefault();

                    frm.txtEmpCode.Text = emp.Employee_Code.ToString();
                    frm.TxtEmpName.Text = emp.EmployeeName.ToString();
                    frm.dtBrithDay.EditValue = emp.Birthdate;
                    frm.TxtEmpNataionalId.Text = emp.National_Id.ToString();
                    frm.txtAdress1.Text = emp.EmployeeAddress1.ToString();
                    frm.txtAdress2.Text = emp.EmployeeAddress2.ToString();
                    frm.txtMob1.Text = emp.Phone.ToString();
                    frm.txtMob2.Text = emp.Phone2.ToString();
                    frm.txtLandLine.Text = emp.LandLine.ToString();
                    frm.txtEmail.Text = emp.Email.ToString();
                    frm.dtHiringDate.EditValue = emp.HiringDate;
                    try
                    {

                        var result = _Jop.Where(Job => Job.IsDeleted == 0).ToList();
                        if (result.Count > 0 && result != null)
                        {

                            frm.slkJop.Properties.DataSource = result;
                            frm.slkJop.Properties.ValueMember = "Jop_Code";
                            frm.slkJop.Properties.DisplayMember = "JobName";
                            frm.slkJop.EditValue = emp.Job_Code;


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
                            frm.slkBranch.EditValue = emp.Branch_Code;

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
                            frm.slkGender.Properties.ValueMember = "Gender_Id";
                            frm.slkGender.Properties.DisplayMember = "Gender_Name";
                            frm.slkGender.EditValue = emp.Gender_Id;


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
                            frm.slkNational.EditValue = emp.Natinality_Code;


                        }

                    }
                    catch
                    {


                    }

                }
                frm.ShowDialog();
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
                if (MaterialMessageBox.Show("تاكيد الحذف", MessageBoxButtons.YesNo) == DialogResult.OK)
                {
                    Employee_View xx = gvEmployeeCard.GetFocusedRow() as Employee_View;
                    Employee _Employees = new Employee();
                    using (DB_A65D4E_SolarEnergyEntities context2 = new DB_A65D4E_SolarEnergyEntities())
                    {
                        Employee employee = new Employee();
                        _Employees = context2.Employees.SingleOrDefault(item => item.Employee_Code == xx.Employee_Code &&  item.IsDeleted == 0);
                       
                        _Employees.IsDeleted = 1;
                        context2.SaveChanges();
                    }
                }
                FillGride();
            }
            else if (btn.Caption == "تحديث")
            {
                using (DB_A65D4E_SolarEnergyEntities refershContext  = new DB_A65D4E_SolarEnergyEntities ())
                {
                    _branches = refershContext.Branches.Where(x => x.IsDeleted == 0).ToList();
          
                    _Jop = refershContext.Jobs.Where(x => x.IsDeleted == 0).ToList();
                    _Nationality = refershContext.Nationalities.Where(x => x.IsDeleted == 0).ToList();
                  
                    _Employee_View = refershContext.Employee_View.Where(x => x.IsDeleted == 0).ToList();

                    if (_Employee_View.Count > 0 && _Employee_View != null)
                    {

                        gcEmployeeCard.DataSource = null;
                        gcEmployeeCard.DataSource = _Employee_View;
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
            //else if (btn.Caption == "طباعة")
            //{
            //}
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


                    //frm.slkDepartment.Properties.DataSource = result;
                    //frm.slkDepartment.Properties.ValueMember = "Department_Code";
                    //frm.slkDepartment.Properties.DisplayMember = "DepartmentName";
                    //frm.slkDepartment.EditValue = result[0].Department_Code;

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
                    frm.slkGender.Properties.ValueMember = "Gender_Id";
                    frm.slkGender.Properties.DisplayMember = "Gender_Name";
                    frm.slkGender.EditValue = result[0].Gender_Id;


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
            if (_Employee_View != null && _Employee_View.Count > 0)
            {
                MaxCode = _Employee_View.Where(xx => xx.IsDeleted == 0).Max(u => (Int64?)u.Employee_Code + 1);

            }
            frm.txtEmpCode.Text = MaxCode.ToString();
            frm._Employee_View = _Employee_View;
            frm.ShowDialog();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gvEmployeeCard.RowCount <= 0)
            {
                return;
            }

            frmEditeEmployees frm = new frmEditeEmployees();
            var x = gvEmployeeCard.GetFocusedRow() as Employee_View;
            using (DB_A65D4E_SolarEnergyEntities context4 = new DB_A65D4E_SolarEnergyEntities ())
            {
                var emp = context.Employee_View.Where(xx => xx.IsDeleted == 0 && xx.Employee_Code == x.Employee_Code).SingleOrDefault();

            frm.txtEmpCode.Text = emp.Employee_Code.ToString();
            frm.TxtEmpName.Text = emp.EmployeeName.ToString();
            frm.dtBrithDay.EditValue = emp.Birthdate;
            frm.TxtEmpNataionalId.Text = emp.National_Id.ToString();
            frm.txtAdress1.Text = emp.EmployeeAddress1.ToString();
            frm.txtAdress2.Text = emp.EmployeeAddress2.ToString();
            frm.txtMob1.Text = emp.Phone.ToString();
            frm.txtMob2.Text = emp.Phone2.ToString();
            frm.txtLandLine.Text = emp.LandLine.ToString();
            frm.txtEmail.Text = emp.Email.ToString();
            frm.dtHiringDate.EditValue = emp.HiringDate;
            try
            {

                var result = _Jop.Where(Job => Job.IsDeleted == 0).ToList();
                if (result.Count > 0 && result != null)
                {

                    frm.slkJop.Properties.DataSource = result;
                    frm.slkJop.Properties.ValueMember = "Jop_Code";
                    frm.slkJop.Properties.DisplayMember = "JobName";
                    frm.slkJop.EditValue = emp.Job_Code;


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
                    frm.slkBranch.EditValue = emp.Branch_Code;

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
                    frm.slkGender.Properties.ValueMember = "Gender_Id";
                    frm.slkGender.Properties.DisplayMember = "Gender_Name";
                    frm.slkGender.EditValue = emp.Gender_Id;


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
                    frm.slkNational.EditValue = emp.Natinality_Code;


                }

            }
            catch
            {


            }

            }
            frm.ShowDialog();

        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MaterialMessageBox.Show("تاكيد الحذف", MessageBoxButtons.YesNo) == DialogResult.OK)
            {
                Employee_View xx = gvEmployeeCard.GetFocusedRow() as Employee_View;
                Employee _Employees = new Employee();
                using (DB_A65D4E_SolarEnergyEntities context2 = new DB_A65D4E_SolarEnergyEntities ())
                {
                 Employee employee = new Employee();
                _Employees = context2.Employees.Where(item => item.Employee_Code == xx.Employee_Code &&  item.IsDeleted == 0).SingleOrDefault();
                _Employees.IsDeleted = 1;
                context2.SaveChanges();
                FillGride();
                }
            }
        }

        
    }
}