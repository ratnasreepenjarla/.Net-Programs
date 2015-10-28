using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Multipilcation
{
    public partial class multiplicationtable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            


        }

        protected void btnsave_Click(object sender, EventArgs e)
        {

            newRecord();

        }

        private void newRecord()
        {
            try
            {
                int number = int.Parse(txtentertnumber.Text);
                int range = int.Parse(txtenterrange.Text);

                DataTable dtCurrentTable = new DataTable();
                dtCurrentTable.Columns.Add(new DataColumn("number", typeof(String)));
                dtCurrentTable.Columns.Add(new DataColumn("multiplicant", typeof(String)));
                dtCurrentTable.Columns.Add(new DataColumn("result", typeof(String)));
                DataRow dr2 = null;
                for (int i = 1; i <= range; i++)
                {

                    dr2 = dtCurrentTable.NewRow();
                    dr2["number"] = number;
                    dr2["multiplicant"] = i;
                    dr2["result"] = i * number;
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
