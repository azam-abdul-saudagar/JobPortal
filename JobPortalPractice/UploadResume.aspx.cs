using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class UploadResumee1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string jobSeekerUserName = Request.Form.Get("jobSeekerUserName");

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                Response.Write(jobSeekerUserName);
                cmd.CommandText = "SELECT * FROM tblResume WHERE UserName='" + jobSeekerUserName + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the data of the user from tblResume
                while (rdr.Read())
                {
                    //fetching the data of the user from tblResume
                    FullName.Value = rdr["FullName"].ToString();
                    JobTitle.Value = rdr["JobTitle"].ToString();
                    Email.Value = rdr["Email"].ToString();
                    ContactNo.Value = rdr["ContactNo"].ToString();
                    OfferedSalary.Value = rdr["OfferedSalary"].ToString();
                    InputState.Value = rdr["InputState"].ToString();
                    Experience.Value = rdr["Experience"].ToString();
                    RecentQualification.Value = rdr["RecentQualification"].ToString();
                    AboutYou.Value = rdr["AboutYou"].ToString();
                    Education.Value = rdr["Education"].ToString();
                    WorkExperience.Value = rdr["WorkExperience"].ToString();
                    Skills.Value = rdr["Skills"].ToString();
                    Contact.Value = rdr["Contact"].ToString();
                    City.Value = rdr["City"].ToString();
                    State.Value = rdr["State"].ToString();
                    Country.Value = rdr["Country"].ToString();
                    FullAddress.Value = rdr["FullAddress"].ToString();
                }
            }
        }

        protected void UpdateResumeButton_Click(object sender, EventArgs e)
        {
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string jobSeekerUserName = Request.Form.Get("jobSeekerUserName");
            string fetchedUserName = "";

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                Response.Write(jobSeekerUserName);
                cmd.CommandText = "SELECT * FROM tblResume WHERE UserName='" + jobSeekerUserName + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the data of the user from tblResume
                while (rdr.Read())
                {
                    //fetching the username from tblResume
                    fetchedUserName = rdr["UserName"].ToString();
                }
            }

            string UserName = fetchedUserName;

            if (fetchedUserName == "")
            {
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand();
                    Response.Write(jobSeekerUserName);
                    cmd.CommandText = "INSERT INTO tblResume (UserName, FullName, JobTitle, Email, ContactNo, OfferedSalary, Age, InputState, Experience," +
                        " RecentQualification, AboutYou, Education, WorkExperience, Skills, Contact, City, State, Country, FullAddess) " +
                        "VALUES('" + UserName + "','" + FullName.Value + "','" +
                        JobTitle.Value + "','" + Email.Value + "','" +
                        ContactNo.Value + "','" + OfferedSalary.Value + "','" +
                        Age.Value + "','" + InputState.Value + "','" +
                        Experience.Value + "','" + RecentQualification.Value + "','" +
                        AboutYou.Value + "','" + Education.Value + "','" +
                        WorkExperience.Value + "','" + Skills.Value + "','" +
                        Contact.Value + "','" + City.Value + "','" +
                        State.Value + "','" + Country.Value + "','" +
                        FullAddress.Value + "');";
                    Response.Write(cmd.CommandText);
                    cmd.Connection = con;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    //Getting the data of the user from tblResume
                    while (rdr.Read())
                    {
                        //fetching the username from tblResume
                        
                        fetchedUserName = rdr["UserName"].ToString();
                    }
                }
            }
        }
    }
}