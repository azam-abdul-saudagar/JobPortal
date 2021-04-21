using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class SearchJobDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string jobId = Request.Form.Get("jobId");

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM tblAddJob WHERE ID='" + jobId + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    //fetching the jobData from the tblAddJob
                    JobId.InnerHtml = jobId;
                    JobTitle.InnerHtml = rdr["JobTitle"].ToString();
                    CompanyName.InnerHtml = rdr["CompanyName"].ToString();
                    Country.InnerHtml = rdr["Country"].ToString();
                    SalaryRange.InnerHtml = rdr["Salary"].ToString();
                    ContactNo.InnerHtml = rdr["ContactNo"].ToString();
                    Email.InnerHtml = rdr["Email"].ToString();
                    JobCategory.InnerHtml = rdr["Category"].ToString();
                    Vacancy.InnerHtml = rdr["Vacancy"].ToString() + " vacany";
                    Experience.InnerHtml = rdr["Experience"].ToString();
                    JobDescription.InnerHtml = rdr["Description"].ToString();
                    string skills = rdr["Skills"].ToString();
                    string[] skillsList = skills.Split(',');
                    string skillsContainer = "";
                    foreach (string skill in skillsList)
                    {
                        skillsContainer += "<li>" + skill + "</li>";
                    }
                    SkillsContainer.InnerHtml += skillsContainer;
                    Location.InnerHtml = rdr["Address"].ToString() + ", " + rdr["City"].ToString() + ", " + rdr["State"].ToString() + ", " + rdr["Country"].ToString() + ", " + rdr["ZipCode"].ToString();

                    string requiements = rdr["QualificationRequired"].ToString();
                    string[] requirementsList = skills.Split(',');
                    string requirementsContainer = "";
                    foreach (string requirement in requirementsList)
                    {
                        requirementsContainer += "<li>" + requirement + "</li>";
                    }
                    RequirementsContainer.InnerHtml = requirementsContainer;
                }
            }

        }

        protected void ViewCompanyProfileButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewCompanyProfile.aspx");
        }

    }
}