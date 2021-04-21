<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="JobPortalPractice.signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Signup</title>
    <!-- bootstrap -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <!-- css -->
    <link rel="stylesheet" href="signup.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>

        <div class="login-box">
        <h1 class="login-box__heading">Signup</h1>
            <div class="form-group">
                <select id="AccountType" class=" form__dropdown form__input" required name="" runat="server">
                    <option value="Job Seeker">Job Seeker</option>
                    <option value="Company">Company</option>
                </select>
            </div>
        <div class="form-group form__group">
            <input type="text" class="form-control form__input" id="UserNameTextBox" placeholder="username"
                required name="" runat="server" value="">
            <label for="UserNameTextBox" class="form__label">Username</label>
        </div>
        <div class="form-group form__group">
            <input type="text" class="form-control form__input" id="EmailTextBox" placeholder="email"
                required name="" runat="server" value="">
            <label for="EmailTextBox" class="form__label">Email</label>
        </div>
        <div class="form-group form__group">
            <input type="text" class="form-control form__input" id="PasswordTextBox" placeholder="password"
                required name="" runat="server" value="">
            <label for="PasswordTextBox" class="form__label">Password</label>
        </div>
        <div class="form-group form__group">
            <input type="text" class="form-control form__input" id="ConfirmPasswordTextBox" placeholder="confirm password"
                required name="" runat="server" value="">
            <label for="confirmTextBox" class="form__label">Confirm Password</label>
        </div>
        <div id="message" runat="server">
        </div>
        <asp:Button ID="SignUpButton" runat="server" OnClick="SignUpButton_Click" Text="Sign up" class="bttn bttn--green" />
        <h4>Already have an account <a href="Login.aspx">Login here</a></h4>
        </div>
        

            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </form>
    
</body>
</html>
