using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

public partial class Login : System.Web.UI.Page
{
    Dbusers dbusers = new Dbusers();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Session["UserName"] = txtUserName.Text;
        dbusers.UserName = txtUserName.Text;
        dbusers.Password = txtPassword.Text;
        int i = dbusers.ValidateUser(dbusers);
        if(i>0)
        {
            Response.Redirect("~/Users/Home.aspx");
        }
        else
        {
            Response.Write("invalid username and password");
        }
       
    }
}