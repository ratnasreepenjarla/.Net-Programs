using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionManagementstateserver
{
    public partial class wlcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            linkid.Text = Session["id"].ToString();
            lblmessage.Text = "welcome to this page";
        }

        protected void btnlogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}