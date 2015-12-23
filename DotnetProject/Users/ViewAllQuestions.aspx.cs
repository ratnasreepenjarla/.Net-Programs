using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DataAccessLayer;

public partial class Users_ViewAllQuestions : System.Web.UI.Page
{
    Forums fr = new Forums();
    
    protected void Page_Load(object sender, EventArgs e)
    {
       DataTable dt=fr.GetDetails();;
       ViewAllQuariesGrid.DataSource = dt;
       ViewAllQuariesGrid.DataBind();
    }
}