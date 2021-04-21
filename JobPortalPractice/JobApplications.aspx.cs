using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class JobApplications : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string companyUsername = Session["username"].ToString();
            string id,jobTitle,status,jobSeekerName,jobSeekerExperience,location,skills,jobSeekerUserName,jobHtml = "";

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM tblJobTrack WHERE CompanyUserName='" + companyUsername + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the id of the job from tblTrackJob
                while (rdr.Read())
                {
                    //fetching the applications data from tblJobTrack
                    id = rdr["JobId"].ToString();
                    jobTitle = rdr["JobTitle"].ToString();
                    jobSeekerUserName = rdr["JobSeekerUserName"].ToString();
                    jobSeekerName = rdr["JobSeekerName"].ToString();
                    jobSeekerExperience = rdr["JobSeekerExperience"].ToString();
                    location = rdr["Location"].ToString();
                    skills = rdr["Skills"].ToString();
                    status = rdr["Status"].ToString();

                    jobHtml += "<div class='job'>" +
             "<h2 class='full-name'>" + jobSeekerName + "</h2>" +
            "<hr/>" +
            "<div class='row'>" +
            "<div class='col-lg-3'>" +
            "<div class='job__category-labels'>" +
              "<ul>" +
                "<li>Job Id:</li>" +
                "<li>Job Title:</li>" +
                   "<li>Skills:</li>" +
                "<li>Experience:</li>" +
                "<li>Location:</li>" +
                "<li>Action Taken:</li>" +
              "</ul>" +
            "</div>" +
          "</div>" +
            "<div class='col-lg-6'>" +
            "<div class='job__category-values'>" +
              "<ul>" +
                "<li>" + id + "</li>" +
                "<li>" + jobTitle + "</li>" +
                   "<li>" + skills + "</li>" +
                "<li>" + jobSeekerExperience + "</li>" +
                "<li>" + location + "</li>" +
                "<li>" + status + "</li>" +
              "</ul>" +
            "</div>" +
          "</div>" +
          "<div class='col-lg-3'>" +
              "<form></form>" +
              "<form class='' action='ViewResume.aspx' method='post'>" +
                "<input type='hidden' name='jobSeekerUserName' value='" + jobSeekerUserName + "'/>" +
                "<button class='job-btn btn btn-outline-success mb-4' type='submit'>VIEW RESUME</button>" +
              "</form>" +
              "<form class='' action='Actions.aspx' method='post'>" +
                "<input type='hidden' name='jobID' value='" + id + "' />" +
                "<button class='job-btn btn btn-success' type='submit' name='status' value='Selected'>SELECT</button>" +
              "</form>" +
              "<form class='' action='Actions.aspx' method='post'>" +
                "<input type='hidden' name='jobID' value='" + id + "' />" +
                "<button class='job-btn btn btn-light' type='submit' name='status' value='Rejected'>REJECT</button>" +
              "</form>" +
            "</div>" +
          "</div>" +
        "</div>";
                }
                ContainerJob.InnerHtml = jobHtml;
            }
        }
    }
}