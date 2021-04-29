using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class JobSeekerFeedbackPg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SendButton_Click(object sender, EventArgs e)
        {
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string message = MessageTextBox.Value;
            string jobSeekerUserName = Session["username"].ToString();
            string jobSeekerName = "";
            string email = "";
            string contactNo = "";

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM tblResume WHERE UserName='" + jobSeekerUserName + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the data of the jobSeeker from tblResume
                while (rdr.Read())
                {
                    //fetching the data of job Seeker form tblResume
                    jobSeekerName = rdr["FullName"].ToString();
                    email = rdr["Email"].ToString();
                    contactNo = rdr["ContactNo"].ToString();
                }
            }

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "Insert into tblFeedback (JobSeekerUserName,JobSeekerName,ContactNo,Email,Message) values (" + "'" + jobSeekerUserName + "'," +
                   "'" + jobSeekerName + "'," +
                   "'" + contactNo + "'," +
                   "'" + email + "'," +
                   "'" + message + "'" + ")";
                cmd.Connection = con;
                con.Open();
                int totalRowsEffected = cmd.ExecuteNonQuery();
                ResultMessage.InnerHtml = "<div class='alert alert-success' role='alert'>" +
                                              "Message sent successfully!" +
                                        "</div>";
            }
        }
    }
}