namespace WindowsFormsApp1
{
    partial class frmSignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoSenior = new System.Windows.Forms.RadioButton();
            this.rdoJunior = new System.Windows.Forms.RadioButton();
            this.rdoSoph = new System.Windows.Forms.RadioButton();
            this.rdoFresh = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.maskEmail = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBook = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Email:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoSenior);
            this.groupBox1.Controls.Add(this.rdoJunior);
            this.groupBox1.Controls.Add(this.rdoSoph);
            this.groupBox1.Controls.Add(this.rdoFresh);
            this.groupBox1.Location = new System.Drawing.Point(47, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 112);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Grade:";
            // 
            // rdoSenior
            // 
            this.rdoSenior.AutoSize = true;
            this.rdoSenior.Location = new System.Drawing.Point(7, 89);
            this.rdoSenior.Name = "rdoSenior";
            this.rdoSenior.Size = new System.Drawing.Size(78, 17);
            this.rdoSenior.TabIndex = 3;
            this.rdoSenior.TabStop = true;
            this.rdoSenior.Text = "12th Grade";
            this.rdoSenior.UseVisualStyleBackColor = true;
            // 
            // rdoJunior
            // 
            this.rdoJunior.AutoSize = true;
            this.rdoJunior.Location = new System.Drawing.Point(7, 66);
            this.rdoJunior.Name = "rdoJunior";
            this.rdoJunior.Size = new System.Drawing.Size(78, 17);
            this.rdoJunior.TabIndex = 2;
            this.rdoJunior.TabStop = true;
            this.rdoJunior.Text = "11th Grade";
            this.rdoJunior.UseVisualStyleBackColor = true;
            // 
            // rdoSoph
            // 
            this.rdoSoph.AutoSize = true;
            this.rdoSoph.Location = new System.Drawing.Point(7, 43);
            this.rdoSoph.Name = "rdoSoph";
            this.rdoSoph.Size = new System.Drawing.Size(78, 17);
            this.rdoSoph.TabIndex = 1;
            this.rdoSoph.TabStop = true;
            this.rdoSoph.Text = "10th Grade";
            this.rdoSoph.UseVisualStyleBackColor = true;
            // 
            // rdoFresh
            // 
            this.rdoFresh.AutoSize = true;
            this.rdoFresh.Location = new System.Drawing.Point(7, 20);
            this.rdoFresh.Name = "rdoFresh";
            this.rdoFresh.Size = new System.Drawing.Size(72, 17);
            this.rdoFresh.TabIndex = 0;
            this.rdoFresh.TabStop = true;
            this.rdoFresh.Text = "9th Grade";
            this.rdoFresh.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(130, 45);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 24);
            this.txtName.TabIndex = 0;
            // 
            // maskEmail
            // 
            this.maskEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskEmail.Location = new System.Drawing.Point(130, 101);
            this.maskEmail.Name = "maskEmail";
            this.maskEmail.Size = new System.Drawing.Size(157, 24);
            this.maskEmail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Textbook:";
            // 
            // cbBook
            // 
            this.cbBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBook.FormattingEnabled = true;
            this.cbBook.Items.AddRange(new object[] {
            "Literature and Composition"});
            this.cbBook.Location = new System.Drawing.Point(145, 328);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(177, 21);
            this.cbBook.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Redemption Code:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(47, 390);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(147, 390);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Cancel";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(145, 358);
            this.txtCode.MaxLength = 5;
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(68, 20);
            this.txtCode.TabIndex = 6;
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskCode_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Create Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(130, 129);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(157, 24);
            this.txtPassword.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Enter Last Name:";
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(130, 73);
            this.txtLast.Multiline = true;
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(157, 24);
            this.txtLast.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Create New Account";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Select Class:";
            // 
            // cboClass
            // 
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Items.AddRange(new object[] {
            "Literature 101"});
            this.cboClass.Location = new System.Drawing.Point(145, 300);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(177, 21);
            this.cboClass.TabIndex = 4;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(247, 390);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 17;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmSignUp
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(188)))), ((int)(((byte)(218)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbBook);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sign Up";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoSenior;
        private System.Windows.Forms.RadioButton rdoJunior;
        private System.Windows.Forms.RadioButton rdoSoph;
        private System.Windows.Forms.RadioButton rdoFresh;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MaskedTextBox maskEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Button btnHelp;
    }
}

