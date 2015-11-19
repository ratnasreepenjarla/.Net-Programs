using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace GridviewEditing
{
    public partial class Gridviewediting : System.Web.UI.Page
    {
        String str = ConfigurationManager.ConnectionStrings["advisor"].ConnectionString;
        public void bind()
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select *from advisor", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "advisor1");
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                bind();
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            bind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            bind();
            lblmsg.Text = "name update is cancelled";
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            con.Open();
         
           
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            
            Label l1 = (Label)row.FindControl("lblid");
            int id = Convert.ToInt32(l1.Text);

            TextBox txtbox = (TextBox)row.FindControl("txtname");
            String name = txtbox.Text;
            GridView1.EditIndex = -1;
            SqlCommand cmd = new SqlCommand("update advisor set aname=@name where aid=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);

            cmd.ExecuteNonQuery();
            con.Close();

            bind();

             


        }
    }
}