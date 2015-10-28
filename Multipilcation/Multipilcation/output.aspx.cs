using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Multipilcation
{
    public partial class output : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                int number1 = int.Parse(Request.QueryString["number"]);
                int range1 = int.Parse(Request.QueryString["range"]);

                DataTable dtCurrentTable = new DataTable();
                dtCurrentTable.Columns.Add(new DataColumn("number", typeof(String)));
                dtCurrentTable.Columns.Add(new DataColumn("multiplicant", typeof(String)));
                dtCurrentTable.Columns.Add(new DataColumn("result", typeof(String)));
                DataRow dr2 = null;
                for (int i = 1; i <= range1; i++)
                {

                    dr2 = dtCurrentTable.NewRow();
                    dr2["number"] = number1;
                    dr2["multiplicant"] = i;
                    dr2["result"] = i * number1;
                    dtCurrentTable.Rows.Add(dr2);
                }

                GridView1.DataSource = dtCurrentTable;
                GridView1.DataBind();
            }

            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
        }
    }
}