using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Checkboxcontrol
{
    public partial class checkboxlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a=0;
            String msg = "";
            lblmsg.Text = "";
                
            for (int i = 0; i < checklist1.Items.Count; i++)
            {
                if(checklist1.Items[i].Selected )
                {
                    lblmsg.Text += checklist1.Items[i].Text+"<br/>";
                    a++;
                }
               
            }

            if(a==0)
            {
                lblmsg.Text ="please select any one";
                
            }
        }
    }
}