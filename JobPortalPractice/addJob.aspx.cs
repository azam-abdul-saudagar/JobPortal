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
            string companyName = CompanyNameTextBox.Text;
            string jobTitle = JobTitleTextBox.Text;
            string category = CategoryTextBox.Text;
            string description = DescriptionTextBox.Text;
            string salary = SalaryRangeTextBox.Text;
            string experience = ExperienceTextBox.Text;
            string jobType = JobTypeDropDownList.Text;
            int vacancy = int.Parse(NoVacancyTextBox.Text);
            string qualificationRequired = QualificationTextBox.Text;
            string skills = SkillsTextBox.Text;
            string email = EmailTextBox.Text;
            string contact = ContactTextBox.Text;
            string address = AddressTextBox.Text;
            string city = CityTextBox.Text;
            string state = StateTextBox.Text;
            string country = CountryTextBox.Text;

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