using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Gridviewdelete
{
    public partial class Gridviewdelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String str=ConfigurationManager.ConnectionStrings["Details"].ConnectionString;
           if(!IsPostBack)
           {
               SqlConnection con = new SqlConnection(str);
               SqlCommand cmd = new SqlCommand("select *from Employees", con);
               SqlDataAdapter da = new SqlDataAdapter(cmd);
               DataSet ds = new DataSet();
               da.Fill(ds, "EmpNew");
               DropDownList1.DataSource = ds;
               DropDownList1.DataTextField = "name";
               DropDownList1.DataBind();


           }
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            String str = ConfigurationManager.ConnectionStrings["Details"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("delete  from Employees where name=@name", con);
            cmd.Parameters.AddWithValue("@name",DropDownList1.SelectedItem.Value);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("deleted successfully");
        }
    }
}