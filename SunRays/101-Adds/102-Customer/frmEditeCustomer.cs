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

namespace SunRays._101_Adds._102_Customer
{
    public partial class frmEditeCustomer : DevExpress.XtraEditors.XtraForm
    {
        //PointOfSaleEntities context = new PointOfSaleEntities();
        Static st = new Static();
        public frmEditeCustomer()
        {
            InitializeComponent();
            FillSexSlk();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      public  void FillSexSlk()
        {

            //var result = context.SexTypes.ToList();
            //slkSex.Properties.DataSource = result;
            //slkSex.Properties.ValueMember = "SexTypeCode";
            //slkSex.Properties.DisplayMember = "SexTypeName";
            //slkSex.EditValue = result[0].SexTypeCode;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditItem();
        }

        void EditItem()
        {
            if (string.IsNullOrWhiteSpace(txtEmpCode.Text))
            {

                MaterialMessageBox.Show("برجاء ادخال كود العميل", MessageBoxButtons.OK);
                return;

            }
            if (string.IsNullOrWhiteSpace(TxtEmpName.Text))
            {
                MaterialMessageBox.Show("برجاء ادخال اسم العميل", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrWhiteSpace(slkSex.Text))
            {

                MaterialMessageBox.Show("برجاءاختيار الجنس", MessageBoxButtons.OK);
                return;

            }

            
             

            if (Application.OpenForms.OfType<frmCustomer>().Any())
            {
            //    frmCustomer frm = (frmCustomer)Application.OpenForms["frmCustomer"];
            //    Int64 EmpCode = Convert.ToInt64(txtEmpCode.Text);
            //    using (PointOfSaleEntities ForCheck = new PointOfSaleEntities())
            //    {
            //        bool TestUserName = ForCheck.Customer_Info.Any(Emp => Emp.Customer_Name == TxtEmpName.Text && Emp.Customer_Code != EmpCode && Emp.IsDeleted == 0);
            //        if (TestUserName)
            //        {
            //            MaterialMessageBox.Show("تم تسجيل هذا الاسم لعميل اخر", MessageBoxButtons.OK);
            //            return;

            //        }
            //        bool TestNatId = ForCheck.Customer_Info.Any(Emp => Emp.National_Id == TxtEmpNataionalId.Text && Emp.IsDeleted == 0);
            //        if (TestUserName)
            //        {

            //            MaterialMessageBox.Show("تم تسجيل رقم البطاقة لعميل اخر", MessageBoxButtons.OK);
            //            return;

            //        }


            //    }

            //    Customer_Info _Customer_Info;
            //    _Customer_Info = context.Customer_Info.SingleOrDefault(Employee => Employee.Customer_Code == EmpCode);
            //    _Customer_Info.Customer_Code = EmpCode;
            //    _Customer_Info.Customer_Name = TxtEmpName.Text;
            //    _Customer_Info.Customer_Phone = txtEmpMob1.Text;
                
            //    _Customer_Info.National_Id = TxtEmpNataionalId.Text;
            //    _Customer_Info.Email = TxtEmpEmail.Text;
            //    _Customer_Info.Customer_Address = TxtEmpAddress.Text;
                 
            //    _Customer_Info.Customer_Notes = TxtEmpNote.Text;
            //    _Customer_Info.SexTypeCode = Convert.ToInt16(slkSex.EditValue);
            //    _Customer_Info.Jop_Descrption = txtJop.Text;


            //    _Customer_Info.Last_Modified_Date = DateTime.Now;
            //    _Customer_Info.Last_Modified_User = st.User_Code();
            //    context.SaveChanges();
            //    frmEmployees frmEmpMain = new frmEmployees();
            //    frmEmpMain.gcEmployeeCard.DataSource = context.Customer_View.Where(x => x.IsDeleted == 0).ToList();
            //    frmEmpMain.gcEmployeeCard.RefreshDataSource();
            //    using (PointOfSaleEntities NewReco = new PointOfSaleEntities())
            //    {

            //        Customer_View result2 = NewReco.Customer_View.Where(x => x.Customer_Code == EmpCode && x.IsDeleted == 0).FirstOrDefault();


            //        frm.gvEmployeeCard.SetFocusedRowCellValue("Customer_Code", result2.Customer_Code);
            //        frm.gvEmployeeCard.SetFocusedRowCellValue("Customer_Name", result2.Customer_Name);
            //        frm.gvEmployeeCard.SetFocusedRowCellValue("Customer_Phone", result2.Customer_Phone);
            //        frm.gvEmployeeCard.SetFocusedRowCellValue("National_Id", result2.National_Id);
            //        frm.gvEmployeeCard.SetFocusedRowCellValue("Email", result2.Email);
            //        frm.gvEmployeeCard.SetFocusedRowCellValue("Jop_Descrption", result2.Jop_Descrption);
            //        frm.gvEmployeeCard.SetFocusedRowCellValue("Customer_Address", result2.Customer_Address);

                  

            //        frm.gvEmployeeCard.SetFocusedRowCellValue("SexTypeName", result2.SexTypeName);
            //        frm.gvEmployeeCard.SetFocusedRowCellValue("Customer_Notes", result2.Customer_Notes);
             
                 


            //        frm.gvEmployeeCard.RefreshData();
            //        //MaterialMessageBox.Show("تم التعديل", MessageBoxButtons.OK);
            //        HelperClass.HelperClass.ClearValues(tableLayoutPanel2);
            //    }


            //    this.Close();
            }

        }
    }
}