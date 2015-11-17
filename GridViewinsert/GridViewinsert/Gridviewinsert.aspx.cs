using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace GridViewinsert
{
    public partial class Gridviewinsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
           

        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            String connectionstring = ConfigurationManager.ConnectionStrings["Details"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand("insert into Emp values(@eno,@ename,@salary)", con);
            cmd.Parameters.AddWithValue("@eno", txteno.Text);
            cmd.Parameters.AddWithValue("@ename", txtename.Text);
            cmd.Parameters.AddWithValue("@salary", txtsalary.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("inserted successfully");
        }
    }
}