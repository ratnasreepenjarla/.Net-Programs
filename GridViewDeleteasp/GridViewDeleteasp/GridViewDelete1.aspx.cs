using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace GridViewDeleteasp
{
    public partial class GridViewDelete1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String str = ConfigurationManager.ConnectionStrings["dbname"].ConnectionString;
                SqlConnection con = new SqlConnection(str);
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Emp", con);
                SqlDataReader dr = cmd.ExecuteReader();
                GridView1.DataSource = dr;
                GridView1.DataBind();
                con.Close();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            String str = ConfigurationManager.ConnectionStrings["dbname"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            con.Open();
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            Label label = (Label)row.FindControl("lbldelete");
            //int empno = Convert.ToInt32(label.Text);
            int empno = Convert.ToInt32(label.Text);
            SqlCommand cmd = new SqlCommand("delete Emp where eno=@empno", con);
            cmd.Parameters.AddWithValue("@empno", empno);
            cmd.ExecuteNonQuery();
            con.Close();
            lblmsg.Text = "record deleted";
            Response.Redirect("GridViewDelete1.aspx");


        }

       
      
    }
}