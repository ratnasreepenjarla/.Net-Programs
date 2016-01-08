using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using System.IO;

public partial class Users_UploadProject : System.Web.UI.Page
{
    Projects prj = new Projects();
    Dbusers dbusers=new Dbusers();
    protected void Page_Load(object sender, EventArgs e)
    {
        txtprojectid.Text = prj.GenerateProjectId().ToString();
        prj.ProjectId =Convert.ToInt32(txtprojectid.Text);
    }
    protected void btnuploadproject_Click(object sender, EventArgs e)
    {
        prj.ProjectType = txtprojecttype.Text;
        if (FileUpload1.HasFile)
        {
            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            string extension = Path.GetExtension(FileUpload1.PostedFile.FileName);
            if (extension == ".jpg" || extension == ".bmp" || extension == ".gif" || extension == ".png")
            {
                Response.Write("<script>alert('please select project file like .dox,.txt,.cs,.exe rtc')</script>");
            }
            else
            {
                Stream str = FileUpload1.PostedFile.InputStream;
                BinaryReader br = new BinaryReader(str);
                byte[] size = br.ReadBytes((int)str.Length);

                dbusers.UserName = Session["UserName"].ToString();
                prj.LoginId = dbusers.GetLoginId(dbusers);

                prj.FileName = filename;
                prj.FileType = extension;
                prj.FileData = size;

                int status = prj.InsertPostProject(prj);
                if (status > 0)
                {
                    Response.Write("<script>alert('project uploaded successfully')</script>");
                }
                else
                {
                    Response.Write("<script>alert('project uploading is failed')</script>");
                }
            }
        }
        else
        {
            Response.Write("<script>alert('please select any project')</script>");
        }

    } 

    }
