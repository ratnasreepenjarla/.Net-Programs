using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using System.Drawing;

public partial class Register : System.Web.UI.Page
{
    Dbusers dbusers = new Dbusers();

    protected void Page_Load(object sender, EventArgs e)
    {

        autoGenerateLoginId();
    }

    private void autoGenerateLoginId()
    {
        dbusers.LoginId = dbusers.GenerateLoginid();
        txtLoginid.Text = dbusers.LoginId.ToString();
    }
    
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        int i = 0;
        dbusers.Name = txtName.Text;
        dbusers.UserName = txtUserName.Text;
        dbusers.Password = txtpassword.Text;
        dbusers.ConfirmPassword = txtConfirmPassword.Text;
        dbusers.Email = txtEmail.Text;
        dbusers.PhoneNumber = txtPhoneNumber.Text;
        dbusers.SecurityQuestion = ddlSelectQuestion.SelectedItem.Value;
        dbusers.Answer = txtAnswer.Text;
        dbusers.Status = "Pending";
        i = dbusers.insertUser(dbusers);
        if(i>0)
        {
            lblmsg.Text="Registerd Successfully";
        }
        else
        {
            lblmsg.Text="Registration Failed";
        }

         clear();
         txtLoginid.Text = dbusers.GenerateLoginid().ToString();

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        clear();

    }

    private void clear()
    {
      
        txtName.Text = "";
        txtUserName.Text = "";
        txtpassword.Text = "";
        txtConfirmPassword.Text = "";
        txtEmail.Text = "";
        txtPhoneNumber.Text = "";
        ddlSelectQuestion.SelectedIndex = 0;
        txtAnswer.Text = "";
        
    }

    
}
