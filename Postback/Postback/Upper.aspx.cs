using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Postback
{
    public partial class Upper : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtentertext_TextChanged(object sender, EventArgs e)
        {
            String text = txtentertext.Text;
            txtoutput1.Text = text.ToUpper();
            txtoutput2.Text = text.ToLower();
        }
    }
}