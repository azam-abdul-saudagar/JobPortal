using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class SuccessfullyAppliedForJob : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string jobId = Request.Form.Get("jobId");
            string jobSeekerUserName = Request.Form.Get("jobSeekerUserName");
            Message.Text = "Successfully applied for the" + jobId + "job " + jobSeekerUserName;
            string companyUsername = "";
            string jobSeekerUsername = "";
            string jobTitle = "";
            string companyName = "";
            string companyEmail = "";
            string status = "Not Accepted";
            string appliedDate = DateTime.Now.ToString("dd/MM/yyyy");

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM tblAddJob WHERE ID='" + jobId + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the data of job from tblAddJob to display on nameLabel
                while (rdr.Read())
                {
                    //fetching the username from the jobSeekerPersonalTbl
                    companyUsername = rdr["CompanyUsername"].ToString(); //The 0 stands for "the 0'th column", so the first column of the result.
                    jobTitle = rdr["JobTitle"].ToString();
                    companyName = rdr["CompanyName"].ToString();
                    companyEmail = rdr["Email"].ToString();
                }
            }

            using (SqlConnection con = new SqlConnection(CS))
            {
                int Id = Int32.Parse(jobId);
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "Insert into tblTrackJob values (" + "'" + Id + "'" + "," +
                    "'" + companyUsername + "'" + "," +
                    "'" + jobSeekerUserName + "'" + "," + 
                    "'" + jobTitle + "'" + "," +
                    "'" + companyName + "'" + "," +
                    "'" + companyEmail + "'" + "," +
                    "'" + status + "'" + "," +
                    "'" + appliedDate + "')";
                Response.Write(cmd.CommandText);
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                
            }

        }
    }
}