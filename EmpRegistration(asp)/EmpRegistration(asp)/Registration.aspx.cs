using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Text;
namespace EmpRegistration_asp_
{
    public partial class Registration : System.Web.UI.Page
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
            if(rbMale.Checked==true)
            {
                Gender=rbMale.Text;
            }
            else if (rbFemale.Checked == true)
            {
               Gender=rbFemale.Text;
            }
            else
            {
                error.Append("please select anyone option");
            }
        string ConnectionString = ConfigurationManager.ConnectionStrings["Employee"].ConnectionString;
        using(SqlConnection con=new SqlConnection(ConnectionString))
        {
            String insertcommand = "insert into EmployeeRegistration(Name,UserName,Password,Confirmpassword,Emailid,PhoneNumber,Gender,DOB,Designation,Joining)values('{0}','{1}''{2}','{3}','{4}','{5}','{6}','{7}','{8}''{9}')";
            SqlCommand cmd =new SqlCommand(String.Format(insertcommand,Name,UserName,Password,Emailid,PhoneNumber,Gender,DOB,Designation,Joining),con);
            con.Open();
            try{
            cmd.ExecuteNonQuery();
           Response.Write("values inserted successfully");
            }
            catch(Exception ex)
            {

            }
        }
        
        
        }
    }
}