using DevExpress.XtraEditors;
using SunRays._100_General;
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
    public partial class frmEditeEmployees : DevExpress.XtraEditors.XtraForm
    {
        readonly DB_A65D4E_SolarEnergyEntities context = new DB_A65D4E_SolarEnergyEntities();
        readonly Static st = new Static();
        public List<Branch> _branches = new List<Branch>();
        public List<Gender> _Gender = new List<Gender>();
        public List<Job> _Jop = new List<Job>();
        public List<Nationality> _Nationality = new List<Nationality>();
        public List<Department> _Department = new List<Department>();
        public List<Employee_View> _Employee_View = new List<Employee_View>();
        public frmEditeEmployees()
        {
            InitializeComponent();

        }
     

       


      
        void EditItem()
        {
        }


      

        

        
        private void btnAdd_Click_2(object sender, EventArgs e)
        {
            #region Validation
            if (string.IsNullOrWhiteSpace(TxtEmpName.Text))
            {

                MaterialMessageBox.Show("برجاء ادخال اسم الموظف", MessageBoxButtons.OK);
                //TxtEmpName.Properties.ver
                return;

            }
            else if (string.IsNullOrWhiteSpace(slkGender.Text))
            {
                MaterialMessageBox.Show("برجاء اختيار الجنس", MessageBoxButtons.OK);
                TxtEmpName.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(dtBrithDay.Text))
            {

                MaterialMessageBox.Show("برجاءاختيار ناريخ الميلاد", MessageBoxButtons.OK);
                dtBrithDay.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(TxtEmpNataionalId.Text))
            {

                MaterialMessageBox.Show("برجاء ادخال الرقم القومي للموظف", MessageBoxButtons.OK);
                TxtEmpNataionalId.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(slkNational.Text))
            {

                MaterialMessageBox.Show("برجاءاختيار الجنسية ", MessageBoxButtons.OK);
                slkNational.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(slkJop.Text))
            {

                MaterialMessageBox.Show("برجاء اختيار الوظيفة", MessageBoxButtons.OK);
                slkJop.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(slkBranch.Text))
            {

                MaterialMessageBox.Show("برجاء اختيار الفرع", MessageBoxButtons.OK);
                slkBranch.Focus();
                return;

            }

            else if (string.IsNullOrWhiteSpace(dtHiringDate.Text))
            {

                MaterialMessageBox.Show("برجاء اختيار  تاريخ التوظيف", MessageBoxButtons.OK);
                dtHiringDate.Focus();
                return;

            }
            #endregion

            if (Application.OpenForms.OfType<frmEmployees>().Any())
            {
                frmEmployees frm = (frmEmployees)Application.OpenForms["frmEmployees"];
                Int64 EmpCode = Convert.ToInt64(txtEmpCode.Text);
                using (DB_A65D4E_SolarEnergyEntities ForCheck = new DB_A65D4E_SolarEnergyEntities())
                {
                    bool TestUserName = ForCheck.Employees.Any(Emp => Emp.EmployeeName == TxtEmpName.Text && Emp.Employee_Code != EmpCode && Emp.IsDeleted == 0);
                    if (TestUserName)
                    {
                        MaterialMessageBox.Show("تم تسجيل هذا الاسم لموظف اخر", MessageBoxButtons.OK);
                        return;
                    }
                    bool TestNatId = ForCheck.Employees.Any(Emp => Emp.National_Id == TxtEmpNataionalId.Text && Emp.IsDeleted == 0);
                    if (TestUserName)
                    {
                        MaterialMessageBox.Show("تم تسجيل رقم البطاقة لموظف اخر", MessageBoxButtons.OK);
                        return;
                    }
                }

                Employee _Employee;
                _Employee = context.Employees.Where(Employee => Employee.Employee_Code == EmpCode && Employee.IsDeleted == 0).SingleOrDefault();

                _Employee.EmployeeName = TxtEmpName.Text;
                _Employee.Natinality_Code = Convert.ToInt32(slkNational.EditValue);
                _Employee.National_Id = TxtEmpNataionalId.Text;
                _Employee.Email = txtEmail.Text;
                _Employee.EmployeeAddress1 = txtAdress1.Text;
                _Employee.EmployeeAddress2 = txtAdress2.Text;
                _Employee.Birthdate = Convert.ToDateTime(dtBrithDay.EditValue);
                _Employee.HiringDate = Convert.ToDateTime(dtHiringDate.EditValue);
                _Employee.Phone = txtMob1.Text;
                _Employee.Phone2 = txtMob2.Text;
                _Employee.Job_Code = Convert.ToInt64(slkJop.EditValue);
                _Employee.Gender_Id = Convert.ToInt16(slkGender.EditValue);
                _Employee.Branch_Code = Convert.ToInt64(slkBranch.EditValue);
                _Employee.LandLine = txtLandLine.Text;
                _Employee.Last_Modified_Date = DateTime.Now;
                _Employee.Last_Modified_User = st.User_Code();
                context.SaveChanges();
                frmEmployees frmEmpMain = new frmEmployees();
                using (DB_A65D4E_SolarEnergyEntities NewReco = new DB_A65D4E_SolarEnergyEntities())
                {

                    var EmpData = NewReco.Employee_View.Where(x => x.IsDeleted == 0).ToList();

                    frmEmpMain.gcEmployeeCard.DataSource = EmpData;
                    frmEmpMain.gcEmployeeCard.RefreshDataSource();
                    Employee_View result2 = EmpData.Where(x => x.Employee_Code == EmpCode && x.IsDeleted == 0).FirstOrDefault();
                    frm.gvEmployeeCard.SetFocusedRowCellValue("EmployeeName", result2.EmployeeName);
                    frm.gvEmployeeCard.SetFocusedRowCellValue("Gender_Name", result2.Gender_Name);
                    frm.gvEmployeeCard.SetFocusedRowCellValue("National_Id", result2.National_Id);
                    frm.gvEmployeeCard.SetFocusedRowCellValue("Email", result2.Email);
                    frm.gvEmployeeCard.SetFocusedRowCellValue("Phone", result2.Phone);
                    frm.gvEmployeeCard.SetFocusedRowCellValue("Phone", result2.Phone2);
                    frm.gvEmployeeCard.SetFocusedRowCellValue("JobName", result2.JobName);
                    frm.gvEmployeeCard.SetFocusedRowCellValue("HiringDate", result2.HiringDate);
                    frm.gvEmployeeCard.SetFocusedRowCellValue("LandLine", result2.LandLine);
                    frm.gvEmployeeCard.SetFocusedRowCellValue("EmployeeAddress1", result2.EmployeeAddress1);
                    frm.gvEmployeeCard.SetFocusedRowCellValue("EmployeeAddress2", result2.EmployeeAddress2);
                    frm.gvEmployeeCard.SetFocusedRowCellValue("Birthdate", result2.Birthdate);
                    frm.gvEmployeeCard.SetFocusedRowCellValue("National_Name", result2.National_Name);
                    frm.gvEmployeeCard.SetFocusedRowCellValue("BranchName", result2.BranchName);
                    frm.gvEmployeeCard.SetFocusedRowCellValue("DepartmentName", result2.DepartmentName);
                    frm.gvEmployeeCard.RefreshData();
                    HelperClass.HelperClass.ClearValues(tableLayoutPanel2);
                }

                this.Close();
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}