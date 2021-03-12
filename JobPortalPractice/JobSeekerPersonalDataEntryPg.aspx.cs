using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class JobSeekerDataEntryPg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Session["username"].ToString();

            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM jobSeekerPersonalTbl WHERE username='" + username + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the name of the user from jobSeekerPersonalTbl to display on nameLabel
                while (rdr.Read())
                {
                    //fetching the username from the jobSeekerPersonalTbl
                    FNameTextBox.Text = rdr["fname"].ToString(); //The 0 stands for "the 0'th column", so the first column of the result.
                    LNameTextBox.Text = rdr["lname"].ToString();
                    ContactNoTextBox.Text = rdr["contactno"].ToString();
                    GenderTextBox.Text = rdr["gender"].ToString();
                    DobTextBox.Text = rdr["dob"].ToString();
                    FacebookTextBox.Text = rdr["facebook"].ToString();
                }
            }

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM usersTbl WHERE username='" + username + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the name of the user from jobSeekerPersonalTbl to display on nameLabel
                while (rdr.Read())
                {
                    //fetching the username from the jobSeekerPersonalTbl
                    EmailTextBox.Text = rdr["email"].ToString(); //The 0 stands for "the 0'th column", so the first column of the result.
                    PasswordTextBox.Text = rdr["password"].ToString();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string personalTblUsername = "";
            string username = Session["username"].ToString();
            string fName = FNameTextBox.Text;
            string lName = LNameTextBox.Text;
            string contactNo = ContactNoTextBox.Text;
            string gender = GenderTextBox.Text;
            string email = EmailTextBox.Text;
            string dob = DobTextBox.Text;
            string password = PasswordTextBox.Text;
            string facebook = FacebookTextBox.Text;
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM jobSeekerPersonalTbl WHERE username='" + username + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the name of the user from jobSeekerPersonalTbl to display on nameLabel
                while (rdr.Read())
                {
                    //fetching the username from the jobSeekerPersonalTbl
                    personalTblUsername = rdr["fName"].ToString(); //The 0 stands for "the 0'th column", so the first column of the result.
                }
            }
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                if (personalTblUsername != "")
                {
                        cmd.CommandText = "UPDATE jobSeekerPersonalTbl SET fname = '" + fName + "'," +
                            " lname = '" + lName + "'," +
                            " contactno = '" + contactNo + "'," +
                            " gender = '" + gender + "'," +
                            " dob = '" + dob + "'," +
                            " facebook = '" + facebook + "'" +
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
                        cmd.CommandText = "Insert into jobSeekerPersonalTbl values (" + "'" + username + "'," +
                        "'" + fName + "'," +
                        "'" + lName + "'," +
                        "'" + contactNo + "'," +
                        "'" + gender + "'," +
                        "'" + dob + "'," +
                        "'" + facebook + "'" + ")";
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