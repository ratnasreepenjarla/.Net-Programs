using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace EmpRegistration_asp_
{
    public partial class EditDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["Employee"].ConnectionString;

            String name = Session["UserName"].ToString();
            using (SqlConnection con1 = new SqlConnection(ConnectionString))
            {
                String Selectcommand = "select * from EmpRegistration where UserName='{0}'";
                SqlCommand cmd1 = new SqlCommand(string.Format(Selectcommand, name), con1);
                con1.Open();
                SqlDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {

                    //SqlCommand editcmd=new SqlCommand("update table EmpRegistration set ");
                    txtName.Text = reader["Name"].ToString();
                    txtUserName.Text = reader["UserName"].ToString();
                    txtPassword.Text = reader["Password"].ToString();
                    txtConfirmPassword.Text = reader["ConfirmPassword"].ToString();
                    txtEmailid.Text = reader["Emailid"].ToString();
                    txtPhoneNumber.Text = reader["PhoneNumber"].ToString();
                    if(reader["Gender"].ToString()=="male")
                    {
                        rbMale.Checked = true;
                    }
                    else
                    {
                        rbFemale.Checked = true;
                    }
                    txtDOB.Text = reader["DOB"].ToString();
                    
                    DdlDesignation.SelectedItem.Value = reader["Designation"].ToString();

                }

            }
  
        }

       
            protected void btnUpdate_Click(object sender, EventArgs e)
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

          
        }

            protected void btnUpdate_Click1(object sender, EventArgs e)
            {

            }

            

        //private void InsertValues(String Name, String UserName, String Password, String Confirmpassword, String Emailid, String PhoneNumber, String Gender, String DOB, string Designation, string Joining, string ConnectionString)
        //{
        //    using (SqlConnection con = new SqlConnection(ConnectionString))
        //    {
        //        String insertcommand = "insert into EmpRegistration(Name,UserName,Password,Confirmpassword,Emailid,PhoneNumber,Gender,DOB,Designation,Joining) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')";
        //        SqlCommand cmd = new SqlCommand(String.Format(insertcommand, Name, UserName, Password, Confirmpassword, Emailid, PhoneNumber, Gender, DOB, Designation, Joining), con);
        //        con.Open();
        //        try
        //        {
        //            cmd.ExecuteNonQuery();
        //            lblMessage.Text = "values inserted successfully";
        //            Response.Redirect("Login.aspx");
               
        //        }
        //        catch (Exception ex)
        //        {
        //            lblMessage.Text = ex.Message;
        //        }


        //    }
        //}

        
      
        }
    }
