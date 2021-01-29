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
            
          
        }
        private void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
          
        }

        private void اضافةصنفجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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