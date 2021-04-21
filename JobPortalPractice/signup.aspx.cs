using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignUpButton_Click(object sender, EventArgs e)
        {
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string accountType = AccountType.Value;
            string username = UserNameTextBox.Value;
            string email = EmailTextBox.Value;
            string password = PasswordTextBox.Value;
            string confirmPassword = ConfirmPasswordTextBox.Value;
            string fetchedUsername = "";

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM usersTbl WHERE username='" + username + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                

                //Getting the name of the company from companyPersonalTbl to display on nameLabel
                while (rdr.Read())
                {
                    //fetching the name from the companyPersonalTbl
                    fetchedUsername = rdr["username"].ToString(); //The 0 stands for "the 0'th column", so the first column of the result.   
                }
                Response.Write(fetchedUsername);
            }

            if (fetchedUsername == "")
            {
                if (password == confirmPassword)
                {
                    message.InnerHtml = "<div class='alert alert-success' role='alert'>" +
                                        "Account made successfully!" +
                                        "</div>";
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "Insert into usersTbl values (" + "'" + username + "'" + "," + "'" + email + "'" + "," + "'" + password + "'" + "," + "'" + accountType + "'" + ")";
                        cmd.Connection = con;
                        con.Open();
                        int totalRowsEffected = cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    message.InnerHtml = "<div class='alert alert-danger' role='alert'>" +
                                        "Sorry password field didn't matched please try again!" +
                                        "</div>";
                }
            }
            else
            {
                message.InnerHtml = "<div class='alert alert-danger' role='alert'>" +
                                        "Account with this username already exist!" +
                                        "</div>";
            }
        }
    }
}