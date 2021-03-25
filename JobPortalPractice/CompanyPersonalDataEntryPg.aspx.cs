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
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string username = Session["username"].ToString();
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM companyPersonalTbl WHERE username='" + username + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the data of the company from companyPersonalTbl;
                while (rdr.Read())
                {
                    //fetching the name from the companyPersonalTbl
                    CompanyNameTextBox.Value = rdr["companyname"].ToString();
                    CompanyTaglineTextBox.Value = rdr["tagline"].ToString();
                    OwnerNameTextBox.Value = rdr["ownername"].ToString();
                    ContactTextBox.Value = rdr["contactno"].ToString();
                    CompanyCategoryTextBox.Value = rdr["category"].ToString();
                    WorkingTimeTextBox.Value = rdr["workingtime"].ToString();
                    FacebookTextBox.Value = rdr["facebook"].ToString();
                    TwitterTextBox.Value = rdr["twitter"].ToString();
                    LinkedInTextBox.Value = rdr["linkedin"].ToString();
                    AddressTextBox.Value = rdr["address"].ToString();
                    StateTextBox.Value = rdr["state"].ToString();
                    CountryTextBox.Value = rdr["country"].ToString();
                    CityTextBox.Value = rdr["city"].ToString();
                }

                
            }

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
                    //fetching the data from the usersTbl
                    EmailTextBox.Value = rdr["email"].ToString();
                    PasswordTextBox.Value = rdr["password"].ToString();

                }
            }

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            string personalTblUsername = "";
            string username = Session["username"].ToString();
            string companyName = CompanyNameTextBox.Value;
            string companyTagline = CompanyTaglineTextBox.Value;
            string ownerName = OwnerNameTextBox.Value;
            string email = EmailTextBox.Value;
            string contactNo = ContactTextBox.Value;
            string password = PasswordTextBox.Value;
            string companyCategory = CompanyCategoryTextBox.Value;
            string workingTime = WorkingTimeTextBox.Value;
            string facebook = FacebookTextBox.Value;
            string twitter = TwitterTextBox.Value;
            string linkedIn = LinkedInTextBox.Value;
            string address = AddressTextBox.Value; ;
            string state = StateTextBox.Value;
            string country = CountryTextBox.Value;
            string city = CityTextBox.Value;
            
            
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
                        " state = '" + state + "'," +
                        " city = '" + city + "'" +
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
                    "'" + state + "'," +
                    "'" + city + "'" + ")";
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