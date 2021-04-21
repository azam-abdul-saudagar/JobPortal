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
                    Response.Write(cmd.CommandText);
                    cmd.Connection = con;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    RemoveMessage.InnerHtml = ID + "Removed Sucessfully";
                    HomePageRedirect.InnerHtml = "Go to <a href='AdminHomePg.aspx'>Applied Job Page</a>";
                }
                
            }
            else if (action == "RemoveCompany")
            {
                string companyName = Request.Form.Get("companyName");
                Response.Write("Remove company of" + companyName);

                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "DELETE FROM tblSpam WHERE  = '" + "id" + "';";
                    Response.Write(cmd.CommandText);
                    cmd.Connection = con;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    RemoveMessage.InnerHtml = ID + "Removed Sucessfully";
                    HomePageRedirect.InnerHtml = "Go to <a href='AdminHomePg.aspx'>Applied Job Page</a>";
                }
            }
            else if (action == "RemoveQuery")
            {
                string id = Request.Form.Get("ID");
                Response.Write("Remove Query of" + id);

                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "DELETE FROM tblQueries WHERE ID = '" + id + "';";
                    Response.Write(cmd.CommandText);
                    cmd.Connection = con;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    RemoveMessage.InnerHtml = ID + "Removed Sucessfully";
                    HomePageRedirect.InnerHtml = "Go to <a href='AdminQueries.aspx'>Applied Job Page</a>";
                }
            }
            if (action == "RemoveFeedback")
            {
                string id = Request.Form.Get("ID");
                Response.Write("Remove Feedback of" + id);

                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "DELETE FROM tblFeedback WHERE ID = '" + id + "';";
                    Response.Write(cmd.CommandText);
                    cmd.Connection = con;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    RemoveMessage.InnerHtml = ID + "Removed Sucessfully";
                    HomePageRedirect.InnerHtml = "Go to <a href='AdminFeedbackPg.aspx'>Applied Job Page</a>";
                }
            }



        }
    }
}