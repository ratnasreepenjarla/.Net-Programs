using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Panelasp
{
    public partial class Panelform : System.Web.UI.Page
    {
        String str = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand("select *from Employees", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "employees");
                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "name";
                DropDownList1.DataBind();
            }
        }


        protected void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
        
           
            SqlCommand cmd = new SqlCommand("update Employees set name=@newname1 where name=@newname", con);
            cmd.Parameters.AddWithValue("@newname1", txtentername.Text);
            cmd.Parameters.AddWithValue("@newname", DropDownList1.SelectedItem.ToString());
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            lblmsg.Text = "record is updated";
            txtentername.Text = "";


     }
    }
}