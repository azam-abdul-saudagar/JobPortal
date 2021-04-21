<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AppliedJob.aspx.cs" Inherits="JobPortalPractice.AppliedJob" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Applied Jobs</title>
    <!-- bootstrap -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"
    integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <!-- css -->
    <link rel="stylesheet" href="AppliedJob.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="applied-job">
        <div class="applied-job__header">
            <h1>Applied Jobs</h1>
        </div>
        <div class="applied-job__body">
            <table>
                <thead>
                    <tr>
                        <th scope="col">ID</th>
                        <th scope="col">Job Title</th>
                        <th scope="col">Company Name</th>
                        <th scope="col">Company Email</th>
                        <th scope="col">Applied Date</th>
                        <th scope="col">Status</th>
                        <th scope="col">Action</th>
                    </tr>
                </thead>
                <tbody>
                    <div class="applied-jobs" id="AppliedJobs" runat="server">
                       
                   </div>
                </tbody>
            </table>
        </div>
    </div>
        </div>
    </form>
</body>
</html>
