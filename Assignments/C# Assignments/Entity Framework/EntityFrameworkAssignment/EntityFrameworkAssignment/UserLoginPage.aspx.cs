using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameworkAssignment
{
    public partial class UserLoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            if (dropdownUserType.SelectedValue == "Null")
            {
                lblMessage.Text = "User Type not selected";
            }
            else
            {
                Session["UserName"] = txtName.Text;
                if (dropdownUserType.SelectedItem.Value == "Normal")
                {
                    AuthenticateUser newUser = new AuthenticateUser();
                    if (newUser.UserAuthentication(txtName.Text, dropdownUserType.SelectedItem.Value))
                        Response.Redirect("~/UploadFilePage.aspx");
                    else
                        lblMessage.Text = "Invalid User Contact the admin to add you as a user";
                }
                else
                {
                    AuthenticateUser newUser = new AuthenticateUser();
                    if (newUser.UserAuthentication(txtName.Text, dropdownUserType.SelectedItem.Value))
                        Response.Redirect("~/AdminPage.aspx");
                    else
                        lblMessage.Text = "Invalid User Contact the admin to add you as a user";

                }
            }
        }
    }
}