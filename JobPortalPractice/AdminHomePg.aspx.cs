using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class AdminHomePg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string username = Session["username"].ToString();
            AdminName.Text = "Admin";

            

            string id, jobSeekerUserName, jobSeekerName, companyUserName, companyName, message = "";
            string jobHtml = "";

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM tblSpam;";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the name of the user from jobSeekerPersonalTbl to display on nameLabel
                while (rdr.Read())
                {
                    //fetching the jobDetails from the addJobTbl
                    id = rdr["ID"].ToString();
                    jobSeekerUserName = rdr["jobSeekerUserName"].ToString();
                    jobSeekerName = rdr["jobSeekerName"].ToString();
                    companyUserName = rdr["CompanyUserName"].ToString();
                    companyName = rdr["CompanyName"].ToString();
                    message = rdr["Message"].ToString();

                    jobHtml += "<div class='job'>" +
            "<div class='row'>" +
            "<div class='col-lg-3'>" +
            "<div class='job__category-labels'>" +
              "<ul>" +
                "<li>Job seeker username :</li>" +
                "<li>Job seeker name :</li>" +
                "<li>Company username :</li>" +
                "<li>Company name :</li>" +
                "<li>Message :</li>" +
              "</ul>" +
            "</div>" +
          "</div>" +
            "<div class='col-lg-6'>" +
            "<div class='job__category-values'>" +
              "<ul>" +
                "<li>" + jobSeekerUserName + "</li>" +
                "<li>" + jobSeekerName + "</li>" +
                "<li>" + companyUserName + "</li>" +
                "<li>" + companyName + "</li>" +
                "<li>" + message + "</li>" +
              "</ul>" +
            "</div>" +
          "</div>" +
          "<div class='col-lg-3'>" +
              "<form></form>" +
              "<form class='' action='AdminActions.aspx' method='post'>" +
                "<input type='hidden' name='ID' value='" + id + "' />" +
                "<button class='job-btn btn btn-success mb-4' type='submit' name='Action' value='RemoveComplaint'>Remove Complaint</button>" +
              "</form>" +
              "<form class='' action='AdminActions.aspx' method='post'>" +
                "<input type='hidden' name='companyName' value='" + companyName + "' />" +
                "<button class='job-btn btn btn-danger' type='submit' name='Action' value='RemoveCompany'>Remove Company</button>" +
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
            Response.Redirect("Login.aspx");
        }

    }
}