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
    public partial class frmLoginHelp : Form
    {
        public frmLoginHelp()
        {
            InitializeComponent();
            lblView.Text = "Here you can view your Name, Grade, and ID (your Redemption Code).";
            lblChange.Text = "Click the buttons to edit the information you entered when you signed up.";
            lblDelete.Text = "Click the Delete Account button to permanently remove your profile.";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
