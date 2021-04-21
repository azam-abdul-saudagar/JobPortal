using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class DeleteAppliedJob : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string jobId = Request.Form.Get("jobId");
            string jobSeekerUserName = Request.Form.Get("jobSeekerUserName");
            Response.Write(jobId + jobSeekerUserName);

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "DELETE FROM tblJobTrack WHERE JobId = '" + jobId + "' AND JobSeekerUserName = '" + jobSeekerUserName + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                RemoveMessage.InnerHtml = jobId + "Removed Sucessfully" + jobSeekerUserName;
                HomePageRedirect.InnerHtml = "Go to <a href='AppliedJob.aspx'>Applied Job Page</a>";              
            }
        }
    }
}