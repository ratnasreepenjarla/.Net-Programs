using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
public partial class Users_ViewAnsweredQuestions : System.Web.UI.Page
{
    Forums fr = new Forums();
    protected void Page_Load(object sender, EventArgs e)
    {
        ViewAnsweredQuestionGrid.DataSource = fr.GetAnsweredQuestions();
        ViewAnsweredQuestionGrid.DataBind();

    }
    
}