﻿using DevExpress.XtraEditors;

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

namespace SunRays._101_Adds._112_Users
{
    public partial class frmAddUser : DevExpress.XtraEditors.XtraForm
    {
        readonly DB_A65D4E_SolarEnergyEntities context = new DB_A65D4E_SolarEnergyEntities();
        readonly Static st = new Static();
        public frmAddUser()
        {
            InitializeComponent();
             
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        void FillEmpSlk()
        {
          
           
        }

        private void slkEmp_EditValueChanged(object sender, EventArgs e)
        {
            
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}