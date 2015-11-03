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

            String LoginUser = Session["UserName"].ToString();
            using (SqlConnection con1 = new SqlConnection(ConnectionString))
            {
                String Selectcommand = "select * from EmpRegistration where UserName='{0}'";
                SqlCommand cmd1 = new SqlCommand(string.Format(Selectcommand, LoginUser), con1);
                con1.Open();
                SqlDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
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
                    txtJoining.Text = reader["Joining"].ToString();

                }

            }
  
        }


        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            //String Name = txtName.Text;
            //String UserName = txtUserName.Text;
            //String Password = txtPassword.Text;
            //String Confirmpassword = txtConfirmPassword.Text;
            //String Emailid = txtEmailid.Text;
            //String PhoneNumber = txtPhoneNumber.Text;
            String Gender1 = null;
            //String DOB = txtDOB.Text;
            //string Designation = DdlDesignation.SelectedItem.Value;
            //string Joining = txtJoining.Text;
            String LoginUser = Session["UserName"].ToString();
            StringBuilder error = new StringBuilder();
            if (rbMale.Checked == true)
            {
                Gender1 = rbMale.Text;
            }
            else if (rbFemale.Checked == true)
            {
                Gender1 = rbFemale.Text;
            }
            else
            {
                error.Append("please select anyone option");
            }

            string ConnectionString = ConfigurationManager.ConnectionStrings["Employee"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                String updatecommand = "update  EmpRegistration set Name = @Name1,Password = @Password1, Confirmpassword = @ConfirmPassword1,Emailid = @Emailid1,PhoneNumber = @PhoneNumber1,Gender='Gender1',Designation = @Designation1,Joining = @JoiningDate1  where UserName= "+LoginUser+"";
                SqlCommand cmd = new SqlCommand(updatecommand, con);
                cmd.Parameters.Add(new SqlParameter("Name1", txtName.Text));
            
                cmd.Parameters.Add(new SqlParameter("Password1", txtPassword.Text));
                cmd.Parameters.Add(new SqlParameter("ConfirmPassword1",txtConfirmPassword.Text));
                cmd.Parameters.Add(new SqlParameter("Emailid1", txtEmailid.Text));
                cmd.Parameters.Add(new SqlParameter("PhoneNumber1", txtPhoneNumber.Text));
                cmd.Parameters.Add(new SqlParameter("DOB1", txtDOB.Text));
                cmd.Parameters.Add(new SqlParameter("Designation1",DdlDesignation.SelectedItem.Value));
                cmd.Parameters.Add(new SqlParameter("JoiningDate1",txtJoining.Text));
                

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    lblMessage.Text = "values updated Successfully";
                    Response.Redirect("Home.aspx");
                }
                catch (Exception ex)
                {
                    lblMessage.Text = ex.Message;

                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

  

        }
    }
