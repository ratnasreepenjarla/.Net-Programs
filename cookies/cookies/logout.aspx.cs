using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookies
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["userdetails"];
            if(cookie!=null)
            {
                lblid.Text = cookie["id"];
                lblname.Text = cookie["name"];
            }

        }

        protected void btnlogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("cookieasp.aspx");
        }
    }
}