using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class SearchPg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string jobTitle , location = "";
            jobTitle = Request.Form.Get("JobTitle");
            location = Request.Form.Get("Location");
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string jobId, companyName, companyCategory, jobType, skills,companyUserName = "";
            string experience = "";
            string jobHtml = "";

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                if (jobTitle != "" && location != "")
                {
                    cmd.CommandText = "SELECT * FROM tblAddJob WHERE JobTitle='" + jobTitle + "' AND Country='" + location + "';";
                }
                else if (jobTitle != "" && location == "")
                {
                    cmd.CommandText = "SELECT * FROM tblAddJob WHERE JobTitle='" + jobTitle + "';";
                }
                else if (jobTitle == "" && location != "")
                {
                    cmd.CommandText = "SELECT * FROM tblAddJob WHERE Country='" + location + "';";
                }
                else if (jobTitle == "" && location == "")
                {
                    cmd.CommandText = "SELECT * FROM tblAddJob;";
                }
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the name of the user from jobSeekerPersonalTbl to display on nameLabel
                while (rdr.Read())
                {
                    //fetching the jobDetails from the addJobTbl
                    jobId = rdr["ID"].ToString();
                    companyUserName = rdr["CompanyUsername"].ToString();
                    companyName = rdr["CompanyName"].ToString();
                    companyCategory = rdr["Category"].ToString();
                    jobTitle = rdr["JobTitle"].ToString();
                    jobType = rdr["JobType"].ToString();
                    skills = rdr["Skills"].ToString();
                    experience = rdr["Experience"].ToString();
                    location = rdr["City"].ToString() + " ," + rdr["State"].ToString() + " ," + rdr["Country"].ToString();

                    jobHtml += "<div class='job'>" +
             "<h2 class='full-name'>" + companyName + "</h2>" +
            "<h4>" + companyCategory + "</h4>" +
            "<hr/>" +
            "<div class='row'>" +
            "<div class='col-lg-3'>" +
            "<div class='job__category-labels'>" +
              "<ul>" +
                "<li>Job Id:</li>" +
                "<li>Job Title</li>" +
                "<li>Job Type:</li>" +
                "<li>Skills:</li>" +
                "<li>Experience:</li>" +
                "<li>Location:</li>" +
              "</ul>" +
            "</div>" +
          "</div>" +
            "<div class='col-lg-6'>" +
            "<div class='job__category-values'>" +
              "<ul>" +
                "<li>" + jobId + "</li>" +
                "<li>" + jobTitle + "</li>" +
                "<li>" + jobType + "</li>" +
                "<li>" + skills + "</li>" +
                "<li>" + experience + "</li>" +
                "<li>" + location + "</li>" +
              "</ul>" +
            "</div>" +
          "</div>" +
          "<div class='col-lg-3'>" +
              "<form class='' action='SearchJobDetail.aspx' method='post'>" +
                "<input type='hidden' name='jobID' value='" + jobId + "' />" +
                "<button class='job-btn btn btn-light' type='submit' name='username' value='" + companyUserName + "'>VIEW JOB</button>" +
              "</form>" +
            "</div>" +
          "</div>" +
        "</div>";
                }
                ContainerJob.InnerHtml = jobHtml;
            }
        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePg.aspx");
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string jobId, companyName, companyCategory, jobTitle, jobType, skills, location, experience, companyUserName = "";
            string jobHtml = "";
            jobTitle = JobTitle.Text;
            location = Location.Text;

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                if (jobTitle != "" && location != "")
                {
                    cmd.CommandText = "SELECT * FROM tblAddJob WHERE JobTitle='" + jobTitle + "' AND Country='" + location + "';";
                }
                else if (jobTitle != "" && location == "")
                {
                    cmd.CommandText = "SELECT * FROM tblAddJob WHERE JobTitle='" + jobTitle + "';";
                }
                else if (jobTitle == "" && location != "")
                {
                    cmd.CommandText = "SELECT * FROM tblAddJob WHERE Country='" + location + "';";
                }
                else if (jobTitle == "" && location == "")
                {
                    cmd.CommandText = "SELECT * FROM tblAddJob;";
                }
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the name of the user from jobSeekerPersonalTbl to display on nameLabel
                while (rdr.Read())
                {
                    //fetching the jobDetails from the addJobTbl
                    jobId = rdr["ID"].ToString();
                    companyUserName = rdr["CompanyUsername"].ToString();
                    companyName = rdr["CompanyName"].ToString();
                    companyCategory = rdr["Category"].ToString();
                    jobTitle = rdr["JobTitle"].ToString();
                    jobType = rdr["JobType"].ToString();
                    skills = rdr["Skills"].ToString();
                    experience = rdr["Experience"].ToString();
                    location = rdr["City"].ToString() + " ," + rdr["State"].ToString() + " ," + rdr["Country"].ToString();

                    jobHtml += "<div class='job'>" +
             "<h2 class='full-name'>" + companyName + "</h2>" +
            "<h4>" + companyCategory + "</h4>" +
            "<hr/>" +
            "<div class='row'>" +
            "<div class='col-lg-3'>" +
            "<div class='job__category-labels'>" +
              "<ul>" +
                "<li>Job Id:</li>" +
                "<li>Job Title</li>" +
                "<li>Job Type:</li>" +
                "<li>Skills:</li>" +
                "<li>Experience:</li>" +
                "<li>Location:</li>" +
              "</ul>" +
            "</div>" +
          "</div>" +
            "<div class='col-lg-6'>" +
            "<div class='job__category-values'>" +
              "<ul>" +
                "<li>" + jobId + "</li>" +
                "<li>" + jobTitle + "</li>" +
                "<li>" + jobType + "</li>" +
                "<li>" + skills + "</li>" +
                "<li>" + experience + "</li>" +
                "<li>" + location + "</li>" +
              "</ul>" +
            "</div>" +
          "</div>" +
          "<div class='col-lg-3'>" +
          "<form></form>" +
              "<form class='' action='JobDetail.aspx' method='post'>" +
                "<input type='hidden' name='jobID' value='" + jobId + "'  />" +
                "<button class='job-btn btn btn-light' type='submit' name='username' value='" + companyUserName + "'>VIEW JOB</button>" +
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