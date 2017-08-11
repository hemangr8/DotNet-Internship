using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentWebApplication
{
    public partial class DefaulPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDetails_Click(object sender, EventArgs e)
        {
            lblHeading.Text = "The Submitted Details are:";

            StudentClass newStudent = new StudentClass();
            newStudent.RollNo = int.Parse(txtRollNo.Text);
            newStudent.Name = txtName.Text;
            newStudent.Grade = txtGrade.Text;

            StudentWebApplication.GetStudentDetail client = new StudentWebApplication.GetStudentDetail();
            lblRollNo.Text = client.ShowRollNo(newStudent);
            lblName.Text = client.ShowName(newStudent);
            lblGrade.Text = client.ShowGrade(newStudent);

        }
    }
}