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
        readonly DB_A65D4E_SolarEnergyEntities context = new DB_A65D4E_SolarEnergyEntities();
        readonly Static st = new Static();
        public frmAddCustomer()
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void FillSexSlk()
        {

            
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }
        public void Save()
        {
             
        }
    }
}