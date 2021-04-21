<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JobSeekerHelpPg.aspx.cs" Inherits="JobPortalPractice.JobSeekerHelpPg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Message"></asp:Label>
            <br />
            <asp:TextBox ID="MessageTextBox" runat="server" Rows="8" TextMode="MultiLine" Width="945px"></asp:TextBox>
            <asp:Button ID="SendButton" runat="server" Text="Send" OnClick="SendButton_Click" />
        </div>
    </form>
</body>
</html>
