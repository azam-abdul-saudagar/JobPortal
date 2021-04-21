<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchJobDetail.aspx.cs" Inherits="JobPortalPractice.SearchJobDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Job Detail</title>
    <link rel="stylesheet" href="SearchJobDetail.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="header">
        <div class="header__content">
            <h2 id="JobTitle" runat="server">Front End Developer</h2>
            <div class="header__features--main">

                <h4 id="CompanyName" runat="server">Google</h4>
                <h4 id="Vacancy" runat="server">7 vacancy</h4>
                <h4 id="Country" runat="server">United Kingdom</h4>
                <h4 id="SalaryRange" runat="server">20K To 50K/Month</h4>
            </div>
            <div class="header__features--sub">
                <h4>Job Category : <span  id="JobCategory" runat="server">Full Time</span></h4>
                <h4>Job Experience : <span  id="Experience" runat="server">5 Year</span></h4>
                <h4>Job ID : <span id="JobId" runat="server">22+ Year</span></h4>
                    <asp:Label class="verified-sign" ID="Label1" runat="server" Text="Verified"></asp:Label>
            </div>
        </div>
    </div>
    <hr class="border-green" />
    <div class="body">
        <div class="body__sub-part">
            <h3>Job Description</h3>
            <p id="JobDescription" runat="server">"On the other hand, we denounce with righteous indignation and dislike men who are so beguiled and
                demoralized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the
                pain and trouble that are bound to ensue.

                At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum
                deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non
                provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga.
            </p>
        </div>
        <div class="body__sub-part">
            <h3>Skills</h3>
            <ul id="SkillsContainer" runat="server">
                
                
            </ul>
        </div>
        <div class="body__sub-part">
            <h3>Requirements</h3>
            <p>
            <ul id="RequirementsContainer" runat="server">
               
            </ul>
            </p>
        </div>
        <div class="body__sub-part">
            <h3>Contact</h3>
            <ul>
                <li>Email :  <span id="Email" runat="server">mail@example.com</span></li>
                <li>Contact No : <span id="ContactNo" runat="server">91 234 567 8765</span></li>
            </ul>
        </div>
        <div class="body__sub-part">
            <h3>Location</h3>
            <p id="Location" runat="server">
            
            </p>
        </div>
        <asp:Button ID="ViewCompanyProfileButton" class="btn btn--green" runat="server" Text="View Company Profile" OnClick="ViewCompanyProfileButton_Click" />
        </div>
    </form>
</body>
</html>
