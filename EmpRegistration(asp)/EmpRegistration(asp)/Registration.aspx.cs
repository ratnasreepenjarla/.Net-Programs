using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;

namespace EmpRegistration_asp_
{
    public partial class Registration1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            String Name = txtName.Text;
            String UserName = txtUserName.Text;
            String Password = txtPassword.Text;
            String Confirmpassword = txtConfirmPassword.Text;
            String Emailid = txtEmailid.Text;
            String PhoneNumber = txtPhoneNumber.Text;
            String Gender = null;
            String DOB = txtDOB.Text;
            string Designation = DdlDesignation.SelectedItem.Value;
            string Joining = txtJoining.Text;

            StringBuilder error = new StringBuilder();
            if (rbMale.Checked == true)
            {
                Gender = rbMale.Text;
            }
            else if (rbFemale.Checked == true)
            {
                Gender = rbFemale.Text;
            }
            else
            {
                error.Append("please select anyone option");
            }

            string ConnectionString = ConfigurationManager.ConnectionStrings["Employee"].ConnectionString;


            //using (sqlconnection con1 = new sqlconnection(connectionstring))
            //{
            //    string selectcommand = "select username,emailid,phonenumber from empregistration";
            //    sqlcommand cmd1 = new sqlcommand(selectcommand, con1);
            //    con1.open();
            //    sqldatareader reader = cmd1.executereader();
            //    while (reader.read())
            //    {
            //        if (txtusername.text == reader["username"].tostring() && txtemailid.text == reader["emailid"].tostring() && txtphonenumber.text == reader["phonenumber"].tostring())
            //        {
            //            lblmessage.text = "username,emailid,phonenumber must be unique";
            //            txtusername.text = string.empty;
            //            txtemailid.text = string.empty;
            //            txtphonenumber.text = string.empty;
            //        }
            //        else
            //        {
                        InsertValues(Name, UserName, Password, Confirmpassword, Emailid, PhoneNumber, Gender, DOB, Designation, Joining, ConnectionString);

                //    }
                //}

            //}
        }

        private void InsertValues(String Name, String UserName, String Password, String Confirmpassword, String Emailid, String PhoneNumber, String Gender, String DOB, string Designation, string Joining, string ConnectionString)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                String insertcommand = "insert into EmpRegistration(Name,UserName,Password,Confirmpassword,Emailid,PhoneNumber,Gender,DOB,Designation,Joining) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')";
                SqlCommand cmd = new SqlCommand(String.Format(insertcommand, Name, UserName, Password, Confirmpassword, Emailid, PhoneNumber, Gender, DOB, Designation, Joining), con);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    lblMessage.Text = "values inserted successfully";
                    Response.Redirect("Login.aspx");
                }

                catch (Exception ex)
                {
                    lblMessage.Text = ex.Message;
                }

        }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = String.Empty;
            txtUserName.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtConfirmPassword.Text = string.Empty;
            txtEmailid.Text = String.Empty;
            txtPhoneNumber.Text = String.Empty;
            txtDOB.Text = String.Empty;
            txtJoining.Text = String.Empty;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            DdlDesignation.ClearSelection();
        }
      
    }
}