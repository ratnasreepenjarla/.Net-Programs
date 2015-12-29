using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

public partial class Users_PostArticle : System.Web.UI.Page
{
    Articles art = new Articles();
    Dbusers dbusers = new Dbusers();
    protected void Page_Load(object sender, EventArgs e)
    {
        art.ArticleId = art.GenerateAritcleid();
        txtArticleIdd.Text = art.ArticleId.ToString();
    }
    protected void btnPostArticle_Click(object sender, EventArgs e)
    {
        dbusers.UserName = Session["UserName"].ToString();
        art.LoginId = dbusers.GetLoginId(dbusers);

        DateTime date=DateTime.Now;
        art.ArticleType = txtArticleType.Text;
        art.ArticleDescription = txtArticleDescrption.Text;
        art.CDate=date.TimeOfDay.ToString();
        
        
        int i = art.PostArticle(art);
        if(i>0)
        {
            Response.Write("<script>alert('Article Posted Successfully')</script>");
        }
        else
        {
            Response.Redirect("<script>alert('Article Posting Failed')</script>");
        }
    }
}