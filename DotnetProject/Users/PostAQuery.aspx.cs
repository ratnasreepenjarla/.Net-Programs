using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;


public partial class Users_PostAQuery : System.Web.UI.Page
{
    Dbusers dbusers=new Dbusers();
    Forums fr = new Forums();
    protected void Page_Load(object sender, EventArgs e)
    {
        

        txtQuestionId.Text = fr.GenerateQuestionId().ToString();
   
    }
    protected void btnPostQuery_Click(object sender, EventArgs e)
    {
        int i=0;
        dbusers.UserName = Session["UserName"].ToString();
        fr.Question = txtQuestion.Text;
        fr.LoginId = fr.GetLoginId(dbusers);
        fr.QuestionId =Convert.ToInt32(txtQuestionId.Text);
        i = fr.PostQuery(fr);
        if(i>0)
        {
            lblposted.Text= "Query Posted Successfully";
        }
        else
        {
            lblposted.Text = "posting failed";
        }
    }
}