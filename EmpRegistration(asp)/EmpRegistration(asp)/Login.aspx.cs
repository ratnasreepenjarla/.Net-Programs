using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace EmpRegistration_asp_
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignin_Click(object sender, EventArgs e)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["Employee"].ConnectionString;
           using(SqlConnection con=new SqlConnection(ConnectionString))
           {
               SqlCommand cmd = new SqlCommand("select UserName,Password from EmpRegistration", con);
               con.Open();
               SqlDataReader reader = cmd.ExecuteReader();
               while(reader.Read())
               {
                   if (txtUserName.Text .Equals(reader["UserName"]) && txtPassword.Text.Equals(reader["Password"]))
                       {
                           Session["UserName"] = reader["UserName"];
                           Response.Redirect("Home.aspx");
                       }
                     else
                     {
                         lblMessage.Text = "No records found";
                     }
                   
               }

           }
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
    }
}