using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class ReportSpam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ReportButton_Click(object sender, EventArgs e)
        {
            
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string jobSeekerUserName = Session["username"].ToString();
            string companyName = "";
            string jobSeekerName = "";
            string companyUserName = "";
            string spamMessage = "";

            string jobId = Request.QueryString["jobId"];

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM tblAddJob WHERE ID='" + jobId + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    companyUserName = rdr["CompanyUserName"].ToString();
                    companyName = rdr["CompanyName"].ToString();
                }
            }

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM jobSeekerPersonalTbl WHERE username='" + jobSeekerUserName + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the name of the user from jobSeekerPersonalTbl
                while (rdr.Read())
                {
                    //fetching the name from the jobSeekerPersonalTbl
                    jobSeekerName = rdr["fName"].ToString();
                }
            }
            spamMessage = SpamMessageTextBox.Value;

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "Insert into tblSpam (JobSeekerUserName,JobSeekerName,CompanyUserName,CompanyName,Message) values (" + "'" + jobSeekerUserName + "'," +
                   "'" + jobSeekerName + "'," +
                   "'" + companyUserName + "'," +
                   "'" + companyName + "'," +
                   "'" + spamMessage + "'" + ")";
                cmd.Connection = con;
                con.Open();
                int totalRowsEffected = cmd.ExecuteNonQuery();
            }


        }
    }
}