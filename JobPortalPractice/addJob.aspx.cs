using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class addJob : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string username = Session["username"].ToString();
            string companyName = CompanyNameTextBox.Value;
            string jobTitle = JobTitleTextBox.Value;
            string category = CategoryTextBox.Value;
            string description = DescriptionTextBox.Value;
            string salary = SalaryRangeTextBox.Value;
            string experience = ExperienceTextBox.Value;
            string jobType = JobTypeDropDownList.Value;
            int vacancy = int.Parse(NoVacancyTextBox.Value);
            string qualificationRequired = QualificationTextBox.Value;
            string skills = SkillsTextBox.Value;
            string email = EmailTextBox.Value;
            string contact = ContactTextBox.Value;
            string address = AddressTextBox.Value;
            string city = CityTextBox.Value;
            string state = StateTextBox.Value;
            string country = CountryTextBox.Value;

            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "Insert into tblAddJob (CompanyUsername,CompanyName,JobTitle,Category,Description,Salary,Experience," +
                    "JobType,Vacancy,QualificationRequired,Skills,Email,ContactNo,Address,City,State,Country) values (" + "'" + username + "'," +
                   "'" + companyName + "'," +
                   "'" + jobTitle + "'," +
                   "'" + category + "'," +
                   "'" + description + "'," +
                   "'" + salary + "'," +
                   "'" + experience + "'," +
                   "'" + jobType + "'," +
                   "'" + vacancy + "'," +
                   "'" + qualificationRequired + "'," +
                   "'" + skills + "'," +
                   "'" + email + "'," +
                   "'" + contact + "'," +
                   "'" + address + "'," +
                   "'" + city + "'," +
                   "'" + state + "'," +
                   "'" + country + "'" + ")";
                Response.Write(cmd.CommandText);
                cmd.Connection = con;
                con.Open();
                int totalRowsEffected = cmd.ExecuteNonQuery();
                Response.Write("Total rows updated = " + totalRowsEffected);

            }

            
        }
    }
}