<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="JobPortalPractice.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="UserNameTextBox" runat="server" placeholder="username"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="PasswordTextBox" runat="server" placeholder="password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="LoginButton" runat="server" OnClick="LoginButton_Click" Text="Login" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
