using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Gridviewdropdown
{
    public partial class GridDropdown : System.Web.UI.Page
    {
       String str=ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
           {
               bind();
           }
           
        }
        public void bind()
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from Employees", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "employees");
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField ="name";
            DropDownList1.DataBind();

       }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Employees where name=@ename", con);
            String name1 = DropDownList1.SelectedItem.ToString();
            cmd.Parameters.AddWithValue("ename",name1);
            cmd.ExecuteNonQuery();
            con.Close();
            lblmsg.Text = "record is deleted";
            bind();
        }
    }
}


