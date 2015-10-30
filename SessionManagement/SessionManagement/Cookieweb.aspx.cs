using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionManagement
{
    public partial class Cookieweb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int postbacks=0;
            if(Request.Cookies["number"]!=null)
            {
                postbacks = Convert.ToInt32(Request.Cookies["number"].Value) + 1;
            }
            else
            {
                postbacks = 1;

            }
            Response.Cookies["number"].Value = postbacks.ToString();
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            lblcount.Text = Response.Cookies["number"].Value;
            Response.Cookies["number"].Expires = DateTime.Now.AddSeconds(10);
        }
    }
}