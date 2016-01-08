using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;


namespace FileConceptasp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=SYS-PC;Initial Catalog=ratna;Integrated Security=True");
        
        protected void Page_Load(object sender, EventArgs e)
        {
              if(!IsPostBack)
              {
                  BindGridViewData();
              }
        }
        public void BindGridViewData()
        {
            SqlCommand cmd = new SqlCommand("select * from FileInformation", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "FielInfo");
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
          
            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            Stream str = FileUpload1.PostedFile.InputStream;
            BinaryReader br = new BinaryReader(str);
            byte[] size = br.ReadBytes((int)str.Length);
            SqlConnection con = new SqlConnection("Data Source=SYS-PC;Initial Catalog=ratna;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into FileInformation(Filename,Filetype,FileData)values(@name,@type,@data)", con);
            cmd.ExecuteNonQuery();
            con.Close();


        }

      
    }
}