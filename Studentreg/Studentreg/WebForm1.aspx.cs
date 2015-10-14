using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Studentreg
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phno = txtPhno.Text;
            string email = txtemail.Text;
            string dob = ddlDate.Text + "-" + ddlmonth.Text + "-" + ddlyear.Text;
            string gender;
            if(rbmale.Checked==true)
            {
                gender = rbmale.Text;
            }
            else
            {
                gender = rbfemale.Text;
            }

            string connectionString = "Data Source=SYS-PC;Initial Catalog=ratna;Integrated Security=True";
            using(SqlConnection connection=new SqlConnection(connectionString) )
            {
                connection.Open();
                string insertCommand = "insert into Student(Name,phoneNumber,EmailId,DateOfBirth,Gender) values('{0}','{1}','{2}','{3}','{4}')";
                using(SqlCommand cmd=new SqlCommand(string.Format(insertCommand,name,phno,email,dob,gender),connection))
                {
                    cmd.ExecuteNonQuery();
                   
                }

            }
        }

        protected void btnreset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPhno.Text= "";
            txtemail.Text = "";
            rbmale.Checked = false;
            rbfemale.Checked = false;
            ddlDate.ClearSelection();
            ddlmonth.ClearSelection();
            ddlyear.ClearSelection();


        }
    }
}