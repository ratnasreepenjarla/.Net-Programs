using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Databasecreation
{
    public partial class databasecreation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncreatedatabase_Click(object sender, EventArgs e)
        {
            String dbname = txtdbname.Text;
            String str = "Data Source=SYS-PC;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("create database "+dbname, con);
               
               
                cmd.ExecuteNonQuery();
                Response.Write("database is created");
            }
            catch(Exception ex)
            {
                Response.Write("database already exsist");

            }
            finally
            {
                con.Close();
            }
            
        }
    }
}