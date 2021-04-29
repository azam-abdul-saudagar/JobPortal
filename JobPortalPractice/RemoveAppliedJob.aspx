<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RemoveAppliedJob.aspx.cs" Inherits="JobPortalPractice.DeleteAppliedJob" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Removed Applied Job</title>
    <!--bootstrap-->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="jumbotron">
            <h1 class="display-4" id="RemoveMessage" runat="server">Application Removed!</h1>
            <p class="lead" id="RemoveMessageBody" runat="server">You have removed the application for this job </p>
            <hr class="my-4">
            <a class="btn btn-success btn-lg" href="AppliedJob.aspx" role="button">Applied Job Page</a>
            </p>
            </div>
        </div>
    </form>
</body>
</html>
