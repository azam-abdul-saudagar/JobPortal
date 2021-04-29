using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class SuccessfullyAppliedForJob : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string jobId = Request.Form.Get("jobId");
            string jobSeekerUserName = Request.Form.Get("jobSeekerUserName");
            string companyUsername = "";
            string jobTitle = "";
            string companyName = "";
            string companyEmail = "";
            string status = "Not Accepted";
            string appliedDate = DateTime.Now.ToString("dd/MM/yyyy");
            string jobSeekerName = "";
            string jobSeekerExperience = "";
            string location = "";
            string skills = "";

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM tblJobTrack WHERE JobId='" + jobId + "' AND JobSeekerUserName='" + jobSeekerUserName + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the data of job from tblAddJob to display on nameLabel
                while (rdr.Read())
                {
                    //fetching the username from the jobSeekerPersonalTbl
                    companyUsername = rdr["CompanyUsername"].ToString(); //The 0 stands for "the 0'th column", so the first column of the result.
                    jobTitle = rdr["JobTitle"].ToString();
                }
            }

            if (jobTitle == "")
            {
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM tblAddJob WHERE ID='" + jobId + "';";
                    cmd.Connection = con;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    //Getting the data of job from tblAddJob to display on nameLabel
                    while (rdr.Read())
                    {
                        //fetching the username from the jobSeekerPersonalTbl
                        companyUsername = rdr["CompanyUsername"].ToString(); //The 0 stands for "the 0'th column", so the first column of the result.
                        jobTitle = rdr["JobTitle"].ToString();
                        companyName = rdr["CompanyName"].ToString();
                        companyEmail = rdr["Email"].ToString();
                    }
                }

                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM tblResume WHERE UserName='" + jobSeekerUserName + "';";
                    cmd.Connection = con;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    //Getting the data of jobSeeker from tblResume
                    while (rdr.Read())
                    {
                        //fetching the data from tblResume
                        jobSeekerName = rdr["FullName"].ToString(); //The 0 stands for "the 0'th column", so the first column of the result.
                        jobSeekerExperience = rdr["Experience"].ToString();
                        location = rdr["Country"].ToString();
                        skills = rdr["Skills"].ToString();
                    }
                }

                using (SqlConnection con = new SqlConnection(CS))
                {
                    int Id = Int32.Parse(jobId);
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "Insert into tblJobTrack values (" + "'" + Id + "'" + "," +
                        "'" + companyUsername + "'" + "," +
                        "'" + jobSeekerUserName + "'" + "," +
                        "'" + jobTitle + "'" + "," +
                        "'" + companyName + "'" + "," +
                        "'" + companyEmail + "'" + "," +
                        "'" + status + "'" + "," +
                        "'" + appliedDate + "'" + "," +
                        "'" + jobSeekerName + "'" + "," +
                        "'" + jobSeekerExperience + "'" + "," +
                        "'" + location + "'" + "," +
                        "'" + skills + "')";
                    cmd.Connection = con;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                }
                MessageHeading.InnerText = "Successfully applied for the job";
                MessageBody.InnerText = "You have successfull applied for the job whose id is " + jobId;
            }
            else
            {
                MessageHeading.InnerText = "Already applied for the job";
                MessageBody.InnerText = "You have already applied for the job whose id is " + jobId;
            }
        }
    }
}