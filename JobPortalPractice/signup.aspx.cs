using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JobPortalPractice
{
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignUpButton_Click(object sender, EventArgs e)
        {
            string CS = "data source=.; database = OnlineJobPortal; integrated security=SSPI";
            string accountType = AccountTypeDropDownList.SelectedValue;
            string username = UserNameTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert into usersTbl values (" + "'" + username + "'" + "," + "'" + email + "'" + "," + "'" + password + "'" + "," + "'" + accountType + "'" + ")";
                cmd.Connection = con;
                con.Open();
                int totalRowsEffected = cmd.ExecuteNonQuery();
                Label1.Text = "Account made succefully";
            }

        }
    }
}