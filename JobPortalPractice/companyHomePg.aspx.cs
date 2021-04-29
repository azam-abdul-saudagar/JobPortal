using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class companyHomePg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string username = Session["username"].ToString();
            string companyName = "";

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM companyPersonalTbl WHERE username='" + username + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the name of the user from companyPersonalTbl to display on nameLabel
                while (rdr.Read())
                {
                    //fetching the username from the companyPersonalTbl
                    companyName = rdr["companyname"].ToString(); //The 0 stands for "the 0'th column", so the first column of the result.
                }
                if (companyName != "")
                {
                    CompanyName.Text = companyName;
                }
                else
                {
                    CompanyName.Text = "Name not provided";
                }
            }
            string fullName, jobTitle, experience, location, jobType, skills, email,offeredSalary, age, jobSeekerUserName = "";
            string jobHtml = "";

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM tblResume;";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the name of the user from jobSeekerPersonalTbl to display on nameLabel
                while (rdr.Read())
                {
                    //fetching the jobDetails from the addJobTbl
                    jobSeekerUserName = rdr["UserName"].ToString();
                    fullName = rdr["FullName"].ToString();
                    jobTitle = rdr["JobTitle"].ToString();
                    email = rdr["Email"].ToString();
                    age = rdr["Age"].ToString();
                    offeredSalary = rdr["OfferedSalary"].ToString();
                    skills = rdr["Skills"].ToString();
                    experience = rdr["Experience"].ToString();
                    location = rdr["City"].ToString() + " ," + rdr["State"].ToString() + " ," + rdr["Country"].ToString();

                    jobHtml += "<div class='job'>" +
             "<h2 class='full-name'>" + fullName + "</h2>" +
            "<h4>" + jobTitle + "</h4>" +
            "<hr/>" +
            "<div class='row'>" +
            "<div class='col-lg-3'>" +
            "<div class='job__category-labels'>" +
              "<ul>" +
                "<li>Age:</li>" +
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
                "<li>" + age + "</li>" +
                "<li>" + email + "</li>" +
                "<li>" + offeredSalary + "</li>" +
                "<li>" + skills + "</li>" +
                "<li>" + experience + "</li>" +
                "<li>" + location + "</li>" +
              "</ul>" +
            "</div>" +
          "</div>" +
          "<div class='col-lg-3'>" +
              "<form class='' action='ViewResume.aspx' method='post'>" +
                "<button class='job-btn btn btn-light mb-4' type='submit' name='jobSeekerUserName' value='" + jobSeekerUserName + "'>VIEW RESUME</button>" +
              "</form>" +             
            "</div>" +
          "</div>" +
        "</div>";
                }
                ContainerJob.InnerHtml = jobHtml;
            }
        }

        /*"<form class='' action='JobDetail.aspx' method='post'>" +
                "<input type='hidden' name='jobID' value='" + "jobId" + "' />" +
                "<button class='job-btn btn btn-success' type='submit'>CONTACT</button>" +
              "</form>" +*/

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string username = Session["username"].ToString();
            string companyName = "";
            string fullName, jobTitle, experience, location, jobType, skills, email, offeredSalary, age, jobSeekerUserName, country = "";
            string jobHtml = "";
            jobTitle = JobTitle.Text;
            country = Location.Text;

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                if (jobTitle != "" && country != "")
                {
                    cmd.CommandText = "SELECT * FROM tblResume WHERE JobTitle='" + jobTitle + "' AND Country='" + country + "';";
                }
                else if (jobTitle != "" && country == "")
                {
                    cmd.CommandText = "SELECT * FROM tblResume WHERE JobTitle='" + jobTitle + "';";
                }
                else if (jobTitle == "" && country != "")
                {
                    cmd.CommandText = "SELECT * FROM tblResume WHERE Country='" + country + "';";
                }
                else if (jobTitle == "" && country == "")
                {
                    cmd.CommandText = "SELECT * FROM tblResume;";
                }
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the name of the user from jobSeekerPersonalTbl to display on nameLabel
                while (rdr.Read())
                {
                    //fetching the jobDetails from the addJobTbl
                    jobSeekerUserName = rdr["UserName"].ToString();
                    fullName = rdr["FullName"].ToString();
                    jobTitle = rdr["JobTitle"].ToString();
                    email = rdr["Email"].ToString();
                    age = rdr["Age"].ToString();
                    offeredSalary = rdr["OfferedSalary"].ToString();
                    skills = rdr["Skills"].ToString();
                    experience = rdr["Experience"].ToString();
                    location = rdr["City"].ToString() + " ," + rdr["State"].ToString() + " ," + rdr["Country"].ToString();

                    jobHtml += "<div class='job'>" +
             "<h2 class='full-name'>" + fullName + "</h2>" +
            "<h4>" + jobTitle + "</h4>" +
            "<hr/>" +
            "<div class='row'>" +
            "<div class='col-lg-3'>" +
            "<div class='job__category-labels'>" +
              "<ul>" +
                 "<li>Age:</li>" +
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
                "<li>" + age + "</li>" +
                "<li>" + email + "</li>" +
                "<li>" + offeredSalary + "</li>" +
                "<li>" + skills + "</li>" +
                "<li>" + experience + "</li>" +
                "<li>" + location + "</li>" +
              "</ul>" +
            "</div>" +
          "</div>" +
          "<div class='col-lg-3'>" +
              "<form class='' action='ViewResume.aspx' method='post'>" +
                "<input type='hidden' name='ID' value='" + "" + "' />" +
                "<button class='job-btn btn btn-light mb-4' type='submit' name='jobSeekerUserName' value='" + jobSeekerUserName + "'>VIEW RESUME</button>" +
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