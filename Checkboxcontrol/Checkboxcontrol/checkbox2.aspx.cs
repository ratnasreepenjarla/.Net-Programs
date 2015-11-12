using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Checkboxcontrol
{
    public partial class checkbox2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

     

        protected void language(object sender, EventArgs e)
        {
            int count = 0;
            string msg = "";


            if (checktelugu.Checked)
            {
                msg = checktelugu.Text + "<br/>";
                count++;

            }
            if (checkenglish.Checked)
            {
                msg = msg + checkenglish.Text + "<br/>";
                count++;
            }
            lblmsg.Text = msg;
            if (count == 0)
            {

                lblmsg.Text = "select any language";
            }
        }
    }
}