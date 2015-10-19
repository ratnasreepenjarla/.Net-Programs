namespace EmployeeRegistration
{
    partial class Form1
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
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtphnum = new System.Windows.Forms.TextBox();
            this.lblphnum = new System.Windows.Forms.Label();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblcpassword = new System.Windows.Forms.Label();
            this.txtcpassword = new System.Windows.Forms.TextBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(6, 16);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(33, 13);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(66, 9);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 1;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(6, 46);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(31, 13);
            this.lblemail.TabIndex = 0;
            this.lblemail.Text = "email";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(66, 43);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 2;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(8, 104);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender";
            this.lblGender.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtphnum
            // 
            this.txtphnum.Location = new System.Drawing.Point(66, 65);
            this.txtphnum.Name = "txtphnum";
            this.txtphnum.Size = new System.Drawing.Size(100, 20);
            this.txtphnum.TabIndex = 3;
            // 
            // lblphnum
            // 
            this.lblphnum.AutoSize = true;
            this.lblphnum.Location = new System.Drawing.Point(8, 72);
            this.lblphnum.Name = "lblphnum";
            this.lblphnum.Size = new System.Drawing.Size(39, 13);
            this.lblphnum.TabIndex = 0;
            this.lblphnum.Text = "phnum";
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Location = new System.Drawing.Point(80, 100);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(47, 17);
            this.rbmale.TabIndex = 2;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(171, 102);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(56, 17);
            this.rbfemale.TabIndex = 2;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(6, 165);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(52, 13);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "password";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(66, 158);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(100, 20);
            this.txtpassword.TabIndex = 5;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(6, 132);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(53, 13);
            this.lblusername.TabIndex = 3;
            this.lblusername.Text = "username";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(66, 125);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 4;
            // 
            // lblcpassword
            // 
            this.lblcpassword.AutoSize = true;
            this.lblcpassword.Location = new System.Drawing.Point(6, 193);
            this.lblcpassword.Name = "lblcpassword";
            this.lblcpassword.Size = new System.Drawing.Size(58, 13);
            this.lblcpassword.TabIndex = 3;
            this.lblcpassword.Text = "cpassword";
            // 
            // txtcpassword
            // 
            this.txtcpassword.Location = new System.Drawing.Point(66, 190);
            this.txtcpassword.Name = "txtcpassword";
            this.txtcpassword.PasswordChar = '*';
            this.txtcpassword.Size = new System.Drawing.Size(100, 20);
            this.txtcpassword.TabIndex = 6;
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(91, 227);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(75, 23);
            this.btnregister.TabIndex = 7;
            this.btnregister.Text = "register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtcpassword);
            this.Controls.Add(this.lblcpassword);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.rbfemale);
            this.Controls.Add(this.rbmale);
            this.Controls.Add(this.txtphnum);
            this.Controls.Add(this.lblphnum);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtphnum;
        private System.Windows.Forms.Label lblphnum;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblcpassword;
        private System.Windows.Forms.TextBox txtcpassword;
        private System.Windows.Forms.Button btnregister;
    }
}

