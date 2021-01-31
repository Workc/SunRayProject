using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SunRays.HelperClass;
using SunRays.HelperClass._103_MaterialSkin;
 
namespace SunRays._101_Adds._100_Employees
{
    public partial class FrmAddEmployees : DevExpress.XtraEditors.XtraForm
    {
        readonly DB_A65D4E_SolarEnergyEntities context = new DB_A65D4E_SolarEnergyEntities();
        readonly Static st = new Static();

        public List<Branch> _branches;
        public List<Gender> _Gender;
        public List<Job> _Jop;
        public List<Nationality> _Nationality ;
        public List<Department> _Department;
        public List<Employee_View> _Employee_View;
   
         
        
        public FrmAddEmployees()
        {

            InitializeComponent();
            Rest();
           
            //FillBranchSlk();
            //FillJopSlk();
            //FillGenderSlk();
            //FillNationality();
            //FillDepartmentSlk();
             
        }

        void Rest()
        {
            dtBrithDay.Text = Convert.ToString(DateTime.Now.ToString("MM/dd/yyyy"));
            dtHiringDate.Text = Convert.ToString(DateTime.Now.ToString("MM/dd/yyyy"));
            txtAdress1.ResetText();
            txtAdress2.ResetText();
            txtEmail.ResetText();
            LandLine.ResetText();
            txtMob1.ResetText();
            txtMob2.ResetText();
            TxtEmpName.ResetText();
            TxtEmpNataionalId.ResetText();
            txtEmpCode.ResetText();
            
            
        }

        void GetLastEmployeeCode()
        {
            Int64? MaxCode = 1;
            if (_Employee_View != null && _Employee_View.Count>0)
            {
                MaxCode = _Employee_View.Where(x => x.IsDeleted == 0).Max(u => (Int64?)u.Employee_Code + 1);
            }
            txtEmpCode.Text = MaxCode.ToString();
        }


        void FillJopSlk()
        {
            try
            {

            var result = _Jop.Where(Job => Job.IsDeleted == 0).ToList();
            if (result.Count > 0 && result != null)
            {

            slkJop.Properties.DataSource = result;
            slkJop.Properties.ValueMember = "Jop_Code";
            slkJop.Properties.DisplayMember = "JobName";
            slkJop.EditValue = result[0].Jop_Code;


            }
            }
            catch 
            {

                
            }

        }

        void FillDepartmentSlk()
        {
            try
            {

            var result = _Department.Where(Department => Department.IsDeleted == 0).ToList();
            if (result.Count > 0 && result != null)
            {


            //slkDepartment.Properties.DataSource = result;
            //slkDepartment.Properties.ValueMember = "Department_Code";
            //slkDepartment.Properties.DisplayMember = "DepartmentName";
            //slkDepartment.EditValue = result[0].Department_Code;

            }
            }
            catch 
            {

               
            }

        }

        void FillBranchSlk()
        {
            try
            {
                var result = _branches.Where(Branche => Branche.IsDeleted == 0).ToList();
                if (result.Count > 0 && result != null)
                {


                    slkBranch.Properties.DataSource = result;
                    slkBranch.Properties.ValueMember = "Branch_Code";
                    slkBranch.Properties.DisplayMember = "BranchName";
                    slkBranch.EditValue = result[0].Branch_Code;

                }
            }
            catch
            { 
            
            }
           
        }


        void FillGenderSlk()
        {

            try
            {
                var result = _Gender.ToList();

                if (result.Count > 0 && result != null)
                {

                    slkGender.Properties.DataSource = result;
                    slkGender.Properties.ValueMember = "Gender_Id";
                    slkGender.Properties.DisplayMember = "Gender_Name";
                    slkGender.EditValue = result[0].Gender_Id;


                }
            }
            catch
            { 
            
            }
           
        }


        void FillNationality()
        {

            try
            {
            var result = _Nationality.Where(Nationalitie => Nationalitie.IsDeleted == 0).ToList();
            if (result.Count > 0 && result != null)
            {

            slkNational.Properties.DataSource = result;
            slkNational.Properties.ValueMember = "National_Code";
            slkNational.Properties.DisplayMember = "National_Name";
            slkNational.EditValue = result[0].Id;


            }

            }
            catch
            {


            }
        }

        public void Save()
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
            else if(string.IsNullOrWhiteSpace(slkJop.Text))
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
                Int64 EmpCode = Convert.ToInt64(txtEmpCode.Text);

                bool TestUpdate = context.Employees.Any(customer => customer.Employee_Code == EmpCode && customer.IsDeleted == 0);
                frmEmployees frm = (frmEmployees)Application.OpenForms["frmEmployees"];
                if (TestUpdate)
                {

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
                    
                }
                else
                {
                    using (DB_A65D4E_SolarEnergyEntities ForCheck = new DB_A65D4E_SolarEnergyEntities())
                    {
                        List<Employee> _EmpList = ForCheck.Employees.Where(x => x.IsDeleted == 0).ToList();
                        bool TestEmpCode = _EmpList.Any(Emp => Emp.Employee_Code == EmpCode && Emp.IsDeleted == 0);
                        if (TestEmpCode)
                        {
                            MaterialMessageBox.Show("! تم تسجيل هذا كود الموظف لموظف اخر برجاء تحديث البيانات", MessageBoxButtons.OK);
                            return;
                        }
                        bool TestEmprName =  _EmpList.Any(Emp => Emp.EmployeeName == TxtEmpName.Text && Emp.IsDeleted == 0 );
                        if (TestEmprName)
                        {

                            MaterialMessageBox.Show("تم تسجيل هذا الاسم لموظف اخر", MessageBoxButtons.OK);
                            return;
                        }
                        bool TestEmpNatId = _EmpList.Any(Emp => Emp.National_Id == TxtEmpNataionalId.Text && Emp.IsDeleted == 0);
                        if (TestEmpNatId)
                        {
                            MaterialMessageBox.Show("تم تسجيل رقم البطاقة لموظف اخر", MessageBoxButtons.OK);
                            return;
                        }
                    };

                    Employee _Employee = new Employee()
                    {
                        Employee_Code = EmpCode,
                        EmployeeName = TxtEmpName.Text,
                        Phone = txtMob1.Text,
                        Phone2 = txtMob2.Text,
                        EmployeeAddress1 = txtAdress1.Text,
                        EmployeeAddress2 = txtAdress2.Text,
                        National_Id = TxtEmpNataionalId.Text,
                        Email = txtEmail.Text,
                        Birthdate = Convert.ToDateTime(dtBrithDay.EditValue),
                        HiringDate = Convert.ToDateTime(dtHiringDate.EditValue),
                        LandLine = LandLine.Text,
                        Last_Modified_Date = DateTime.Now,
                        Last_Modified_User = 1,
                        Branch_Code = Convert.ToInt64(slkBranch.EditValue),
                        //Department_Code = Convert.ToInt64(slkDepartment.EditValue),
                        Gender_Id = Convert.ToInt32(slkGender.EditValue),
                        Job_Code = Convert.ToInt32(slkJop.EditValue),
                        Natinality_Code = Convert.ToInt32(slkNational.EditValue),
                        Created_Date = DateTime.Now,
                        Created_User =  1,
                        

                    };
                    context.Employees.Add(_Employee);
                    context.SaveChanges();
                    Rest();
                    using (DB_A65D4E_SolarEnergyEntities NewContext = new DB_A65D4E_SolarEnergyEntities())
                    {
                        _Employee_View = null;
                        _Employee_View = NewContext.Employee_View.Where(x => x.IsDeleted == 0).ToList();

                        frm.gcEmployeeCard.DataSource = _Employee_View;
                        frm.gcEmployeeCard.RefreshDataSource();
                        frm.gcEmployeeCard.Enabled = true;
                        GetLastEmployeeCode();


                    }


                }

            }
        }




        public void Delete()
        {
           
        }

      
        public void GetById()
        {
            throw new NotImplementedException();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
           
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            
        }



        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmAddEmployees_Load(object sender, EventArgs e)
        {

        }
    }
}
