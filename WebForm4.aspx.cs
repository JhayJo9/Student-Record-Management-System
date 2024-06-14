using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getdep();
            }
        }
        public void getdep()
        {
            DataTable deptTB = new DataTable();
            deptTB.Columns.Add("deptID", typeof(int));
            deptTB.Columns.Add("deptName");
            deptTB.Rows.Add(1, "Please Select Department");
            deptTB.Rows.Add(2, "School of Computer Studies");
            deptTB.Rows.Add(3, "School of Education");
            deptTB.Rows.Add(4, "School of Business Management");
            deptTB.Rows.Add(5, "School of Hospitality and Toursim Management");
            DeptCb.DataSource = deptTB;
            DeptCb.DataTextField = "DeptName";
            DeptCb.DataValueField = "deptID";
            DeptCb.DataBind();
        }
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DeptCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(DeptCb.SelectedValue) > 0)
            {
                DataTable courseTB = new DataTable();
                courseTB.Columns.Add("CourseID", typeof(int));
                courseTB.Columns.Add("DeptID", typeof(int));
                courseTB.Columns.Add("courseName");

                if (DeptCb.SelectedValue == "1")
                {
                    courseTB.Rows.Add(1, 1, "Please Select Course");
                }
                if (DeptCb.SelectedValue == "2")
                {
                    courseTB.Rows.Add(2, 2, "BS. Information Technology");
                    courseTB.Rows.Add(3, 2, "BS. Computer Science");
                }
                if (DeptCb.SelectedValue == "3")
                {
                    courseTB.Rows.Add(4, 3, "BSE. Major in Filipino");
                    courseTB.Rows.Add(5, 3, "BSE. Major in Social Studies");
                    courseTB.Rows.Add(6, 3, "BSE. Major in Mathemathics");
                    courseTB.Rows.Add(7, 3, "BSE. Major in English");
                }
                if (DeptCb.SelectedValue == "4")
                {
                    courseTB.Rows.Add(8, 4, "BS. Office Development");
                    courseTB.Rows.Add(9, 4, "BS. Marketing Management");
                    courseTB.Rows.Add(10, 4, "BS. Human Resource");
                }
                if (DeptCb.SelectedValue == "5")
                {
                    courseTB.Rows.Add(11, 5, "BS. Hotel Management");
                    courseTB.Rows.Add(12, 5, "BS. Toursim Management");
                }
                courseCb.DataSource = courseTB;
                courseCb.DataTextField = "courseName";
                courseCb.DataValueField = "courseID";
                courseCb.DataBind();
            }
        }
    }
}