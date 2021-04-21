<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminFeedbackPg.aspx.cs" Inherits="JobPortalPractice.AdminFeedbackPg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
        Admin Feedback
    </title>
         <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css" integrity="sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l" crossorigin="anonymous" />
  <!-- css -->
    <link rel="stylesheet" href="JobSeekerHomePg.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav class="navbar navbar-light bg-light">
    <a class="navbar-brand" href=#>
      Job Portal
    </a>
    <asp:Button ID="LogoutButton" class="btn btn-danger" runat="server" Text="Log out" OnClick="LogoutButton_Click" />
  </nav>

  <div class="container-fluid section-main">
    <div class="row">
      <div class="col-lg-2">
        <div class="features">
        <h3 id="NameUser" class="mb-5"><asp:Label ID="AdminName" runat="server" Text=""></asp:Label></h3>
        
        <ul class="list-group">
          <li class="list-group-item">
              <a href="AdminHomePg.aspx">Spam Messages</a></li>
          <li class="list-group-item">
              <a href="AdminQueries.aspx">Queries</a></li>
          <li class="list-group-item">
              <a href="#">Feedbacks</a></li>
          <li class="list-group-item">
        </ul>
      </div>
      </div>
      <div class="col-lg-10">
        
        <div runat="server" id="ContainerJob" class='container-job'>
         

       

     

    

      </div>

    </div>
  </div>
        </div>
    </form>
</body>
</html>
