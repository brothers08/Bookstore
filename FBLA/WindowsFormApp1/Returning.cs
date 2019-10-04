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
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class frmReturn : Form
    {
        public frmReturn()
        {
            InitializeComponent();
            //receive studentCounter
            hideButtons();
        }

        public string[] data;

        //Put Data from Array into Labels
        private void DisplayReport()
        {
            lblID.Text = data[0];
            lblFirst.Text = data[1];
            lblLast.Text = data[2];
            ea = data[3];
            lblGrade.Text = data[4];
        }

        //Sign Out Button
        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReturn_Load(object sender, EventArgs e)
        {
            //Receive Student Array from Home Page Login
            DisplayReport();
        }

        //Checks if Email is Valid
        public static bool IsValidEmail(string emailaddress)
        {
            try
            {
                Regex rx = new Regex(
            @"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");
                return rx.IsMatch(emailaddress);
            }
            catch (FormatException)
            {
                return false;
            }
        }

        string ea = "";

        private void changeEmail()
        {
            try
            {
                bool check = IsValidEmail(txtCurrent.Text);
                bool valid = IsValidEmail(txtNew.Text);
                if (txtCurrent.Text != ea || !valid)
                {
                    MessageBox.Show("Invalid Email");
                }
                else
                {
                    frmConfirm confirm = new frmConfirm();
                    DialogResult result = confirm.ShowDialog();
                    if (result == DialogResult.Yes)
                    {
                        //Update Email in database
                        String[] rows;
                        string filename = @"..\..\books.txt";
                        using (StreamReader sr = File.OpenText(filename))
                        {
                            rows = Regex.Split(sr.ReadToEnd(), "\r\n");
                        }
                        bool match = false;
                        using (StreamWriter sw = new StreamWriter(filename))
                        {
                            for (int i = 0; i < (rows.Length - 1); i++)
                            {
                                if (rows[i].Contains(txtCurrent.Text) && !match)
                                {
                                    rows[i] = rows[i].Replace(txtCurrent.Text, txtNew.Text);
                                    match = true;
                                }
                                sw.WriteLine(rows[i]);
                            }
                        }

                        MessageBox.Show("Email Updated");
                        hideButtons();
                    }
                    else
                    {
                        MessageBox.Show("Email not Updated");
                        hideButtons();
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Please enter a valid email");
                MessageBox.Show(ex.Message); //handles any error
            }
        }
        private void changePassword()
        {
            try
            {
                frmConfirm confirm = new frmConfirm();
                DialogResult result = confirm.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    //Update password in database
                    String[] rows;
                    string filename = @"..\..\books.txt";
                    using (StreamReader sr = File.OpenText(filename))
                    {
                        rows = Regex.Split(sr.ReadToEnd(), "\r\n");
                    }

                    using (StreamWriter sw = new StreamWriter(filename))
                    {
                        for (int i = 0; i < (rows.Length - 1); i++)
                        {
                            if (rows[i].Contains(txtCurrent.Text))
                            {
                                rows[i] = rows[i].Replace(txtCurrent.Text, txtNew.Text);
                            }
                            sw.WriteLine(rows[i]);
                        }
                    }
                }
                MessageBox.Show("Password Updated");
                hideButtons();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Please enter a valid email");
                MessageBox.Show(ex.Message); //handles any error
            }
        }
        private void changeName()
        {
            try
            {
                if (txtCurrent.Text == "" || txtNew.Text == "")
                {
                    MessageBox.Show("Please fill all fields");
                }
                else
                {
                    frmConfirm confirm = new frmConfirm();
                    DialogResult result = confirm.ShowDialog();
                    if (result == DialogResult.Yes)
                    {
                        //Update name in database
                        String[] rows;
                        string filename = @"..\..\books.txt";
                        using (StreamReader sr = File.OpenText(filename))
                        {
                            rows = Regex.Split(sr.ReadToEnd(), "\r\n");
                        }

                        using (StreamWriter sw = new StreamWriter(filename))
                        {
                            for (int i = 0; i < rows.Length - 1; i++)
                            {
                                if (rows[i].Contains(data[1]))
                                {
                                    rows[i] = rows[i].Replace(data[1], txtCurrent.Text);
                                    rows[i] = rows[i].Replace(data[2], txtNew.Text);
                                }
                                sw.WriteLine(rows[i]);
                            }
                        }
                        MessageBox.Show("Name Changed");
                        hideButtons();
                        lblFirst.Text = txtCurrent.Text;
                        lblLast.Text = txtNew.Text;
                    }
                    else
                    {
                        MessageBox.Show("Name not updated");
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Please enter a valid email");
                MessageBox.Show(ex.Message); //handles any error
            }
        }
        private void changeGrade()
        {
            try
            {
                frmConfirm confirm = new frmConfirm();
                DialogResult result = confirm.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    //Update grade in database
                    String[] rows;
                    string filename = @"..\..\books.txt";
                    using (StreamReader sr = File.OpenText(filename))
                    {
                        rows = Regex.Split(sr.ReadToEnd(), "\r\n");
                    }

                    using (StreamWriter sw = new StreamWriter(filename))
                    {
                        for (int i = 0; i < rows.Length - 1; i++)
                        {
                            if (rows[i].Contains(data[4]))
                            {
                                rows[i] = rows[i].Replace(data[4], cboGrade.Text);
                            }
                            sw.WriteLine(rows[i]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Please enter a valid email");
                MessageBox.Show(ex.Message); //handles any error
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you would like to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result==DialogResult.Yes)
            {
                //delete current record
                String[] rows;
                string filename = @"..\..\books.txt";
                int records = File.ReadAllLines(filename).Length;
                using (StreamReader sr = File.OpenText(filename))
                {
                    rows = Regex.Split(sr.ReadToEnd(), "\r\n");
                }
                File.Delete(filename);
                int newlines = rows.Length - 1;
                using (StreamWriter sw = File.CreateText(filename))
                {
                    for (int i = 0; i < newlines; i++)
                    {
                        if (!rows[i].Contains(data[0]))
                        {
                            sw.WriteLine(rows[i]);
                        }
                    }
                }
                this.Close();
            }
           
        }

        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
            lblCategory.Text = "Change Email";
            lblCurrent.Text = "Current Email";
            lblNew.Text = "New Email";
            showButtons();
            hideGrade();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            lblCategory.Text = "Change Password";
            lblCurrent.Text = "Current Password";
            lblNew.Text = "New Password";
            showButtons();
            hideGrade();
        }
        private void hideButtons()
        {
            lblCategory.Visible = false;
            lblCurrent.Visible = false;
            lblNew.Visible = false;
            txtCurrent.Visible = false;
            txtNew.Visible = false;
            btnCancel.Visible = false;
            btnUpdate.Visible = false;
        }

        private void hideGrade()
        {
            lblChangeGrade.Visible = false;
            cboGrade.Visible = false;
        }
        private void showButtons()
        {
            lblCategory.Visible = true;
            lblCurrent.Visible = true;
            lblNew.Visible = true;
            txtCurrent.Visible = true;
            txtNew.Visible = true;
            btnCancel.Visible = true;
            btnUpdate.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lblCategory.Text == "Change Email")
            {
                if (txtCurrent.Text == "" || txtNew.Text == "")
                {
                    MessageBox.Show("Please fill all fields");
                }
                else
                {
                    changeEmail();
                    txtCurrent.Clear();
                    txtNew.Clear(); 
                }
            }
            else if (lblCategory.Text == "Change Password")
            {
                if (txtNew.Text == "" || txtCurrent.Text == "")
                {
                    MessageBox.Show("Please fill all fields");
                }
                else
                {
                    changePassword();
                    txtCurrent.Clear();
                    txtNew.Clear();
                }
            }
            else if (lblCategory.Text == "Change Name:")
            {
                bool first = txtCurrent.Text.All(Char.IsLetter);
                bool last = txtNew.Text.All(Char.IsLetter);
                if (!first || !last)
                {
                    MessageBox.Show("Please enter letters only");
                }
                else
                {
                    changeName();
                    txtCurrent.Clear();
                    txtNew.Clear();
                }
            }
            else
            {
                if (cboGrade.Text == "")
                {
                    MessageBox.Show("Please select an item from the list");
                }
                else
                { 
                changeGrade();
                MessageBox.Show("Grade Changed");
                lblChangeGrade.Visible = false;
                cboGrade.Visible = false;
                btnUpdate.Visible = false;
                btnCancel.Visible = false;
                lblGrade.Text = cboGrade.Text;
                txtCurrent.Clear();
                txtNew.Clear();
                }
            }
        }

        //Change Name Button
        private void btnName_Click(object sender, EventArgs e)
        {
            lblCategory.Text = "Change Name:";
            lblCurrent.Text = "Enter First Name:";
            lblNew.Text = "Enter Last Name:";
            showButtons();
            hideGrade();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            lblCategory.Text = "Change Grade:";
            hideButtons();
            btnUpdate.Visible = true;
            btnCancel.Visible = true;
            lblChangeGrade.Visible = true;
            cboGrade.Visible = true;
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCurrent.Clear();
            txtNew.Clear();
            cboGrade.SelectedIndex = -1;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmLoginHelp help = new frmLoginHelp();
            help.ShowDialog();
        }
    }
}
