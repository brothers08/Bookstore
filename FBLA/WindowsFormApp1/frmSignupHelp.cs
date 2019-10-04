using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmSignupHelp : Form
    {
        public frmSignupHelp()
        {
            InitializeComponent();
            lblHelp.Text = "Fill out all fields on the form to create your profile.";
            lblCode.Text = "Your redemption code is automatically generated.";
            lblInfo.Text = "Information can be viewed in the report once you have created your profile.";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
