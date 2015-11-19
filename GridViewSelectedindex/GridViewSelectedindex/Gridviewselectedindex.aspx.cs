using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace GridViewSelectedindex
{
    public partial class Gridviewselectedindex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String str = ConfigurationManager.ConnectionStrings["advisor"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from advisor",con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            con.Close();
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = (GridViewRow)GridView1.Rows[e.NewSelectedIndex];
            Label l1 = (Label)row.FindControl("lblid");
            int id = Convert.ToInt32(l1.Text);

            Label l2 = (Label)row.FindControl("lblname");
            String name = l2.Text;

            lblidname.Text = "Empid:" + id;
            lblname1.Text = "empname:" + name;

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}