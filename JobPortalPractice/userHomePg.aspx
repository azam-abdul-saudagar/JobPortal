<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userHomePg.aspx.cs" Inherits="JobPortalPractice.userHomePg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="JobSeekerNameLabel" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="JobNameTextBox" runat="server" Width="343px">Job Name</asp:TextBox>
            <asp:TextBox ID="LocationTextBox" runat="server" Width="338px">Location</asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />
            <asp:HyperLink ID="PersonalDetailHyperLink" runat="server" NavigateUrl="~/JobSeekerPersonalDataEntryPg.aspx">Personal Details</asp:HyperLink>
        </div>
    </form>
</body>
</html>
