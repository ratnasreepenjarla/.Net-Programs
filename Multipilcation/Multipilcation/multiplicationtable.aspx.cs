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
            DataTable dt = new DataTable();
            dt.TableName = "multiplicationtable1";
            dt.Columns.Add(new DataColumn("number", typeof(int)));
            dt.Columns.Add(new DataColumn("multiplicant", typeof(int)));
            dt.Columns.Add(new DataColumn("result", typeof(int)));
            DataRow dr = dt.NewRow();
            dt.Rows.Add(dr);
            GridView1.DataSource = dt;
            GridView1.DataBind();


        }

        protected void btnsave_Click(object sender, EventArgs e)
        {

            int number = int.Parse(txtentertnumber.Text);
            int range = int.Parse(txtenterrange.Text);
            DataTable dtCurrentTable = (DataTable)ViewState["multiplicationtable1"];
            DataRow dr2 = null;


            for (int i = 1; i <= range; i++)
            {

                dr2 = dtCurrentTable.NewRow();
                dr2["number"] = number;
                dr2["multiplicant"] = i;
                dr2["result"] = i * number;
            }

            dtCurrentTable.Rows.Add(dr2);
            ViewState["multiplicationtable1"] = dtCurrentTable;
            GridView1.DataSource = dtCurrentTable;
            GridView1.DataBind();

        }
            //int result = 0;
            //for(int i=1;i<=range;i++)
            // {
            //   result = number * i;
            // }
            //String connectionString = ConfigurationManager.ConnectionStrings["ratna"].ConnectionString;
            //using(SqlConnection con=new SqlConnection(connectionString))
            //{
            //    String insert="insert into multiplication(number,range,result)values({0},{1},{2})";
            //    SqlCommand cmd = new SqlCommand(String.Format(insert, number, range, result),con);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //}
        }
    }
