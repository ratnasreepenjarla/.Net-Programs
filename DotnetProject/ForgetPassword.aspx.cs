using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

public partial class ForgetPassword : System.Web.UI.Page
{
    Dbusers dbusers = new Dbusers();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnGetPassword_Click(object sender, EventArgs e)
    {
        dbusers.UserName = txtUserName.Text;
        dbusers.SecurityQuestion = ddlSelectQuestion.SelectedItem.ToString();
        dbusers.Answer = txtAnswer.Text;
        lblforgetpswd.Text = "Password is " + dbusers.GetPassword(dbusers); 
             
    }
}