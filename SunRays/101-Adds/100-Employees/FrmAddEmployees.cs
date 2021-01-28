

 
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
      //  readonly PointOfSaleEntities context = new PointOfSaleEntities();
        readonly Static st = new Static();
        //readonly MaterialSkin.MaterialSkinManager skinManager;
        public FrmAddEmployees()
        {
            //InitializeComponent();
            //Int64? MaxCode = context.Employees.Where(x => x.IsDeleted == 0).Max(u => (Int64?)u.Employee_Code + 1);
            //if (MaxCode == null || MaxCode == 0)
            //{
            //    MaxCode = 1;
            //}


            //txtEmpCode.Text = MaxCode.ToString();
            //FillJopSlk();
            //FillBranchSlk();
            //FillSexSlk();


        }

        void FillJopSlk()
        {

            //var result = context.Jops.Where(jop => jop.IsDeleted == 0).ToList();
            //slkJop.Properties.DataSource = result;
            //slkJop.Properties.ValueMember = "JopCode";
            //slkJop.Properties.DisplayMember = "JobName";
            //slkJop.EditValue = result[0].JopCode;

        }

        void FillBranchSlk()
        {

            //var result = context.Branches.Where(Branch => Branch.IsDeleted == 0).ToList();
            //slkBranch.Properties.DataSource = result;
            //slkBranch.Properties.ValueMember = "Branches_Code";
            //slkBranch.Properties.DisplayMember = "Branches_Name";
            //slkBranch.EditValue = result[0].Branches_Code;
        }


        void FillSexSlk()
        {

            //var result = context.SexTypes.ToList();
            //slkSex.Properties.DataSource = result;
            //slkSex.Properties.ValueMember = "SexTypeCode";
            //slkSex.Properties.DisplayMember = "SexTypeName";
            //slkSex.EditValue = result[0].SexTypeCode;
        }


        public void Save()
        {
            //if (string.IsNullOrWhiteSpace(txtEmpCode.Text))
            //{

            //    MaterialMessageBox.Show("برجاء ادخال كود العميل", MessageBoxButtons.OK);
            //    return;

            //}
            //if (string.IsNullOrWhiteSpace(TxtEmpName.Text))
            //{
            //    MaterialMessageBox.Show("برجاء ادخال اسم العميل", MessageBoxButtons.OK);
            //    return;
            //}
            //if (string.IsNullOrWhiteSpace(slkSex.Text))
            //{

            //    MaterialMessageBox.Show("برجاءاختيار الجنس", MessageBoxButtons.OK);
            //    return;

            //}

            //if (string.IsNullOrWhiteSpace(slkJop.Text))
            //{

            //    MaterialMessageBox.Show("برجاءاختيار الوظيفة", MessageBoxButtons.OK);
            //    return;

            //}
            //if (string.IsNullOrWhiteSpace(slkBranch.Text))
            //{

            //    MaterialMessageBox.Show("برجاءاختيار الفرع", MessageBoxButtons.OK);
            //    return;

            //}
          

            //if (Application.OpenForms.OfType<frmEmployees>().Any())
            //{
            //    Int64 EmpCode = Convert.ToInt64(txtEmpCode.Text);

            //    bool TestUpdate = context.Employees.Any(customer => customer.Employee_Code == EmpCode && customer.IsDeleted == 0);
            //    frmEmployees frm = (frmEmployees)Application.OpenForms["frmEmployees"];
            //    if (TestUpdate)
            //    {

            //        using (PointOfSaleEntities ForCheck = new PointOfSaleEntities())
            //        {

            //            bool TestUserName = ForCheck.Employees.Any(Emp => Emp.Employee_Name == TxtEmpName.Text && Emp.Employee_Code !=EmpCode &&  Emp.IsDeleted == 0);
            //            if (TestUserName)
            //            {
            //            MaterialMessageBox.Show("تم تسجيل هذا الاسم لموظف اخر", MessageBoxButtons.OK);
            //            return;

            //            }
            //            bool TestNatId = ForCheck.Employees.Any(Emp => Emp.Employee_National_Id == TxtEmpNataionalId.Text && Emp.IsDeleted == 0);
            //            if (TestUserName)
            //            {

            //                MaterialMessageBox.Show("تم تسجيل رقم البطاقة لموظف اخر", MessageBoxButtons.OK);
            //                return;

            //            }


            //        }
            //        Employee _Employee;
            //        _Employee = context.Employees.SingleOrDefault(Employee => Employee.Employee_Code == EmpCode);
            //        _Employee.Employee_Code = EmpCode;
            //        _Employee.Employee_Name = TxtEmpName.Text;
            //        _Employee.Employee_Mobile_1 = txtEmpMob1.Text;
            //        _Employee.Employee_Mobile_2 = txtEmpMob2.Text;
            //        _Employee.Employee_National_Id = TxtEmpNataionalId.Text;
            //        _Employee.Employee_Email = TxtEmpEmail.Text;
            //        _Employee.Employee_Address = TxtEmpAddress.Text;
                    
            //        _Employee.Employee_Start_Jop = DateTime.Now;

            //        _Employee.Employee_End_Jop = DateTime.Now;


            //        _Employee.Employee_Notes = TxtEmpNote.Text;
            //        _Employee.SexTypeCode = Convert.ToInt16(slkSex.EditValue);
                  

            //        _Employee.Last_Modified_Date = DateTime.Now;
            //        _Employee.Last_Modified_User = st.User_Code();
            //        context.SaveChanges();
            //        frm.gcEmployeeCard.DataSource = context.Employee_View.Where(x => x.IsDeleted == 0).ToList();
            //        frm.gcEmployeeCard.RefreshDataSource();
            //        MaterialMessageBox.Show("تم التعديل", MessageBoxButtons.OK);
            //    }
            //    else
            //    {
            //        using (PointOfSaleEntities ForCheck = new PointOfSaleEntities())
            //        {

            //            bool TestUserName = ForCheck.Employees.Any(Emp => Emp.Employee_Name == TxtEmpName.Text && Emp.IsDeleted == 0);
            //            if (TestUserName)
            //            { 
                        
            //            MaterialMessageBox.Show("تم تسجيل هذا الاسم لموظف اخر", MessageBoxButtons.OK);
            //            return;
                        
            //            }
            //            bool TestNatId = ForCheck.Employees.Any(Emp => Emp.Employee_National_Id == TxtEmpNataionalId.Text && Emp.IsDeleted == 0);
            //            if (TestUserName)
            //            {

            //                MaterialMessageBox.Show("تم تسجيل رقم البطاقة لموظف اخر", MessageBoxButtons.OK);
            //                return;

            //            }
            //        };

            //        Employee _Employee = new Employee()
            //        {
            //            Employee_Code = EmpCode,
            //            Employee_Name = TxtEmpName.Text,
            //            Employee_Mobile_1 = txtEmpMob1.Text,
            //            Employee_Mobile_2 = txtEmpMob2.Text,
            //            Employee_National_Id = TxtEmpNataionalId.Text,
            //            Employee_Email = TxtEmpEmail.Text,
            //            Employee_Address = TxtEmpAddress.Text,
                       
            //            Employee_Start_Jop = DateTime.Now,
            //            Employee_End_Jop = DateTime.Now,
            //            Employee_Notes = TxtEmpNote.Text,
            //            Created_Date = DateTime.Now,
            //            SexTypeCode = Convert.ToInt16(slkSex.EditValue),
            //            Branch_ID = Convert.ToInt64(slkBranch.EditValue),
            //            Last_Modified_User = st.User_Code(),
            //            Jop_Code = Convert.ToInt64(slkJop.EditValue),
            //            img_Url = "",
                        

            //        };
            //        context.Employees.Add(_Employee);
            //        context.SaveChanges();
            //        using (PointOfSaleEntities NewContext = new PointOfSaleEntities())
            //        { 
                    
            //            frm.gcEmployeeCard.DataSource = NewContext.Employee_View.Where(x => x.IsDeleted == 0).ToList();
            //        frm.gcEmployeeCard.RefreshDataSource();
            //        frm.gcEmployeeCard.Enabled = true;
                    
                    
            //        }

                   
            //    }

            //}
        }

    

        public void Delete()
        {
            //Customer_Info _Customer;
            //_Customer = db.Customer_Info.SingleOrDefault(customer => customer.Customer_Phone == TxtMob.Text);
            //_Customer.IsDeleted = 1;
            //db.SaveChanges();
            //MaterialMessageBox.Show("تم الحذف", MessageBoxButtons.OK);
        }

      
        public void GetById()
        {
            throw new NotImplementedException();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            #region Vaildate
            if (string.IsNullOrWhiteSpace(txtEmpCode.Text))
            {

                MaterialMessageBox.Show("برجاء ادخال كود للعميل", MessageBoxButtons.OK);
                return;


            }
            if (string.IsNullOrEmpty(txtEmpMob2.Text))
            {

                MaterialMessageBox.Show("برجاء ادخال رقم الموبيل", MessageBoxButtons.OK);
                return;


            }
            if (string.IsNullOrEmpty(TxtEmpName.Text))
            {
                MaterialMessageBox.Show("برجاء ادخال اسم العميل", MessageBoxButtons.OK);

                return;
            }
            #endregion
           
            Save();
          
            Rest();
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtEmpMob2.Text))
            //{
            //    MaterialMessageBox.Show("برجاء ادخال رقم الموبيل", MessageBoxButtons.OK);
               
            //    return;
            //}
            //SplashScreenManager.ShowForm(typeof(WaitForm1));
            //Delete();
            //Rest();
            //SplashScreenManager.CloseForm();
        }



        void Rest()
        {
            txtEmpMob2.Text = "";
            TxtEmpName.Text = "";
            TxtEmpEmail.Text = "";
            TxtEmpNataionalId.Text = "";
            TxtEmpAddress.Text = "";
            txtEmpMob1.Text = "";
            txtEmpMob2.Text = "";
            TxtEmpNote.Text = "";
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
