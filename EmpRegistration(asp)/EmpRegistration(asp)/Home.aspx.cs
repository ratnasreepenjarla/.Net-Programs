using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace EmpRegistration_asp_
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        
        string ConnectionString = ConfigurationManager.ConnectionStrings["Employee"].ConnectionString;
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (Session["UserName"]==null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Session["UserName"] = Session["UserName"];
                string LoginUser= Session["UserName"].ToString();
            
                using(SqlConnection con=new SqlConnection(ConnectionString))
                {
                    SqlCommand deletecommand = new SqlCommand("delete EmpRegistration where UserName!='LoginUser'", con);
                    con.Open();
                    deletecommand.ExecuteNonQuery();
                    Response.Redirect("Home.aspx");
                }
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Session["UserName"] = Session["UserName"];
                Response.Redirect("EditDetails.aspx");
            }
        }
    }
}