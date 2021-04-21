<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchPg.aspx.cs" Inherits="JobPortalPractice.SearchPg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search Page</title>
      <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css" integrity="sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l" crossorigin="anonymous" />
  <!-- css -->
    <link rel="stylesheet" href="SearchPg.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <nav class="navbar navbar-expand-lg navbar-light bg-light">
        <a class="navbar-brand" href="#">Job <span class="navbar-brand--portal">Portal</span></a>
    <ul class="navbar-nav ml-auto">
            <li class="nav-item">
                <a class="nav-link" href="Login.aspx">Login</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="signup.aspx">Signup</a>
            </li>
        </ul>
          </nav>
       </div>

  <div class="container-fluid section-main">
    <div class="row">
      <div class="col-lg-12">
        <div class="search-section">
          <form></form>
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
