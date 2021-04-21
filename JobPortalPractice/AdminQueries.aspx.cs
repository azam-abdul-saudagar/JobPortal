using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class AdminQueries : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string username = Session["username"].ToString();
            AdminName.Text = "Admin";



            string id, jobSeekerUserName, jobSeekerName, contactNo, email, message = "";
            string jobHtml = "";

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM tblQueries;";
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
                    contactNo = rdr["contactNo"].ToString();
                    email = rdr["email"].ToString();
                    message = rdr["Message"].ToString();

                    jobHtml += "<div class='job'>" +
            "<div class='row'>" +
            "<div class='col-lg-3'>" +
            "<div class='job__category-labels'>" +
              "<ul>" +
                "<li>Username :</li>" +
                "<li>Name :</li>" +
                "<li>Contact no :</li>" +
                "<li>Email :</li>" +
                "<li>Message :</li>" +
              "</ul>" +
            "</div>" +
          "</div>" +
            "<div class='col-lg-6'>" +
            "<div class='job__category-values'>" +
              "<ul>" +
                "<li>" + jobSeekerUserName + "</li>" +
                "<li>" + jobSeekerName + "</li>" +
                "<li>" + contactNo + "</li>" +
                "<li>" + email + "</li>" +
                "<li>" + message + "</li>" +
              "</ul>" +
            "</div>" +
          "</div>" +
          "<div class='col-lg-3'>" +
              "<form></form>" +
              "<form class='' action='AdminActions.aspx' method='post'>" +
                "<input type='hidden' name='ID' value='" + id + "' />" +
                "<button class='job-btn btn btn-success mb-4' type='submit' name='Action' value='RemoveQuery'>Remove Query</button>" +
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