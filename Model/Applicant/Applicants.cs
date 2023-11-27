using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HrManagement.Model.Applicant
{
    public class Applicants
    {

        public int ap_id { get; set; }
        public string ap_name { get; set; }
        public string ap_pass { get; set; }
        public string ap_cnic { get; set; }
        public string ap_phone { get; set; }
        public string ap_email { get; set; }
        public string ap_image { get; set; }
        public string ap_gender { get; set; }
        public DateTime ap_DateOfBirth { get; set; }
       


    }
}