using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace GridViewDemo
{
    public partial class GridViewdemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String con = "Data Source=SYS-PC;Initial Catalog=ratna;Integrated Security=True";
            SqlConnection cons = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand("select * from Employees", cons);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //SqlDataReader dr = cmd.ExecuteReader();
            da.Fill(ds, "Employees");
            GridView1.DataSource = ds;  //dr
            GridView1.DataBind();


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}