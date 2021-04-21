 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="JobPortalPractice.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <!-- bootstrap -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <!-- css -->
    <link rel="stylesheet" href="Login.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
         <div class="login-box">
        <h1 class="login-box__heading">Login</h1>
        <div class="form-group form__group">
            <input type="text" class="form-control form__input" id="UserNameTextBox" placeholder="username"
                required name="" runat="server" value="">
            <label for="UserNameTextBox" class="form__label">username</label>
        </div>
        <div class="form-group form__group">
            <input type="text" class="form-control form__input" id="PasswordTextBox" placeholder="password"
                required name="" runat="server" value="">
            <label for="PasswordTextBox" class="form__label">password</label>
        </div>
        <asp:Button ID="LoginButton" class="bttn bttn--green" runat="server" OnClick="LoginButton_Click" Text="Login" />
        <h4>Don't have an account <a href="Signup.aspx">Signup here</a></h4>
      </div>
     
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
