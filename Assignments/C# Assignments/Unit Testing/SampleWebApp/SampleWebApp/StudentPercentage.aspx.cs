using System;
using System.Collections.Generic;
using System.Linq;
using PercentageConditions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class StudentPercentage : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {

        }

        public void Button1_Click(object sender, EventArgs e)
        {
            ReturnConditions condition = new ReturnConditions();
            bool isException = condition.IsException(Percentage.Text);
            if (isException == false)
            {
                if (!condition.IslLegit(Percentage.Text))
                    lblMessage.Text = "Enter legitimate percentage";
                else
                {
                    if (condition.IsPassed(Percentage.Text))
                        lblMessage.Text = "Student Passed";
                    else
                        lblMessage.Text = "Student Failed";
                }
            }
            else
                lblMessage.Text = "Only integer values allowed";
        }
    }
}