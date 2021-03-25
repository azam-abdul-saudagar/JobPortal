using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class ViewResume : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";

        }

        protected void SelectCandidateButton_Click(object sender, EventArgs e)
        {

        }
    }
}