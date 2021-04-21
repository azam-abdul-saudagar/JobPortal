<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportSpam.aspx.cs" Inherits="JobPortalPractice.ReportSpam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Report Spam</title>
    <!-- bootstrap -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <!--ReportSpam-->
    <link rel="stylesheet" href="ReportSpam.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
         <div class="login-box">
        <h1 class="login-box__heading">Report Spam</h1>
        <div class="form-group form__group">
            <textarea rows="8" cols="80" class="form-control form__input" id="SpamMessageTextBox" placeholder="message"
                required name="" runat="server" value=""></textarea>
        </div>
        <asp:Button ID="ReportButton" class="bttn bttn--red" runat="server" Text="Report" OnClick="ReportButton_Click" />
      </div>    
        </div>
    </form>
</body>
</html>
