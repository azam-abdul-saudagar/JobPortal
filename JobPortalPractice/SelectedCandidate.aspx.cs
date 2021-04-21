using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class SelectCandidate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string companyUserName = Session["username"].ToString();
            string jobSeekerName, jobTitle, contactNo, email, offeredSalary, skills, experience, location = "";
            string jobHtml = "";

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM tblSelectedCandidates;";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the name of the user from jobSeekerPersonalTbl to display on nameLabel
                while (rdr.Read())
                {
                    //fetching the jobDetails from the addJobTbl
                    jobSeekerName = rdr["JobSeekerName"].ToString();
                    jobTitle = rdr["JobTitle"].ToString();
                    contactNo = rdr["ContactNo"].ToString();
                    email = rdr["Email"].ToString();
                    offeredSalary = rdr["OfferedSalary"].ToString();
                    skills = rdr["Skills"].ToString();
                    experience = rdr["Experience"].ToString();
                    location = rdr["Location"].ToString();

                    jobHtml += "<div class='job'>" +
             "<h2 class='full-name'>" + jobSeekerName + "</h2>" +
            "<h4>" + jobTitle + "</h4>" +
            "<hr/>" +
            "<div class='row'>" +
            "<div class='col-lg-3'>" +
            "<div class='job__category-labels'>" +
              "<ul>" +
                "<li>Contact No:</li>" +
                "<li>Email:</li>" +
                "<li>Offered Salary:</li>" +
                "<li>Skills:</li>" +
                "<li>Experience:</li>" +
                "<li>Location:</li>" +
              "</ul>" +
            "</div>" +
          "</div>" +
            "<div class='col-lg-6'>" +
            "<div class='job__category-values'>" +
              "<ul>" +
                "<li>" + contactNo + "</li>" +
                "<li>" + email + "</li>" +
                "<li>" + offeredSalary + "</li>" +
                "<li>" + skills + "</li>" +
                "<li>" + experience + "</li>" +
                "<li>" + location + "</li>" +
              "</ul>" +
            "</div>" +
          "</div>" +
          
          "</div>" +
        "</div>";
                }
                ContainerJob.InnerHtml = jobHtml;
            }
        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {

        }
    }
}