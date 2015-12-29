using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace GridView_with_checkbox
{
    public partial class GridViewWithCheckBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ConnectDB();
        }
        public void ConnectDB()
        {
            string cnstr = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
            try
            {
                using (SqlConnection cn = new SqlConnection(cnstr))
                {
                    cn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from Products",cn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    gv.DataSource = ds;
                    gv.DataBind();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }
    }
}