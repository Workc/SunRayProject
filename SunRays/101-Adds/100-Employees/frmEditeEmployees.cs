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
    public partial class frmEditeEmployees : DevExpress.XtraEditors.XtraForm
    {
        readonly DB_A65D4E_SolarEnergyEntities context = new DB_A65D4E_SolarEnergyEntities();
        readonly Static st = new Static();
        public frmEditeEmployees()
        {
            InitializeComponent();

        }
        public void FillJopSlk()
        {
        }

        public void FillBranchSlk()
        {
        }


        public void FillSexSlk()
        {
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
        }
        void EditItem()
        {
        }

        private void btnCancel_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
        }
    }
}