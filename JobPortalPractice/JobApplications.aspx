<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JobApplications.aspx.cs" Inherits="JobPortalPractice.JobApplications" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Applications</title>
    <!--bootstrap-->
     <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css" integrity="sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l" crossorigin="anonymous" />
    <!--css-->
    <link rel="stylesheet" href="JobApplications.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container-fluid section-main">
              <h1>Job Applications</h1>
                <div class='container-job' id="ContainerJob" runat="server">
                </div>
            </div>
        </div>
    </form>
</body>
</html>
