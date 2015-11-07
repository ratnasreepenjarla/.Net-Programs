using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace StoredprocedureDemo
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            string connect = "Data Source=SYS-PC;Initial Catalog=ratna;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connect))
            {
                SqlCommand cmd = new SqlCommand();

                //SqlCommand cmd = new SqlCommand("Display",con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText ="Display";
                cmd.Connection = con;
                //try
                //{
                    con.Open();
                    GridView1.EmptyDataText = "no records";
                    GridView1.DataSource = cmd.ExecuteReader();
                    GridView1.DataBind();
                    SqlDataAdapter s = new SqlDataAdapter(cmd);
                    DataSet d = 
                //}
                //catch(Exception ex)
                //{
                //    throw ex;
                //}

            }
            }

    }

}