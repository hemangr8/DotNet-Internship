using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userName"] != null)
            {
                name.Text = (Session["userName"].ToString());
            }
            else
                name.Text = "";
            if (Session["userName"] == null)
                logoutButton.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Home.aspx");
        }

        protected void SiteMapPath1_ItemCreated(object sender, SiteMapNodeItemEventArgs e)
        {
            if ((e.Item.ItemType == SiteMapNodeItemType.Root) || ((e.Item.ItemType == SiteMapNodeItemType.PathSeparator) && (e.Item.ItemIndex == 1)))
            { e.Item.Visible = false; }
        }
    }
}