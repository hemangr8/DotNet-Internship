using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameworkAssignment
{
    public partial class UploadFilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNormalUserWelcomeMessage.Text = "Hello " + Session["UserName"];
        }

        protected void btnNormalUserUpload_Click(object sender, EventArgs e)
        {
            if (fileNormalUserFileUpload.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(fileNormalUserFileUpload.FileName);

                if (fileExtension.ToLower() != ".txt")
                {
                    lblNormalUserFileUploadMessage.ForeColor = System.Drawing.Color.Red;
                    lblNormalUserFileUploadMessage.Text = "Only files with .txt extension are allowed";
                }
                else
                {
                    int fileSize = fileNormalUserFileUpload.PostedFile.ContentLength;
                    if (fileSize > 2097152)
                    {
                        lblNormalUserFileUploadMessage.ForeColor = System.Drawing.Color.Red;
                        lblNormalUserFileUploadMessage.Text = "File size cannot be greater than 2 MB";
                    }
                    else
                    {
                        fileNormalUserFileUpload.SaveAs(Server.MapPath("~/Normal User Files/" + fileNormalUserFileUpload.FileName));
                        lblNormalUserFileUploadMessage.ForeColor = System.Drawing.Color.Green;
                        lblNormalUserFileUploadMessage.Text = "File uploaded successfully";
                    }
                }
            }
            else
            {
                lblNormalUserFileUploadMessage.ForeColor = System.Drawing.Color.Red;
                lblNormalUserFileUploadMessage.Text = "Please select a file";
            } 
        }

        protected void btnNormalUserLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/UserLoginPage.aspx");
        }
    }
}