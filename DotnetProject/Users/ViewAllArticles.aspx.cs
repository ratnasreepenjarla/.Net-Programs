using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using System.Data;

public partial class Users_ViewAllArticles : System.Web.UI.Page
{
    Articles art = new Articles();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = art.GetAllArticles();
        SearchArticlesGrid.DataSource = dt;
        SearchArticlesGrid.DataBind();

    }
}