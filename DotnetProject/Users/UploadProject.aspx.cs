using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

public partial class Users_UploadProject : System.Web.UI.Page
{
    Projects prj = new Projects();
    protected void Page_Load(object sender, EventArgs e)
    {
        txtprojectid.Text = prj.GenerateProjectId().ToString();
        prj.ProjectId =Convert.ToInt32( txtprojectid.Text);
    }
    protected void btnuploadproject_Click(object sender, EventArgs e)
    {
        prj.ProjectType = txtprojecttype.Text;
        
    }
}