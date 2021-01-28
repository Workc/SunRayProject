using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;
 
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
       // PointOfSaleEntities context = new PointOfSaleEntities();
        public frmEmployees()
        {
            InitializeComponent();
            FillGride();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {

        }

        private void gcItemCard_Click(object sender, EventArgs e)
        {

        }

        void FillGride()
        {
            //gcEmployeeCard.DataSource = null;
            //using (PointOfSaleEntities Contexts = new PointOfSaleEntities())
            //{

            //    var empData = (from a in Contexts.Employee_View where a.IsDeleted == 0 select a).OrderBy(x => x.Employee_Code).ToList();
                

            //    if (empData.Count > 0)
            //    {

            //        gcEmployeeCard.DataSource = empData;
            //        gcEmployeeCard.RefreshDataSource();

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
            //    FrmAddEmployees frm = new FrmAddEmployees();
            //    frm.ShowDialog();
            //}
            //else if (btn.Caption == "تعديل")
            //{

            //    if (gvEmployeeCard.RowCount <= 0)
            //    {
            //        return;
            //    }

            //     frmEditeEmployees frm = new frmEditeEmployees();

            //   var x = gvEmployeeCard.GetFocusedRow() as Employee_View;
            //    frm.FillBranchSlk();
            //    frm.FillJopSlk();
            //    frm.FillSexSlk();

            //    frm.txtEmpCode.Text =  x.Employee_Code.ToString();
            //    frm.TxtEmpName.Text = x.Employee_Name.ToString();
            //    frm.txtEmpMob1.Text = x.Employee_Mobile_1.ToString();
            //    frm.txtEmpMob2.Text = x.Employee_Mobile_2.ToString();
                
            //    frm.TxtEmpEmail.Text = x.Employee_Email.ToString();
            //    frm.TxtEmpAddress.Text = x.Employee_Address.ToString();
            //    frm.TxtEmpNote.Text = x.Employee_Notes.ToString();
            //    frm.slkBranch.EditValue = x.Branch_ID;
            //    frm.slkJop.EditValue = x.Jop_Code;
            //    frm.slkSex.EditValue = x.SexTypeCode;
                 
                
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

            //        ItemCardView xx = gvEmployeeCard.GetFocusedRow() as ItemCardView;


            //        using (PointOfSaleEntities Contexts = new PointOfSaleEntities())
            //        {
            //            ItemCard _ItemCard = new ItemCard();
            //            _ItemCard = Contexts.ItemCards.SingleOrDefault(item => item.ItemCode == xx.ItemCode);
            //            Contexts.ItemCards.Remove(_ItemCard);
            //            Contexts.SaveChanges();
            //            var result = (from a in Contexts.ItemCardViews where a.IsDeleted == 0 select a).ToList();
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

            


            //else if (btn.Caption == "طباعة")
            //{

            //    if (gvEmployeeCard.RowCount <= 0)
            //    {


            //        return;
            //    }

            //    using (PointOfSaleEntities Contexts = new PointOfSaleEntities())
            //    {

            //        var result = (from a in Contexts.ItemCardViews where a.IsDeleted == 0 select a).ToList();
            //        gcEmployeeCard.DataSource = result;
            //        gcEmployeeCard.RefreshDataSource();

            //        if (gvEmployeeCard.RowCount <= 0)
            //        {

            //            gcEmployeeCard.Enabled = false;

            //        }
            //        else
            //        {

            //            gcEmployeeCard.Enabled = true;
            //        }
            //    }


            //}
        }

        private void اضافةصنفجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddEmployees frm = new FrmAddEmployees();
            frm.ShowDialog();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
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
            //frm.TxtEmpNataionalId.Text = x.Employee_National_Id.ToString();
            //frm.dtEmpStartJop.EditValue = x.Employee_Start_Jop;
            //frm.dtEmpEndJop.EditValue = x.Employee_End_Jop ;

            //frm.TxtEmpEmail.Text = x.Employee_Email.ToString();
            //frm.TxtEmpAddress.Text = x.Employee_Address.ToString();
            //frm.TxtEmpNote.Text = x.Employee_Notes.ToString();
            //frm.slkBranch.EditValue = x.Branch_ID;
            //frm.slkJop.EditValue = x.Jop_Code;
            //frm.slkSex.EditValue = x.SexTypeCode;
            

            //frm.ShowDialog();
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (MaterialMessageBox.Show("تاكيد الحذف", MessageBoxButtons.YesNo) == DialogResult.OK)
            //{
            //    Employee_View xx = gvEmployeeCard.GetFocusedRow() as Employee_View;
            //    Employee _Employees = new Employee();
            //    _Employees =  context.Employees.SingleOrDefault(item => item.Employee_Code == xx.Employee_Code &&item.Branch_ID == xx.Branch_ID && item.IsDeleted == 0);
            //    _Employees.IsDeleted = 1;
            //    context.SaveChanges();
            //    FillGride();
            //}
        }

        public void CheckGridDataCount()
        {

            if (gvEmployeeCard.RowCount <= 0)
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
            else
            {

                gcEmployeeCard.Enabled = true;
                windowsUIButtonPanel.Buttons.ForEach(x =>
                {

                    if (x.Properties.Caption == "تعديل" || x.Properties.Caption == "طباعة" || x.Properties.Caption == "حذف")
                    {

                        x.Properties.Enabled = true;

                    }
                    if (x.Properties.Caption == "جديد")
                    {

                        x.Properties.Enabled = true;

                    }

                });


            }

        }
    }
}