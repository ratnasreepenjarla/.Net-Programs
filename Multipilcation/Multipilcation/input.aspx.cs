using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Multipilcation
{
    public partial class Redirect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
           string number = txtentertnumber.Text;
          string range = txtenterrange.Text;
            Response.Redirect("output.aspx?number=" + number + "&range=" + range);
        }
    }
}