using HrManagement.Model.Applicant;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HrManagement.View.Applicant
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string msg = file_upload(FileUpload1);
            if (msg.Equals("-1")){

                Response.Write("<script>alert('Only images are allowed to upload that are size of less than 2 MB only jpg and png  '); </script> ");

            }
            else {
                Applicants ap = new Applicants();
                ap.ap_cnic = txtcnic.Text;
                ap.ap_pass = txtcpassword.Text;
                ap.ap_name = txtusername.Text;
                ap.ap_phone = txtcontact.Text;
                ap.ap_image = msg;
                ap.ap_DateOfBirth = Convert.ToDateTime(Calendar2.SelectedDate.ToShortDateString());
                ap.ap_email = txtemailid.Text;
                if (txtMale.Checked) {

                    ap.ap_gender = txtMale.Text;

                }
                else
                {
                    ap.ap_gender = txtFemale.Text;
                }


                ApplicantLogic obj = new ApplicantLogic();
               String msg2= obj.Insert(ap);
                if (msg2.Equals("1"))
                {
                    Response.Write("<script>alert('data successfully uploaded.. '); </script> ");
                }
            }
        }
        //btn end 
        public string file_upload(FileUpload fileupload)
        {
            string msg = "-1";

            if (fileupload.HasFile)
            {

                string fileextenion = Path.GetExtension(fileupload.FileName);

                if (fileextenion.ToLower() != ".png" && fileextenion.ToLower() != ".jpg")
                {
                    Response.Write("<script>alert('Only images are allowed to upload , please select jpg or png image.... '); </script> ");
                }
                else
                {
                    int filesize = fileupload.PostedFile.ContentLength;

                    if (filesize > 2097152) //cannot upload > 2 mb image......
                    {
                        Response.Write("<script>alert('Only images are allowed to upload that are size of less than 2 MB  '); </script> ");
                    }
                    else
                    {
                        Random r = new Random();
                        int r1 = r.Next();
                        int r2 = r.Next();
                        msg = "~/Contants/uploads/" + r1 + r2 + fileupload.FileName;
                        fileupload.SaveAs(Server.MapPath(msg));
                    }



                }




            }
            else
            {
                Response.Write("<script>alert('please select a file '); </script> ");

            }

            return msg;


        }//method end......





    }
}