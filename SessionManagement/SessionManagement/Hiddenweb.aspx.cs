using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionManagement
{
    public partial class Hiddenweb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            int newval = Convert.ToInt32(HiddenField1.Value) + 1;
            HiddenField1.Value = newval.ToString();
            lblcount.Text = HiddenField1.Value;
            //string value = txtname.Text;
            //HiddenField1.Value = value;
            //lblcount.Text = HiddenField1.Value;

        }
    }
}