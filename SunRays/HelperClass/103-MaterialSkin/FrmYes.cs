using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunRays.HelperClass._103_MaterialSkin
{
    public partial class FrmYes : MaterialSkin.Controls.MaterialForm
    {
        public string Messages { get; set; }
        public FrmYes()
        {
            InitializeComponent();
             
        }
        void FillLabal()
        {
            Message.Text = Messages;
        }
        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {

        }

        private void FrmYes_Load(object sender, EventArgs e)
        {
            FillLabal();
        }
    }
}
