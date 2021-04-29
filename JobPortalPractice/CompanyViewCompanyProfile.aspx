<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanyViewCompanyProfile.aspx.cs" Inherits="JobPortalPractice.CompanyViewCompanyProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Company Profile</title>
    <link rel="stylesheet" href="ViewResume.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="header">
        <div class="box">
            <div class="header__content">
                <h2 id="CompanyName" runat="server">Alden Smith</h2>
                <div class="header__features--main">

                    <h4 class="job-title" id="CompanyTagline" runat="server">Front End Designer</h4>
                    <h4 id="Category" runat="server">Software Development</h4>
                    <h4 id="OwnerName" runat="server">kingllc@king.com</h4>
                    <h4 id="ContactNo" runat="server">91 234 567 8765</h4>
                    <h4 id="Address" runat="server">California, USA</h4>
                </div>
                <div class="header__features--sub">
                    <h4>Facebook : <span id="Facebook" runat="server">carol@facebook.com</span></h4>
                    <h4>Twitter : <span id="Twitter" runat="server">carol@twitter.com</span></h4>
                    <h4>LinkedIn : <span id="LinkedIn" runat="server">king@linkedin.com</span></h4>
                    <h4>Working time : <span id="WorkingTime" runat="server">8am - 10pm</span></h4>
                    <h4>Country : <span id="Country" runat="server">USA</span></h4>
                </div>
            </div>
        </div>
    </div>

    </div>
        </div>
    </form>
</body>
</html>
