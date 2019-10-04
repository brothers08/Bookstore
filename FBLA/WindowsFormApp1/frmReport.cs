using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
            runReport();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void runReport()
        {
            txtReport.Text = "Book\t\t\t" + "Course\t" + "             Redemption Code\t" + 
                "    Student Name" + Environment.NewLine;
            txtReport.Text += "------------------------------------------------------------" +
                "-----------------------------------------------------------------------------------------" + Environment.NewLine;
            string[] student;
            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\books.txt");
            FileInfo fi = new FileInfo(path);
            using (StreamReader sr = fi.OpenText())
            {

                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    student = s.Split('|');
                    txtReport.Text += student[6] + "\t" + student[7] + "\t   " + student[0] + "\t\t    " + student[1] + " "
                        + student[2] + Environment.NewLine;

                }
            }
        }
    }
}
