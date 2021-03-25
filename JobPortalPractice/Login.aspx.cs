using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string username = UserNameTextBox.Text;
            string password = PasswordTextBox.Text;
            string foundUsername = "";
            string foundAccType = "";
            Session["username"] = username;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM usersTbl WHERE username='" + username + "' AND password='" + password + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    //fetching the username from the usrTable
                    foundUsername = rdr["username"].ToString(); //The 0 stands for "the 0'th column", so the first column of the result.
                    foundAccType = rdr["accountType"].ToString();
                }
                if (foundAccType == "Job Seeker")
                {
                    Response.Redirect("jobSeekerHomePg.aspx");
                }
                else if(foundAccType == "Company")
                {
                    Response.Redirect("CompanyHomePg.aspx");
                }
                else
                {
                    Response.Write("Sorry not account found for this username and password");
                }
            }
        }
    }
}