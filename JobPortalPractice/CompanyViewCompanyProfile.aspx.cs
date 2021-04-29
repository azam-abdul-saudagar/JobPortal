using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class CompanyViewCompanyProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string id = Request.QueryString["jobId"];
            string companyUserName = Session["username"].ToString();

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM tblAddJob WHERE ID='" + id + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the data of the company from companyPersonalTbl;
                while (rdr.Read())
                {
                    //fetching the name from the companyPersonalTbl
                    companyUserName = rdr["CompanyUsername"].ToString();
                }
            }

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM companyPersonalTbl WHERE username='" + companyUserName + "';";
                cmd.Connection = con;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                //Getting the data of the company from companyPersonalTbl;
                while (rdr.Read())
                {
                    //fetching the name from the companyPersonalTbl
                    CompanyName.InnerText = rdr["companyname"].ToString();
                    CompanyTagline.InnerText = rdr["tagline"].ToString();
                    OwnerName.InnerText = rdr["ownername"].ToString();
                    ContactNo.InnerText = rdr["contactno"].ToString();
                    Category.InnerText = rdr["category"].ToString();
                    WorkingTime.InnerText = rdr["workingtime"].ToString();
                    Facebook.InnerText = rdr["facebook"].ToString();
                    Twitter.InnerText = rdr["twitter"].ToString();
                    LinkedIn.InnerText = rdr["linkedin"].ToString();
                    Address.InnerText = rdr["address"].ToString();
                    /*State.InnerText = rdr["state"].ToString();*/
                    Country.InnerText = rdr["country"].ToString();
                    /*City.InnerText = rdr["city"].ToString();*/
                }
            }
        }
    }
    }