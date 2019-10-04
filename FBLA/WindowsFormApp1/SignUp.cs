using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;

namespace WindowsFormsApp1
{

    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
            txtCode.Text = GetStudentID();
        }

        public string grade = "";

        private string GetStudentID()
        {
            string studentId;
            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\books.txt");
            string lastRecord = File.ReadLines(path).Last();
            string[] student = lastRecord.Split('|');
            //id is NT00001
                string id = student[0];
                //idNum is 00001
                string idNum = id.Substring(2);
                //newId is 1
                long newId = long.Parse(id);
                //newId is 2
                newId++;
                studentId = "";
                if (newId < 10)
                {
                    studentId += "0000" + newId.ToString();
                }
                else if (newId < 100)
                {
                    studentId += "000" + newId.ToString();
                }
                else if (newId < 1000)
                {
                    studentId += "00" + newId.ToString();
                }
                else if (newId < 10000)
                {
                    studentId += "0" + newId.ToString();
                }
                else
                {
                    studentId += newId.ToString();
                }
            
            return studentId;
        }

        public static bool IsValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string first = txtName.Text;
                string last = txtLast.Text;
                string email = maskEmail.Text;
                string code = txtCode.Text;
                string password = txtPassword.Text;
                bool check = IsValidEmail(maskEmail.Text);

                if (first == "" || last == "" || email == "" || password == ""|| (code == "" && rdoFresh.Checked == false
                    && rdoSoph.Checked == false && rdoJunior.Checked == false
                    && rdoSenior.Checked == false) || cboClass.SelectedIndex == -1 || cbBook.SelectedIndex == -1)
                {
                    throw new Exception("Please fill in all fields");
                }

                if (rdoFresh.Checked)
                {
                    grade = "Freshman";
                }
                else if (rdoSoph.Checked)
                {
                    grade = "Sophmore";
                }
                else if (rdoJunior.Checked)
                {
                    grade = "Junior";
                }
                else
                {
                    grade = "Senior";
                }

                if (!check)
                {
                    throw new Exception("Invalid Email");
                }

                FileInfo fi = new FileInfo(@"..\..\books.txt");
                using (StreamWriter sw = fi.AppendText())
                {
                    sw.WriteLine(code + "|" + first + "|" + last + "|" + email + "|"
                        + grade + "|" + password + "|" + cbBook.SelectedItem + "|" + cboClass.SelectedItem);
                    sw.Close();
                }

                MessageBox.Show("Thank You for signing up!");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }     
        }

        private void maskCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmSignupHelp help = new frmSignupHelp();
            help.ShowDialog();
        }
    }
}
