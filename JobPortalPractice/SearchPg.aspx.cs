using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class SearchPg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string jobId, companyName, companyCategory, jobType, skills, location = "";
            int experience = 0;
            string jobHtml = "";

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM tblAddJob;";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the name of the user from jobSeekerPersonalTbl to display on nameLabel
                while (rdr.Read())
                {
                    //fetching the jobDetails from the addJobTbl
                    jobId = rdr["ID"].ToString();
                    companyName = rdr["CompanyName"].ToString();
                    companyCategory = rdr["Category"].ToString();
                    jobType = rdr["JobType"].ToString();
                    skills = rdr["Skills"].ToString();
                    //experience = (int)rdr["Experience"];
                    location = rdr["City"].ToString() + " ," + rdr["State"].ToString() + " ," + rdr["Country"].ToString();

                    jobHtml += "<div class='job'>"
                + "<h2>" + companyName + "</h2>" +

                        "<br/>" +

                        "<h4>" + companyCategory + "</h4>" +

                               "<hr/>" +

                               "<table>" +

                                   "<tr>" +

                                       "<td> Job Id:</td>" +

                                          "<td>" +

                                              jobId +

                                               "</td>" +

                                                   "<td rowspan = '2'></ td >" +

                                                "</tr>" +

                                                "<tr>" +

                                                    "<td> Job Type:</td>" +

                                                       "<td>" +

                                                          jobType +

                                                                "</td>" +

                                                            "</tr>" +

                                                            "<tr>" +

                                                                "<td> Skills:</td>" +

                                                                   "<td>" +

                                                                       skills +

                                                                            "</td>" +

                                                                            "<td>" +

                                                                                "<form action='Login.aspx' method='post'>" +
                                                                                "<button type='submit'>APPLY JOB</button></form>" +

                                                                                 "</td>" +

                                                                             "</tr>" +

                                                                             "<tr>" +

                                                                                 "<td> Experience:</td>" +

                                                                                    "<td>" +

                                                                                        experience +

                                                                                             "</td>" +

                                                                                             "<td>" +
                                                                                              "<form action='JobDetail.aspx' method='post' id='jobId'>" +
                                                                                                  "<input type='hidden' name='jobID' value='" + jobId +"' />" +
                                                                                                   "<button type='submit'>VIEW JOB</button>" + 
                                                                                               "</form>" +
                                                                                              "</td>" +

                                                                                                "</tr>" +

                                                                                                "<tr>" +

                                                                                                    "<td> Location:</td>" +

                                                                                                       "<td>" +

                                                                                                           location +

                                                                                                                "</td>" +

                                                                                                                "<td rowspan = '1'></td>" +


                                                                                                             "</tr>" +

                                                                                                         "</table> </div>";



                }
                ContainerJob.InnerHtml = jobHtml;
            }
        }     
    }

}