using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class companyHomePg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string username = Session["username"].ToString();
            string companyName = "";

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM jobSeekerPersonalTbl WHERE username='" + username + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the name of the user from companyPersonalTbl to display on nameLabel
                while (rdr.Read())
                {
                    //fetching the username from the companyPersonalTbl
                    companyName = rdr["fName"].ToString(); //The 0 stands for "the 0'th column", so the first column of the result.
                }
                if (companyName != "")
                {
                    CompanyNameLabel.Text = companyName;
                }
                else
                {
                    CompanyNameLabel.Text = "Tap edit button to Provide Your Personal Info";
                }
            }
        }

        protected void AddJobButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("addJob.aspx");
        }
    }
}