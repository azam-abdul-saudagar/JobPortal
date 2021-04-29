<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePg.aspx.cs" Inherits="JobPortalPractice.HomePg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <!-- google fonts -->
    <link href="https://fonts.googleapis.com/css2?family=Lato:wght@100;300;400;700&display=swap" rel="stylesheet">
    <!-- bootstrap -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"
        integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <!-- css -->
    <link rel="stylesheet" href="HomePg.css">
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
        </div>
    </nav>
    <div class="container-fluid">
        <div class="row">
            <div class="col-6">
                <div class="heading">
                    <h1 class="heading-primary">Find your job favourite and immediate</h1>
                    <p class="heading-secondary">Search for your dream job while on the go with the best web-search web
                        platform available.</p>
                    <div class="search-section">
                        <form></form>
                        <form action="SearchPg.aspx" method="post">
                            <input type="text" name="JobTitle" value="" ID="JobTitle" class='search-box' runat="server"
                                placeholder="Job Title or Keyword" />
                            <input type="text" name="Location" value="" ID="Location" class='search-box' runat="server"
                                placeholder="Location" />
                            <button type="submit" ID="SearchButton" class='bttn bttn--green'>Search</button>
                        </form>
                    </div>
                </div>
            </div>
            <div class="col-6 img-container">
                <div class="img-box">
                    <img class="svg" src="Images/peoplesearch3.png" alt="people search svg">
                </div>

            </div>
        </div>
    </div>
        </div>
    </form>
</body>
</html>
