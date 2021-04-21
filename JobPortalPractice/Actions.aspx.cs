using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class Actions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string jobId = Request.Form.Get("jobId");
            string status = Request.Form.Get("status");
            Response.Write("job id: " + jobId + "status:" + status);


            using (SqlConnection con = new SqlConnection(CS))
            {
                int Id = Int32.Parse(jobId);
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "UPDATE tblJobTrack SET Status = '" + status + "' WHERE JobId = '" + Id + "';";
                Response.Write(cmd.CommandText);
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                if(status == "Selected")
                {
                    Response.Write("<div class='jumbotron'>" +
                        "<h1 class='display-4'>Candidate Selected</h1>" +
                        "<p class='lead'>You have successfully selected this candidate you can view him in candidate selected page</p>" +
                        "<hr class='my-4'>" +
                        "<a class='btn btn-success btn-lg' href='JobApplications.aspx' role='button'>Home Page</a>" +
                        "</div>)");
                }
                else if( status == "Rejected")
                {
                    Response.Write("You Rejected this Job Application");
                    Response.Write("<a href='JobApplications.aspx'>Go to home page</a>");
                }
            }
        }
    }
}