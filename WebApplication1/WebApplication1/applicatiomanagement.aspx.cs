using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class applicatiomanagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txttotusers.Text = Application["totusers"].ToString();
            txtactiveusers.Text = Application["activeusers"].ToString();
        }

        protected void btnDestroysession_Click(object sender, EventArgs e)
        {
            Session.Abandon();
        }
    }
}