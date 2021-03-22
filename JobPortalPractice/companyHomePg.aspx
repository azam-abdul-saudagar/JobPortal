<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="companyHomePg.aspx.cs" Inherits="JobPortalPractice.companyHomePg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="CompanyNameLabel" runat="server" Text="Company Name"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 41px" Width="327px"></asp:TextBox>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 55px" Width="280px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <div>
            <asp:HyperLink ID="ViewProfileHyperLink" runat="server" NavigateUrl="~/CompanyPersonalDataEntryPg.aspx">View Profile</asp:HyperLink>
            <br />
            <asp:Button ID="AddJobButton" runat="server" OnClick="AddJobButton_Click" Text="ADD JOB" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>
