<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="JobPortalPractice.signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="AccountTypeDropDownList" runat="server">
                <asp:ListItem>Job Seeker</asp:ListItem>
                <asp:ListItem>Company</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:TextBox ID="UserNameTextBox" runat="server">User name</asp:TextBox>
            <br />
            <asp:TextBox ID="EmailTextBox" runat="server">Email</asp:TextBox>
            <br />
            <asp:TextBox ID="PasswordTextBox" runat="server">Password</asp:TextBox>
            <br />
            <asp:TextBox ID="ConfirmPasswordTextBox" runat="server">Confirm password</asp:TextBox>
            <br />
            <asp:Button ID="SignUpButton" runat="server" OnClick="SignUpButton_Click" Text="Sign up" />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
