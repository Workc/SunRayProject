using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;
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
    public partial class frmCustomer : DevExpress.XtraEditors.XtraForm
    {
        
        public frmCustomer()
        {
            InitializeComponent();
            FillGride();
          
        }

        void FillGride()
        {
            //gcEmployeeCard.DataSource = null;
            //using (PointOfSaleEntities Contexts = new PointOfSaleEntities())
            //{

            //    var empData = (from a in Contexts.Customer_View where a.IsDeleted == 0 select a).OrderBy(x => x.Customer_Code).ToList();


            //    if (empData.Count > 0)
            //    {

            //        gcEmployeeCard.DataSource = empData;
            //        gcEmployeeCard.RefreshDataSource();
            //        gcEmployeeCard.Enabled = true;

            //    }
            //    else
            //    {

            //        gcEmployeeCard.Enabled = false;
            //        windowsUIButtonPanel.Buttons.ForEach(x =>
            //        {

            //            if (x.Properties.Caption == "تعديل" || x.Properties.Caption == "طباعة" || x.Properties.Caption == "حذف")
            //            {

            //                x.Properties.Enabled = false;

            //            }
            //            if (x.Properties.Caption == "جديد")
            //            {

            //                x.Properties.Enabled = true;

            //            }

            //        });




            //    }
            //}


        }


        private void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            //WindowsUIButton btn = e.Button as WindowsUIButton;
            //if (btn.Caption == "جديد")
            //{
            //    frmAddCustomer frm = new frmAddCustomer();
            //    frm.ShowDialog();
            //}
            //else if (btn.Caption == "تعديل")
            //{

            //    if (gvEmployeeCard.RowCount <= 0)
            //    {
            //        return;
            //    }

            //    frmEditeCustomer frm = new frmEditeCustomer();

            //    var x = gvEmployeeCard.GetFocusedRow() as Customer_View;
                 
                 
            //    frm.FillSexSlk();

            //    frm.txtEmpCode.Text = x.Customer_Code.ToString();
            //    frm.TxtEmpName.Text = x.Customer_Name.ToString();
            //    frm.txtEmpMob1.Text = x.Customer_Phone.ToString();

            //    frm.txtJop.Text = x.Customer_Phone.ToString();
               
               

            //    frm.TxtEmpEmail.Text = x.Email.ToString();
            //    frm.TxtEmpAddress.Text = x.Customer_Address.ToString();
            //    frm.TxtEmpNote.Text = x.Customer_Notes.ToString();
            //    frm.TxtEmpNataionalId.Text = x.National_Id.ToString();
                
            //    frm.txtJop.Text = x.Jop_Descrption;
            //    frm.slkSex.Text = x.SexTypeName;
                

            //    frm.ShowDialog();

            //}
            //else if (btn.Caption == "خروج")
            //{

            //    this.Close();


            //}
            //else if (btn.Caption == "حذف")
            //{

            //    if (gvEmployeeCard.RowCount <= 0)
            //    {


            //        return;
            //    }
            //    if (MaterialMessageBox.Show("تاكيد الحذف", MessageBoxButtons.YesNo) == DialogResult.OK)
            //    {

            //        Customer_View xx = gvEmployeeCard.GetFocusedRow() as Customer_View;


            //        using (PointOfSaleEntities Contexts = new PointOfSaleEntities())
            //        {
            //            Customer_Info _Customer_Info = new Customer_Info();
            //            _Customer_Info = Contexts.Customer_Info.SingleOrDefault(item => item.Customer_Code == xx.Customer_Code);
            //            Contexts.Customer_Info.Remove(_Customer_Info);
            //            Contexts.SaveChanges();
            //            var result = (from a in Contexts.Customer_View where a.IsDeleted == 0 select a).ToList();
            //            gcEmployeeCard.DataSource = result;
            //            gcEmployeeCard.RefreshDataSource();
            //            MaterialMessageBox.Show("تم الحذف", MessageBoxButtons.OK);
            //            if (gvEmployeeCard.RowCount <= 0)
            //            {
            //                gcEmployeeCard.Enabled = false;
            //                windowsUIButtonPanel.Buttons.ForEach(x =>
            //                {

            //                    if (x.Properties.Caption == "تعديل" || x.Properties.Caption == "طباعة" || x.Properties.Caption == "حذف")
            //                    {

            //                        x.Properties.Enabled = false;

            //                    }
            //                    if (x.Properties.Caption == "جديد")
            //                    {

            //                        x.Properties.Enabled = true;

            //                    }

            //                });

            //                return;
            //            }
            //        }

            //    }


            //}
        }

        private void جديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCustomer frm = new frmAddCustomer();
            frm.ShowDialog();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (gvEmployeeCard.RowCount <= 0)
            //{
            //    return;
            //}

            //frmEditeCustomer frm = new frmEditeCustomer();

            //var x = gvEmployeeCard.GetFocusedRow() as Customer_View;
            
           
            ////frm.FillSexSlk();

            //frm.txtEmpCode.Text = x.Customer_Code.ToString();
            //frm.TxtEmpName.Text = x.Customer_Name.ToString();
            //frm.txtEmpMob1.Text = x.Customer_Phone.ToString();
           
            //frm.TxtEmpNataionalId.Text = x.National_Id.ToString();
            

            //frm.TxtEmpEmail.Text = x.Email.ToString();
            //frm.TxtEmpAddress.Text = x.Customer_Address.ToString();
            //frm.TxtEmpNote.Text = x.Customer_Notes.ToString();
            //frm.TxtEmpNataionalId.Text = x.National_Id.ToString();
            //frm.slkSex.Text = x.SexTypeName;
            //frm.txtJop.Text = x.Jop_Descrption;
            //frm.slkSex.EditValue = x.SexTypeCode;


            //frm.ShowDialog();
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (gvEmployeeCard.RowCount <= 0)
            //{


            //    return;
            //}
            //if (MaterialMessageBox.Show("تاكيد الحذف", MessageBoxButtons.YesNo) == DialogResult.OK)
            //{

            //    Customer_View xx = gvEmployeeCard.GetFocusedRow() as Customer_View;


            //    using (PointOfSaleEntities Contexts = new PointOfSaleEntities())
            //    {
            //        Customer_Info _Customer_Info = new Customer_Info();
            //        _Customer_Info = Contexts.Customer_Info.SingleOrDefault(item => item.Customer_Code == xx.Customer_Code);
            //        Contexts.Customer_Info.Remove(_Customer_Info);
            //        Contexts.SaveChanges();
            //        var result = (from a in Contexts.Customer_View where a.IsDeleted == 0 select a).ToList();
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
    }
}