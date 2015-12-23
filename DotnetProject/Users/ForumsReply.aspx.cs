using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

public partial class Users_ForumsReply : System.Web.UI.Page
{
    Forums fr = new Forums();
    Dbusers dbusers = new Dbusers();
    protected void Page_Load(object sender, EventArgs e)
    {
        lblreply.Visible = false;
        String Qid=Request.QueryString["QuestionId"].ToString();
        fr.QuestionId= Convert.ToInt32(Qid);
        lblgetquestion.Text = fr.GetQuestion(fr);
    }
    protected void btnPostReply_Click(object sender, EventArgs e)
    {
        dbusers.UserName = Session["UserName"].ToString();    
        fr.Question = lblgetquestion.Text;
        fr.Answer = txtAnswer.Text;
        dbusers.Loginid = dbusers.GetLoginId(dbusers);
        fr.ReplyId = fr.GetReplyId();
        int i = fr.ReplyQuery();
        if(i>o)
        {
            lblreply.Text = "Reply saved successfully";
        }
        else
        {
            lblreply.Text = "Reply not saved ";
        }
        lblreply.Visible = true;
    }
}