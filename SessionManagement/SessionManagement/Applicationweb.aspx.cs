using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionManagement
{
    public partial class Applicationweb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            Application.Lock();
            Application["number"] = Convert.ToInt32(Application["number"]) + 1;
            Application.UnLock();
           lblcount.Text = Application["number"].ToString();
        }
    }
}