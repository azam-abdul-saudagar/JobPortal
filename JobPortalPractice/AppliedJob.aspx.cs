using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class AppliedJob : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string jobSeekerName = Session["username"].ToString();
            string id, jobTitle, status,companyName, email, appliedDate, jobHtml = "";

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM tblJobTrack WHERE JobSeekerUserName='" + jobSeekerName + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the data of applied from tblTrackJob
                while (rdr.Read())
                {
                    //fetching the applications data from tblJobTrack
                    id = rdr["JobId"].ToString();
                    jobTitle = rdr["JobTitle"].ToString();
                    companyName = rdr["CompanyName"].ToString();
                    email = rdr["CompanyEmail"].ToString();
                    appliedDate = rdr["AppliedDate"].ToString();
                    status = rdr["Status"].ToString();

                    jobHtml += "<tr>" +
                        "<td>" + id + "</td>" +
                        "<td>" + jobTitle + "</td>" +
                        "<td>" + companyName + "</td>" +
                        "<td>" + email + "</td>" +
                        "<td>" + appliedDate + "</td>" +
                        "<td>" + status + "</td>" +
                        "<td>" +
                        "<form></form>" +
                        "<form action ='RemoveAppliedJob.aspx' method='post'>" +

                            "<input type='hidden' name = 'jobId' value = '" + id + "'>" +

                            "<button type = 'submit' name='jobSeekerUserName' value='" + jobSeekerName + "'> X </button>" +

                         "</form>" +

                         "</td>" +

                        "</tr>";
                }

                AppliedJobs.InnerHtml = jobHtml;
            }
        }
    }
}