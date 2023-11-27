using HrManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HrManagement.View.Applicant
{
    public partial class login : System.Web.UI.Page
    {
        helper hc = new helper();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string count = hc.scalerReturn("select count(ap_id) from table_applicant_Details where ap_cnic='" + TextBox1.Text+"'");
        
        if (count.Equals(0))
            {
                Console.WriteLine("Cnic is not correct");
            }
            else
            {
                string Pass = hc.scalerReturn("select ap_pass from table_applicant_Details where ap_cnic='" + TextBox2.Text + "'");
                if (Pass.Equals(0))
                {
                    Session["u_id"] = hc.scalerReturn("select ap_id from table_applicant_Details where ap_cnic='" + TextBox2.Text + "'");
                    Response.Redirect("~/View/Applicant/login.aspx");
                }
                else
                {
                    Console.WriteLine("Invalid pass");
                }

            }


        }
    }
}