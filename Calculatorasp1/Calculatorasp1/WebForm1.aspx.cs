using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculatorasp1
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            String value = (sender as Button).Text;
            if(txtresult.Text=="0")
            {
                txtresult.Text = "value";
            }
            else
            {
                txtresult.Text += "value";
            }
        }
        private static String value1;
        private static String operation;
        
        protected void btnadd_Click(object sender, EventArgs e)
        {
            value1 = txtresult.Text;
            txtresult.Text = "0";
            operation = "add";
        }

    }
}