<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jobSeekerHomePg.aspx.cs" Inherits="JobPortalPractice.userHomePg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Job Seeker Home Page</title>
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
        <h3 id="NameUser" class="mb-5"><asp:Label ID="JobSeekerNameUser" runat="server" Text=""></asp:Label></h3>
        
        <ul class="list-group">
          <!--<li class="list-group-item">
              <a href="#">View Profile</a></li>-->
          <li class="list-group-item">
              <a href="JobSeekerPersonalDataEntryPg.aspx">Edit Profile</a></li>
          <li class="list-group-item">
              <a href="UploadResume.aspx">Upload Resume</a></li>
          <!--<li class="list-group-item">
              <a href="#">Accepted Proporsals</a></li>-->
          <li class="list-group-item">
              <a href="AppliedJob.aspx">Applied Job</a></li>
        <li class="list-group-item">
              <a href="JobSeekerHelpPg.aspx">Help</a></li>
          <li class="list-group-item">
              <a href="JobSeekerFeedbackPg.aspx">Feedback</a></li>
        </ul>
      </div>
      </div>
      <div class="col-lg-10">
        <div class="search-section">
          <form action="#" method="post">
            <asp:TextBox ID="JobTitle" class='search-box' runat="server"  placeholder='Job Title or Keyword' Text=""></asp:TextBox>
            <asp:TextBox ID="Location" class='search-box' runat="server"  placeholder='Location' Text=""></asp:TextBox>
            <asp:Button ID="SearchButton" class='bttn btn-search bttn--green' type='button' name='button' runat="server" Text="Search" OnClick="SearchButton_Click" />
          </form>
        </div>
        <div runat="server" id="ContainerJob" class='container-job'>
         

       

     

    

      </div>

    </div>
  </div>
        </div>
    </form>
</body>
</html>
