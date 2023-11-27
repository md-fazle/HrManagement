using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HrManagement.Model
{
    public class helper
    {
        private string connstring = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public string scalerReturn(string r) {
            String s;
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(r, conn);
                 s = cmd.ExecuteScalar().ToString();
            }
            catch(Exception)
            {
                s = "-1";
            }
            return s;
        }    
    }
}