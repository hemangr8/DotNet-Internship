using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MVPAssignment
{
    public partial class Defauilt : System.Web.UI.Page, IView
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string Label
        {
            get
            {
                return lblMessage.Text;
            }
            set
            {
                lblMessage.Text = value;
            }
        }
        public string TextBox
        {
            get
            {
                return txtMessage.Text;
            }
            set
            {
                txtMessage.Text = value;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Presenter p = new Presenter(this, new MVPAssignment.Model());
            p.BindModalView();
        }
    }
}