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
       
            String Gender1 = null;
         
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
                con.Open();
                String updatecommand = "update  EmpRegistration set Name=@Name, Emailid = @Emailid,PhoneNumber = @PhoneNumber,Gender=' + Gender1  + ',Designation = @Designation,Joining = @JoiningDate  where UserName=' + LoginUser + '";
                SqlCommand cmd = new SqlCommand(updatecommand, con);
                cmd.Parameters.Add(new SqlParameter("Name", txtName.Text));
                cmd.Parameters.Add(new SqlParameter("Emailid", txtEmailid.Text));
                cmd.Parameters.Add(new SqlParameter("PhoneNumber", txtPhoneNumber.Text));
                cmd.Parameters.Add(new SqlParameter("DOB", txtDOB.Text));
                cmd.Parameters.Add(new SqlParameter("Designation",DdlDesignation.SelectedItem.Value));
                cmd.Parameters.Add(new SqlParameter("JoiningDate",txtJoining.Text));
                

              
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
