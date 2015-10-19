using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeRegistration
{
    public partial class Form1 : Form
    {
        String ConnectionString = "Data Source=SYS-PC;Initial Catalog=ratna;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            String name = null;
            if (String.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Please enter name");
            }
            else
            {
                Regex namevalidator = new Regex(@"^[a-zA-Z]+$");
                if (namevalidator.Match(txtname.Text).Success)
                {
                    name = txtname.Text;
                }
                else
                {
                    MessageBox.Show("name field contain only aplhabets");
                    txtname.Clear();
                }
            }

            //string email = txtemail.Text;
            //if (!System.Text.RegularExpressions.Regex.IsMatch(name, "^[a-zA-Z]+$"))
            //{
            //    MessageBox.Show("This textbox accepts only alphabetical characters");
            //    txtname.Clear();
            //}

            String email = null;
            String email2 = null;

            if (String.IsNullOrWhiteSpace(txtemail.Text))
            {
                MessageBox.Show("email should not be empty");
            }
            else
            {
                Regex emailvalidator = new Regex(@"^[a-zA-Z0-9]+@+[gmail,rediff,outlook]+.+[com]$");
                if (emailvalidator.Match(txtemail.Text).Success)
                {
                    email = txtemail.Text;
                }
                else
                {
                    MessageBox.Show("email should be in correct format");
                    txtemail.Clear();
                }
            }
            Int64 phnum = 0;
            if (phnum.ToString().Length > 10)
            {
                MessageBox.Show("phone number must contain 10 digits only");
                txtphnum.Clear();
            }
            else
            {
                phnum = Int64.Parse(txtphnum.Text);

            }
            String cpassword = txtcpassword.Text;
            String username = txtusername.Text;
            String password = txtpassword.Text;
            String Gender = null;
            if (!((rbmale.Checked == true) || (rbfemale.Checked == true)))
            {
                MessageBox.Show("Please select anyone");
            }
            else if (rbmale.Checked == true)
            {
                Gender = rbmale.Text;
            }
            else
            {
                Gender = rbfemale.Text;
            }

            if (!(password.Length > 8 && password.Length < 15))
            {
                MessageBox.Show("password sholud be greaterthan 8 and lesstahn 15");
                txtpassword.Clear();
            }
            else
            {
                if (Passwordvalid(password))
                {
                    if (!(password == cpassword))
                    {
                        MessageBox.Show("password and conform password should be same");

                        //txtusername.Clear();
                        //txtpassword.Clear();
                        //txtcpassword.Clear();
                        //rbmale.Checked = false;
                        //rbfemale.Checked = false;
                        //txtname.Clear();
                        //txtemail.Clear();
                        //txtphnum.Clear();
                    }
                    else
                    {
                        using (SqlConnection con = new SqlConnection(ConnectionString))
                        {
                            SqlCommand cmd = new SqlCommand("select email from Employees", con);
                            con.Open();
                            SqlDataReader emailreader = cmd.ExecuteReader();
                            while (emailreader.Read())
                            {
                                email2 = emailreader["email"].ToString();
                            }
                            if (email2 == email)
                            {
                                MessageBox.Show("email should be unique");
                            }
                            else
                            {
                                Savedetails(name, email, phnum, cpassword, username, password, Gender);
                            }

                        }
                    }
                }
            }
        }



        private static void Savedetails(String name, String email, Int64 phnum, String cpassword, String username, String password, String Gender)
        {
            try
            {
                String ConnectionString = "Data Source=SYS-PC;Initial Catalog=ratna;Integrated Security=True";

                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string insertcmd = "insert into Employees(name,email,phnum,Gender,username,password,cpassword) values('{0}','{1}',{2},'{3}','{4}','{5}','{6}')";
                    SqlCommand cmd = new SqlCommand(String.Format(insertcmd, name, email, phnum, Gender, username, password, cpassword), con);
                    //if (!(name == null && email == null && phnum ==0 && Gender == null && username == null && password == null && cpassword == null))
                    //  {
                    //          cmd.ExecuteNonQuery();
                    //          MessageBox.Show("values inserted successfully");
                    //  }
                    //else
                    //{
                    //    MessageBox.Show("We should fill all fields");
                    //}

                    //con.Close();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("values inserted successfully");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        public bool Passwordvalid(String password)
        {
            Regex validator = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");
            if (validator.Match(password).Success)
                return true;
            else
                MessageBox.Show("password shold contain atleast 1 uppercase,1 lowecase,1 digit,1 special character");
            return false;


        }
    }
}


