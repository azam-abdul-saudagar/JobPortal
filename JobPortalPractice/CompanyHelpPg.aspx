<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanyHelpPg.aspx.cs" Inherits="JobPortalPractice.CompanyHelpPg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Help</title>
    <!-- bootstrap -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <!--ReportSpam-->
    <link rel="stylesheet" href="ReportSpam.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
         <div class="login-box">
        <div id ="ResultMessage" runat="server"></div>
        <h1 class="login-box__heading">Help</h1>
        <div class="form-group form__group">
            <textarea rows="8" cols="80" class="form-control form__input" id="MessageTextBox" placeholder="message"
                required name="" runat="server" value=""></textarea>
        </div>
        <asp:Button ID="SendButton" class="bttn bttn--green" runat="server" Text="Help" OnClick="SendButton_Click" />
      </div>    
        </div>
    </form>
</body>
</html>
