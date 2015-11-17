using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hiddenfieldasp
{
    public partial class Hiddenfield : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int num = 10;
            HiddenField1.Value = num.ToString();
            lblname.Text = "rama";
            lblpswd.Text = "sitha";

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            lblhiddenvalue.Text = HiddenField1.Value;
        }
    }
}