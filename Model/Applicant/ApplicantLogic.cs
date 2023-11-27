using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;

namespace HrManagement.Model.Applicant
{
    public class ApplicantLogic
    {
        private string connstring = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        public string Insert(Applicants ap)
        {
            string msg = "-1";
            SqlConnection con = null;

            try
            {
                using (con = new SqlConnection(connstring))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_insertemployees", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@ap_name", SqlDbType.NVarChar, 100).Value = ap.ap_name;
                        cmd.Parameters.Add("@ap_pass", SqlDbType.NVarChar, 20).Value = ap.ap_pass;
                        cmd.Parameters.Add("@ap_cnic", SqlDbType.NVarChar, 30).Value = ap.ap_cnic;
                        cmd.Parameters.Add("@ap_phone", SqlDbType.NVarChar, 20).Value = ap.ap_phone;
                        cmd.Parameters.Add("@ap_email", SqlDbType.NVarChar, 20).Value = ap.ap_email;
                        cmd.Parameters.Add("@ap_image", SqlDbType.NVarChar).Value = ap.ap_image;
                        cmd.Parameters.Add("@ap_gender", SqlDbType.NVarChar, 20).Value = ap.ap_gender;
                        cmd.Parameters.Add("ap_DateOfBirth", SqlDbType.Date).Value = ap.ap_DateOfBirth;
                        cmd.ExecuteNonQuery();
                    }

                    msg = "1";
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                // Example: Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            return msg;
        }
    }

}