using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameworkAssignment
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblAdminWelcomeMessage.Text = "Hello " + Session["UserName"];
        }


        protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
        {
            GridView1.DataBind();
        }

        protected void btnAdminUpload_Click(object sender, EventArgs e)
        {
            if (fileAdminUpload.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(fileAdminUpload.FileName);

                if (fileExtension.ToLower() != ".txt")
                {
                    lblAdminFileUploadMessage.ForeColor = System.Drawing.Color.Red;
                    lblAdminFileUploadMessage.Text = "Only files with .txt extension are allowed";
                }
                else
                {
                    int fileSize = fileAdminUpload.PostedFile.ContentLength;
                    if (fileSize > 2097152)
                    {
                        lblAdminFileUploadMessage.ForeColor = System.Drawing.Color.Red;
                        lblAdminFileUploadMessage.Text = "File size cannot be greater than 2 MB";
                    }
                    else
                    {
                        fileAdminUpload.SaveAs(Server.MapPath("~/Admin Files/" + fileAdminUpload.FileName));
                        lblAdminFileUploadMessage.ForeColor = System.Drawing.Color.Green;
                        lblAdminFileUploadMessage.Text = "File uploaded successfully";
                    }
                }
            }
            else
            {
                lblAdminFileUploadMessage.ForeColor = System.Drawing.Color.Red;
                lblAdminFileUploadMessage.Text = "Please select a file";
            } 
        }

        protected void btnLogoutAdmin_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/UserLoginPage.aspx");
        }
    }
}