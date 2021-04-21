<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanyHomePg.aspx.cs" Inherits="JobPortalPractice.companyHomePg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Job Seeker Home Page</title>
      <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css" integrity="sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l" crossorigin="anonymous" />
  <!-- css -->
    <link rel="stylesheet" href="CompanyHomePg.css" />
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
        <h3 id="NameUser" class="mb-5"><asp:Label ID="CompanyName" runat="server" Text=""></asp:Label></h3>
        
        <ul class="list-group">
          <li class="list-group-item">
              <a href="ViewCompanyProfile.aspx">View Profile</a></li>
          <li class="list-group-item">
              <a href="CompanyPersonalDataEntryPg.aspx">Edit Profile</a></li>
          <li class="list-group-item">
              <a href="AddJob.aspx">Add Job</a></li>
          <li class="list-group-item">
              <a href="SelectedCandidate.aspx">Selected Candidates</a></li>
          <li class="list-group-item">
              <a href="JobApplications.aspx">Applications</a></li>
          <li class="list-group-item">
              <a href="CompanyHelpPg.aspx">Help</a></li>
        </ul>
      </div>
      </div>
      <div class="col-lg-10">
        <div class="search-section">
          <form action="#" method="post">
            <asp:TextBox ID="JobTitle" class='search-box' runat="server"  placeholder='Job Title or Keyword' ></asp:TextBox>
            <asp:TextBox ID="Location" class='search-box' runat="server"  placeholder='Location' ></asp:TextBox>
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
