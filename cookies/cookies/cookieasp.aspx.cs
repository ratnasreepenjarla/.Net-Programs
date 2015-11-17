using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookies
{
    public partial class cookieasp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("userdetails");
            cookie["id"] = txtid.Text;
            cookie["name"]=txtname.Text;
            cookie.Expires = DateTime.Now.AddMilliseconds(6000);
            Response.Cookies.Add(cookie);
            Response.Redirect("logout.aspx");
        }
    }
}