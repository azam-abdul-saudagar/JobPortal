using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class ViewResume : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string jobSeekerUserName = Request.Form.Get("jobSeekerUserName");

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                Response.Write(jobSeekerUserName);
                cmd.CommandText = "SELECT * FROM tblResume WHERE username='" + jobSeekerUserName + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the data of the user from tblResume
                while (rdr.Read())
                {
                    //fetching the data of the user from tblResume
                    JobSeekerUserName.InnerText = jobSeekerUserName;
                    FullName.InnerText = rdr["FullName"].ToString();
                    JobTitle.InnerText = rdr["JobTitle"].ToString();
                    Email.InnerText = rdr["Email"].ToString();
                    ContactNo.InnerText = rdr["ContactNo"].ToString();
                    OfferedSalary.InnerText = rdr["OfferedSalary"].ToString();
                    InputState.InnerText = rdr["InputState"].ToString();
                    Experience.InnerText = rdr["Experience"].ToString();
                    RecentQualification.InnerText = rdr["RecentQualification"].ToString();
                    AboutYou.InnerText = rdr["AboutYou"].ToString();
                    Education.InnerText = rdr["Education"].ToString();
                    WorkExperience.InnerText = rdr["WorkExperience"].ToString();
                    Skills.InnerText = rdr["Skills"].ToString();
                    ContactContactNo.InnerText = rdr["Contact"].ToString();
                    City.InnerText = rdr["City"].ToString();
                    State.InnerText = rdr["State"].ToString();
                    Country.InnerText = rdr["Country"].ToString();
                    FullAddress.InnerText = rdr["FullAddress"].ToString();
                }
            }
        }

        protected void SelectCandidateButton_Click(object sender, EventArgs e)
        {            
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string jobSeekerUserName = JobSeekerUserName.InnerText;
            string companyUserName = Session["username"].ToString();
            string fullName = "";
            string jobTitle = "";
            string email = "";
            string contactNo = "";
            string offeredSalary = "";
            string experience = "";
            string skills = "";
            string country = "";

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                Response.Write(jobSeekerUserName);
                cmd.CommandText = "SELECT * FROM tblResume WHERE username='" + jobSeekerUserName + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the data of the user from tblResume
                while (rdr.Read())
                {
                    //fetching the data of the user from tblResume
                    fullName = rdr["FullName"].ToString();
                    jobTitle = rdr["JobTitle"].ToString();
                    email = rdr["Email"].ToString();
                    contactNo = rdr["ContactNo"].ToString();
                    offeredSalary = rdr["OfferedSalary"].ToString();
                    experience = rdr["Experience"].ToString();
                    skills = rdr["Skills"].ToString();
                    country = rdr["Country"].ToString();

                }
            }

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert into tblSelectedCandidates (CompanyUsername, JobSeekerUserName, JobSeekerName, JobTitle, ContactNo, Email," +
                    "OfferedSalary, Skills, Experience, Location) VALUES ('" + companyUserName + "'," +
                    "'" + jobSeekerUserName + "'," +
                    "'" + fullName + "'," +
                    "'" + jobTitle + "'," +
                    "'" + contactNo + "'," +
                    "'" + email + "'," +
                    "'" + offeredSalary + "'," +
                    "'" + skills + "'," +
                    "'" + experience + "'," +
                    "'" + country + "');";
                Response.Write(cmd.CommandText);
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
            }
        }
    }
}