using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Onetier
{
    public partial class Onetier : System.Web.UI.Page
    {
        static String connectionstring = ConfigurationManager.ConnectionStrings["onetierdb"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionstring);
        SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Binddropdown();
            }
        }

        private void Binddropdown()
        {
            try
            {
                
                cmd = new SqlCommand("select * from tbldepartment",con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DropDownList1.DataTextField = "deptnames";
                DropDownList1.DataValueField = "id";
                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, new ListItem("select","0"));
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }     
        

        protected void btninsert_Click(object sender, EventArgs e)
        {
            insertemployee();
        }

        private void insertemployee()
        {
            int i = 0;
            try
            {
                cmd = new SqlCommand("insert into tblemployee(name,salary,deptid)values(@name,@sal,@deptid)",con);
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@sal", txtsalary.Text);
                cmd.Parameters.AddWithValue("@deptid", int.Parse(DropDownList1.SelectedValue));
                con.Open();
                 i = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                con.Close();
            }
            clearcontrol();
            if(i>0)
            {
                Response.Write("rcord is inserted");

            }
            else
            {
                Response.Write("rcord not inserted");
            }
        }

        private void clearcontrol()
        {
            txtname.Text = "";
            txtsalary.Text = "";
            DropDownList1.SelectedIndex = 0;
        }

    }
}