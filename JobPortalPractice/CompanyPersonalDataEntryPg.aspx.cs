using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class CompanyPersonalDataEntryPg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            string personalTblUsername = "";
            string username = Session["username"].ToString();
            string companyName = CompanyNameTextBox.Text;
            string companyTagline = CompanyTaglineTextBox.Text;
            string ownerName = NameTextBox.Text;
            string email = EmailTextBox.Text;
            string contactNo = ContactTextBox.Text;
            string password = PasswordTextBox.Text;
            string companyCategory = CompanyCategoryTextBox.Text;
            string workingTime = WorkingTimeTextBox.Text;
            string facebook = FacebookTextBox.Text;
            string twitter = TwitterTextBox.Text;
            string linkedIn = LinkedInTextBox.Text;
            string instagram = InstagramTextBox.Text;
            string address = AddressTextBox.Text;
            string state = StateTextBox.Text;
            string country = CountryTextBox.Text;
            
            
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM companyPersonalTbl WHERE username='" + username + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the name of the company from companyPersonalTbl to display on nameLabel
                while (rdr.Read())
                {
                    //fetching the name from the companyPersonalTbl
                    personalTblUsername = rdr["companyname"].ToString(); //The 0 stands for "the 0'th column", so the first column of the result.
                }
            }
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                if (personalTblUsername != "")
                {
                    cmd.CommandText = "UPDATE companyPersonalTbl SET companyname = '" + companyName + "'," +
                        " tagline = '" + companyTagline + "'," +
                        " category = '" + companyCategory + "'," +
                        " ownername = '" + ownerName + "'," +
                        " contactno = '" + contactNo + "'," +
                        " password = '" + password + "'," +
                        " address = '" + address + "'," +
                        " facebook = '" + facebook + "'," +
                        " twitter = '" + twitter + "'," +
                        " linkedin = '" + linkedIn + "'," +
                        " workingtime = '" + workingTime + "'," +
                        " country = '" + country + "'," +
                        " state = '" + state + "'" +
                        " WHERE username = '" + username + "';";
                    Response.Write(cmd.CommandText);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "UPDATE usersTbl SET email = '" + email + "', password = '" + password + "' WHERE username = '" + username + "';";
                    Response.Write(cmd.CommandText);
                    int totalRowsUpdated = cmd.ExecuteNonQuery();
                    Response.Write("Total rows updated = " + totalRowsUpdated);
                }
                else if (personalTblUsername == "")
                {
                    cmd.CommandText = "Insert into companyPersonalTbl values (" + "'" + username + "'," +
                    "'" + companyName + "'," +
                    "'" + companyTagline + "'," +
                    "'" + companyCategory + "'," +
                    "'" + ownerName + "'," +
                    "'" + contactNo + "'," +
                    "'" + password + "'," +
                    "'" + address + "'," +
                    "'" + facebook + "'," +
                    "'" + twitter + "'," +
                    "'" + linkedIn + "'," +
                    "'" + workingTime + "'," +
                    "'" + country + "'," +
                    "'" + state + "'" + ")";
                    cmd.Connection = con;
                    con.Open();
                    int totalRowsEffected = cmd.ExecuteNonQuery();
                    Response.Write("Total rows updated = " + totalRowsEffected);
                    //nameOfUserLabel.Text = "Tap edit button to Provide Your Personal Info";

                    cmd.CommandText = "UPDATE usersTbl SET email = '" + email + "', password = '" + password + "' WHERE username = '" + username + "';";

                    Response.Write(cmd.CommandText);
                    int totalRowsUpdated = cmd.ExecuteNonQuery();
                    Response.Write("Total rows updated = " + totalRowsUpdated);
                }
            }
        }
    }
}