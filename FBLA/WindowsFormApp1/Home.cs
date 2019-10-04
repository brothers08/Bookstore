using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    //Written by Ciara Brothers
    //February 2019
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            frmSignUp form = new frmSignUp();
            form.ShowDialog();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int studentCounter = 0;
        public string address = "";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string password = txtPassword.Text;
                string email = txtEmail.Text;
                bool match = false;
                string[] student = { };

                //Open Text File
                string path = Path.Combine(Environment.CurrentDirectory, @"..\..\books.txt");
                FileInfo fi = new FileInfo(path);
                using (StreamReader sr = fi.OpenText())
                {
                    studentCounter++;
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        student = s.Split('|');
                        //Check if Email is Valid
                        if (student[5] == password && student[3] == email)
                        {
                            match = true;
                            sr.Close();
                            break;
                        }
                    }
                    if (!match)
                    {
                        MessageBox.Show("Email or Password is Incorrect!");

                    }
                    else
                    {
                        //Open Returning User Screen
                        frmReturn login = new frmReturn();
                        //Put Student Array Data into Data Array
                        login.data = student;
                        login.ShowDialog();

                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Login information invalid");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport report = new frmReport();
            report.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }
    }
}
