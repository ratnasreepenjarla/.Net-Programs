using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using System.Data;

public partial class Users_SearchArticle : System.Web.UI.Page
{
    Articles art = new Articles();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void searcharticle_Click(object sender, ImageClickEventArgs e)
    {
        
        art.KeyWord = txtkeywordforarticle.Text;
        DataTable dt =art.GetArticlesByKeyWord(art);
       
        SearchArticlesGrid.DataSource =dt;
        SearchArticlesGrid.DataBind();
     
      

    }
}