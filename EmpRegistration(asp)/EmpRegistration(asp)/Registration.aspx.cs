﻿using System;
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
            StringBuilder error = new StringBuilder();
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

            try
            {


                using (SqlConnection con1 = new SqlConnection(ConnectionString))
                {
                    int n = 0;
                    string selectcommand = "select username,emailid,phonenumber from empregistration";
                    SqlCommand cmd1 = new SqlCommand(selectcommand, con1);
                    con1.Open();
                    SqlDataReader reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {

                        n++;
                        if (n == 0)
                        {
                            InsertValues(Name, UserName, Password, Confirmpassword, Emailid, PhoneNumber, Gender, DOB, Designation, Joining, ConnectionString);


                        }
                        else
                        {

                            if (txtUserName.Text == reader["UserName"].ToString() && txtEmailid.Text == reader["Emailid"].ToString() && txtPhoneNumber.Text == reader["phonenumber"].ToString())
                            {
                                lblMessage.Text = "username,emailid,phonenumber must be unique";
                                txtUserName.Text = string.Empty;
                                txtEmailid.Text = string.Empty;
                                txtPhoneNumber.Text = string.Empty;
                                error.Append("error occured");
                            }

                        }

                    }

                }
            }catch(Exception ex)
            {
               }
            if(error.Length==0)
            {
                InsertValues(Name, UserName, Password, Confirmpassword, Emailid, PhoneNumber, Gender, DOB, Designation, Joining, ConnectionString);
 
            }
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
                    FormClear();
                }

                catch (Exception ex)
                {
                    lblMessage.Text = ex.Message;
                }

        }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            FormClear();
        }

        private void FormClear()
        {
            txtName.Text = "";
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
            txtEmailid.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtDOB.Text = string.Empty;
            txtJoining.Text = string.Empty;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            DdlDesignation.ClearSelection();
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
      
    }
}