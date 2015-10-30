using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionManagement
{
    public partial class ViewStateweb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["number"] != null)
            {
                ViewState["number"] = Convert.ToInt32(ViewState["number"]) + 1;
            }
            else
            {
                ViewState["number"] = 1;
            }
            lblcount.Text = ViewState["number"].ToString();
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {

        }
    }
}