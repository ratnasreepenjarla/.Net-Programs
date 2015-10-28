using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionManagement
{
    public partial class Sessionweb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsend_Click(object sender, EventArgs e)
        {
            Session["number"] = Convert.ToInt32(Session["number"]) + 1;
             lblcount.Text = Session["number"].ToString();
          
            
        }
    }
}