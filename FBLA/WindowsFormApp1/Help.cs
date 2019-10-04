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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            lblNew.Text = "Click the sign up button, then fill out the form to create a new profile";
            lblReturn.Text = "Enter your email and password on the home screen, then click login";
            lblReport.Text = "Click the report button to view a list of everyone with a profile";
        }

        private void lblNew_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
