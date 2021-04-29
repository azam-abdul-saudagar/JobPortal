<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JobSeekerPersonalDataEntryPg.aspx.cs" Inherits="JobPortalPractice.JobSeekerDataEntryPg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Profile</title>    
    <!--bootstrap-->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css"
        integrity="sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l" crossorigin="anonymous">
    <!--css-->
    <link rel="stylesheet" href="JobSeekerPersonalDataEntryPg.css" /> 
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <h1>Edit Profile</h1>
                <div class="form-row">
                  <div class="col">
                      <div class="form-group row">
                     <label class="col-sm-3 col-form-label">First Name :</label>
                      <div class="col-sm-9">
                     <asp:TextBox class="form-control" ID="FNameTextBox" runat="server"></asp:TextBox>
                    </div>
                 </div>                  
                  </div>
                <div class="col">
                    <div class="form-group row">
        <label class="col-sm-3 col-form-label">Last Name :</label>
        <div class="col-sm-9">
          <asp:TextBox class="form-control" ID="LNameTextBox" runat="server"></asp:TextBox>
        </div>
      </div>
                    
                  </div>
               </div>
               <div class="form-row">
                  <div class="col">
                      <div class="form-group row">
        <label class="col-sm-3 col-form-label">Contact No :</label>
        <div class="col-sm-9">
          <asp:TextBox class="form-control" ID="ContactNoTextBox" runat="server"></asp:TextBox>
        </div>
      </div>
                       
                  </div>
                <div class="col">
                    <div class="form-group row">
        <label class="col-sm-3 col-form-label">Gender :</label>
        <div class="col-sm-9">
          <asp:TextBox class="form-control" ID="GenderTextBox" runat="server"></asp:TextBox>
        </div>
      </div>
                      
                  </div>
               </div>
               <div class="form-row">
                  <div class="col">
                      <div class="form-group row">
        <label class="col-sm-3 col-form-label">Email :</label>
        <div class="col-sm-9">
          <asp:TextBox class="form-control" ID="EmailTextBox" runat="server"></asp:TextBox> 
        </div>
      </div>
                      
                  </div>
                <div class="col">
                    <div class="form-group row">
        <label class="col-sm-3 col-form-label">Password :</label>
        <div class="col-sm-9">
          <asp:TextBox class="form-control" ID="PasswordTextBox" runat="server"></asp:TextBox>
        </div>
      </div>
                    
                  </div>
               </div>
               <div class="form-row">
                  <div class="col">
                      <div class="form-group row">
        <label class="col-sm-3 col-form-label">D.O.B :</label>
        <div class="col-sm-9">
          <asp:TextBox class="form-control" ID="DobTextBox" runat="server"></asp:TextBox>
        </div>
      </div>
                      
                  </div>
                <div class="col">
                    <div class="form-group row">
        <label class="col-sm-3 col-form-label">Facebook :</label>
        <div class="col-sm-9">
          <asp:TextBox class="form-control" ID="FacebookTextBox" runat="server"></asp:TextBox>
        </div>
      </div>
                    
                  </div>
               </div>
            <div class="row">
                    <div class="col-lg-4">
                         <asp:Button ID="Button1" class="btn btn-success" runat="server" Text="Save" OnClick="Button1_Click" />                                                   
                    </div>
                </div> 
                   

        </div>
    </form>
</body>
</html>
