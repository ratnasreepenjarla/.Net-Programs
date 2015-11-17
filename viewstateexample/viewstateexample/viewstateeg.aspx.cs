using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace viewstateexample
{
    public partial class viewstateeg : System.Web.UI.Page
    {
        int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                TextBox1.Text = count.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            count++;
            TextBox1.Text = count.ToString();
        }
    }
}