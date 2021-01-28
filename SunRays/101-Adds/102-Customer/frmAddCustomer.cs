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
    public partial class frmAddCustomer : DevExpress.XtraEditors.XtraForm
    {
        //PointOfSaleEntities context = new PointOfSaleEntities();
        readonly Static st = new Static();
        public frmAddCustomer()
        {
            //InitializeComponent();
            //FillSexSlk();
            //Int64? MaxCode = context.Customer_Info.Where(x => x.IsDeleted == 0).Max(u => (Int64?)u.Customer_Code + 1);
            //if (MaxCode == null || MaxCode == 0)
            //{
            //    MaxCode = 1;
            //}


            //txtEmpCode.Text = MaxCode.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void FillSexSlk()
        {

            //var result = context.SexTypes.ToList();
            //slkSex.Properties.DataSource = result;
            //slkSex.Properties.ValueMember = "SexTypeCode";
            //slkSex.Properties.DisplayMember = "SexTypeName";
            //slkSex.EditValue = result[0].SexTypeCode;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Save();
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

           
           


            //if (Application.OpenForms.OfType<frmCustomer>().Any())
            //{
            //    Int64 EmpCode = Convert.ToInt64(txtEmpCode.Text);

            //    bool TestUpdate = context.Customer_View.Any(customer => customer.Customer_Code == EmpCode && customer.IsDeleted == 0);
            //    frmCustomer frm = (frmCustomer)Application.OpenForms["frmCustomer"];
            //    if (TestUpdate)
            //    {

            //        using (PointOfSaleEntities ForCheck = new PointOfSaleEntities())
            //        {

            //            bool TestUserName = ForCheck.Customer_View.Any(Emp => Emp.Customer_Name == TxtEmpName.Text && Emp.Customer_Code != EmpCode && Emp.IsDeleted == 0);
            //            if (TestUserName)
            //            {
            //                MaterialMessageBox.Show("تم تسجيل هذا الاسم لعميل اخر", MessageBoxButtons.OK);
            //                return;

            //            }
            //            bool TestNatId = ForCheck.Customer_View.Any(Emp => Emp.National_Id == TxtEmpNataionalId.Text && Emp.IsDeleted == 0);
            //            if (TestUserName)
            //            {

            //                MaterialMessageBox.Show("تم تسجيل رقم البطاقة لعميل اخر", MessageBoxButtons.OK);
            //                return;

            //            }


            //        }
            //        Customer_Info _Customer_Info;
            //        _Customer_Info = context.Customer_Info.SingleOrDefault(Customer_Info => Customer_Info.Customer_Code == EmpCode);
            //        _Customer_Info.Customer_Code = EmpCode;
            //        _Customer_Info.Customer_Name = TxtEmpName.Text;
            //        _Customer_Info.Customer_Phone = txtEmpMob1.Text;

            //        _Customer_Info.National_Id = TxtEmpNataionalId.Text;
            //        _Customer_Info.Email = TxtEmpEmail.Text;
            //        _Customer_Info.Customer_Address = TxtEmpAddress.Text;

            //        _Customer_Info.Customer_Notes = TxtEmpNote.Text;
            //        _Customer_Info.SexTypeCode = Convert.ToInt16(slkSex.EditValue);


            //        _Customer_Info.Last_Modified_Date = DateTime.Now;
            //        _Customer_Info.Last_Modified_User =  st.User_Code();
            //        context.SaveChanges();
            //        frm.gcEmployeeCard.DataSource = context.Customer_View.Where(x => x.IsDeleted == 0).ToList();
            //        frm.gcEmployeeCard.RefreshDataSource();
            //        MaterialMessageBox.Show("تم التعديل", MessageBoxButtons.OK);
            //    }
            //    else
            //    {
            //        using (PointOfSaleEntities ForCheck = new PointOfSaleEntities())
            //        {

            //            bool TestUserName = ForCheck.Customer_View.Any(Emp => Emp.Customer_Name == TxtEmpName.Text && Emp.IsDeleted == 0);
            //            if (TestUserName)
            //            {

            //                MaterialMessageBox.Show("تم تسجيل هذا الاسم لعميل اخر", MessageBoxButtons.OK);
            //                return;

            //            }
            //            bool TestNatId = ForCheck.Customer_View.Any(Emp => Emp.National_Id == TxtEmpNataionalId.Text && Emp.IsDeleted == 0);
            //            if (TestUserName)
            //            {

            //                MaterialMessageBox.Show("تم تسجيل رقم البطاقة لعميل اخر", MessageBoxButtons.OK);
            //                return;

            //            }
            //        };

            //        Customer_Info _Customer_View = new Customer_Info()
            //        {
            //            Customer_Code = EmpCode,
            //            Customer_Name = TxtEmpName.Text,
            //            Customer_Phone = txtEmpMob1.Text,
                         
            //            National_Id = TxtEmpNataionalId.Text,
            //            Email = TxtEmpEmail.Text,
            //            Customer_Address = TxtEmpAddress.Text,
                       
                     
            //            Customer_Notes = TxtEmpNote.Text,
            //            SexTypeCode = Convert.ToInt16(slkSex.EditValue),
                   
            //            Created_Date = DateTime.Now,
            //            Last_Modified_User = st.User_Code(),
            //            Jop_Descrption = txtJop.Text
                       


            //        };
            //        context.Customer_Info.Add(_Customer_View);
            //        context.SaveChanges();
            //        using (PointOfSaleEntities NewContext = new PointOfSaleEntities())
            //        {

            //            frm.gcEmployeeCard.DataSource = NewContext.Customer_View.Where(x => x.IsDeleted == 0).ToList();
            //            frm.gcEmployeeCard.RefreshDataSource();
            //            frm.gcEmployeeCard.Enabled = true;


            //        }


            //    }

            //}
        }
    }
}