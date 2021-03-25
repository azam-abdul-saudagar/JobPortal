using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class UploadResume : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
           string userName = Session["username"].ToString();
           string fullName, jobTitle, email, contactNo, offeredSalary, age, inputState, experience, recentQualification, aboutYou, education, workExperience, skills, contact, city, state, country, fullAddress;
            FullName.Value = "Caroll";

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM tblResume WHERE UserName='" + userName + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the data of the resume from tblResume to display on input boxes
                while (rdr.Read())
                {
                    //fetching the username from the jobSeekerPersonalTbl
                    FullName.Value = rdr["FullName"].ToString();
                    JobTitle.Value = rdr["JobTitle"].ToString();
                    Email.Value = rdr["Email"].ToString();
                    ContactNo.Value = rdr["ContactNo"].ToString();
                    OfferedSalary.Value = rdr["OfferedSalary"].ToString();
                    Age.Value = rdr["Age"].ToString();
                    InputState.Value = rdr["inputState"].ToString();
                    Experience.Value = rdr["Experience"].ToString();
                    RecentQualification.Value = rdr["RecentQualification"].ToString();
                    AboutYou.Value = rdr["AboutYou"].ToString();
                    Education.Value = rdr["Education"].ToString();
                    WorkExperience.Value = rdr["workExperience"].ToString();
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
            string userName = Session["username"].ToString();
            string fullName = Request.Form.Get("FullName");
            string jobTitle = Request.Form.Get("JobTitle"); 
            string email = Request.Form.Get("Email"); 
            string contactNo = Request.Form.Get("ContactNo"); 
            string offeredSalary = Request.Form.Get("OfferedSalary"); 
            string age = Request.Form.Get("Age"); 
            string inputState = Request.Form.Get("InputState"); 
            string experience = Request.Form.Get("Experience"); 
            string recentQualification = Request.Form.Get("RecentQualification"); 
            string aboutYou = Request.Form.Get("AboutYou"); 
            string education = Request.Form.Get("Education"); 
            string workExperience = Request.Form.Get("WorkExperience"); 
            string skills = Request.Form.Get("Skills"); 
            string contact = Request.Form.Get("Contact"); 
            string city = Request.Form.Get("City"); 
            string state = Request.Form.Get("State"); 
            string country = Request.Form.Get("Country"); 
            string fullAddress = Request.Form.Get("FullAddress"); 
            Response.Write(fullName);

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert into tblResume values (" + "'" + userName + "'" + "," + 
                    "'" + fullName + "'" + "," + 
                    "'" + jobTitle + "'" + "," +
                    "'" + email + "'" + "," +
                    "'" + contactNo + "'" + "," +
                    "'" + offeredSalary + "'" + "," +
                    "'" + age + "'" + "," +
                    "'" + inputState + "'" + "," +
                    "'" + experience + "'" + "," +
                    "'" + recentQualification + "'" + "," +
                    "'" + aboutYou + "'" + "," +
                    "'" + education + "'" + "," +
                    "'" + workExperience + "'" + "," +
                    "'" + skills + "'" + "," +
                    "'" + contact + "'" + "," +
                    "'" + city + "'" + "," +
                    "'" + state + "'" + "," +
                    "'" + country + "'" + "," +
                    "'" + fullAddress + "')";
                Response.Write(cmd.CommandText);
                cmd.Connection = con;
                con.Open();
                int totalRowsEffected = cmd.ExecuteNonQuery();
            }

        }
    }
}