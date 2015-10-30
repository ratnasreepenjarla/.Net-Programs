using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionManagement
{
    public partial class QueryString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["number"] != null) //Lets retrieve, increase and store again
            {
                lblcount.Text = Request.QueryString["number"];
            }

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
      

            int postbacks = 0;
            if (Request.QueryString["number"] != null) //Lets retrieve, increase and store again
            {
                postbacks = Convert.ToInt32(Request.QueryString["number"]) + 1;
            }
            else //First postback, lets store the info
            {
                postbacks = 1;
            }
            Response.Redirect("QueryString.aspx?number=" + postbacks);

        }
    }
}