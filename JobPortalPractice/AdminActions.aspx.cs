using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class AdminActions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string action = Request.Form.Get("Action");

            if (action == "RemoveComplaint")
            {
                string id = Request.Form.Get("ID");
                

                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "DELETE FROM tblSpam WHERE ID = '" + id + "';";
                    cmd.Connection = con;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    Response.Write("<div class='jumbotron'>" +
                       "<h1 class='display-4'>Removed Complaint</h1>" +
                       "<p class='lead'>You have removed this complaint</p>" +
                       "<hr class='my-4'>" +
                       "<a class='btn btn-success btn-lg' href='AdminHomePg.aspx' role='button'>Home Page</a>" +
                       "</div>)");
                    //RemoveMessage.InnerHtml = ID + "Removed Sucessfully";
                    //HomePageRedirect.InnerHtml = "Go to <a href='AdminHomePg.aspx'>Applied Job Page</a>";
                }
                
            }
            else if (action == "RemoveCompany")
            {
                string companyName = Request.Form.Get("companyName");

                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "DELETE FROM tblSpam WHERE  = '" + "id" + "';";
                    cmd.Connection = con;
                    //con.Open();
                    //SqlDataReader rdr = cmd.ExecuteReader();
                    Response.Write("<div class='jumbotron'>" +
                       "<h1 class='display-4'>Removed Company</h1>" +
                       "<p class='lead'>You have have removed this company successfully</p>" +
                       "<hr class='my-4'>" +
                       "<a class='btn btn-success btn-lg' href='AdminHomePg.aspx' role='button'>Home Page</a>" +
                       "</div>)");
                    //RemoveMessage.InnerHtml = ID + "Removed Sucessfully";
                    //HomePageRedirect.InnerHtml = "Go to <a href='AdminHomePg.aspx'>Applied Job Page</a>";
                }
            }
            else if (action == "RemoveQuery")
            {
                string id = Request.Form.Get("ID");

                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "DELETE FROM tblQueries WHERE ID = '" + id + "';";
                    cmd.Connection = con;
                    con.Open();
                    Response.Write("<div class='jumbotron'>" +
                       "<h1 class='display-4'>Removed Query</h1>" +
                       "<p class='lead'>You have have removed this query successfully</p>" +
                       "<hr class='my-4'>" +
                       "<a class='btn btn-success btn-lg' href='AdminQueries.aspx' role='button'>Queries Page</a>" +
                       "</div>)");
                    SqlDataReader rdr = cmd.ExecuteReader();
                    //RemoveMessage.InnerHtml = ID + "Removed Sucessfully";
                    //HomePageRedirect.InnerHtml = "Go to <a href='AdminQueries.aspx'>Applied Job Page</a>";
                }
            }
            if (action == "RemoveFeedback")
            {
                string id = Request.Form.Get("ID");

                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "DELETE FROM tblFeedback WHERE ID = '" + id + "';";
                    cmd.Connection = con;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    Response.Write("<div class='jumbotron'>" +
                       "<h1 class='display-4'>Removed Feedback</h1>" +
                       "<p class='lead'>You have have removed this feedback successfully</p>" +
                       "<hr class='my-4'>" +
                       "<a class='btn btn-success btn-lg' href='AdminFeedbackPg.aspx' role='button'>Feedback Page</a>" +
                       "</div>)");
                    //RemoveMessage.InnerHtml = ID + "Removed Sucessfully";
                    //HomePageRedirect.InnerHtml = "Go to <a href='AdminFeedbackPg.aspx'>Applied Job Page</a>";
                }
            }



        }
    }
}