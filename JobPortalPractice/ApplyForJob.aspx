<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplyForJob.aspx.cs" Inherits="JobPortalPractice.SuccessfullyAppliedForJob" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Apply job</title>
    <!--bootstrap-->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="jumbotron">
            <h1 class="display-4" id="MessageHeading" runat="server">Successfully applied for job!</h1>
            <p class="lead" id="MessageBody" runat="server">You have successfull applied for the job whose id is </p>
            <hr class="my-4">
            <a class="btn btn-success btn-lg" href="JobSeekerHomePg.aspx" role="button">Home Page</a>
            </p>
            </div>
        </div>
    </form>
</body>
</html>
