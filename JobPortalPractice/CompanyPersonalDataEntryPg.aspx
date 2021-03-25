<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanyPersonalDataEntryPg.aspx.cs" Inherits="JobPortalPractice.CompanyPersonalDataEntryPg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Company Personal Data Entry</title>
    <!--bootstrap-->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css"
        integrity="sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l" crossorigin="anonymous">
    <!--css-->
    <link rel="stylesheet" href="CompanyPersonalDataEntryPg.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="resume">
        <div class="resume__form">

        </div>

        <div class="container">
            <h2 class="heading-secondary">
                Personal Info
            </h2>
            <form class="form" action="CompanyPersonalDataEntry.aspx" method="post">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="form-group form__group">
                            <input type="text" class="form-control form__input" id="CompanyNameTextBox" placeholder="Company Name"
                                required name="" runat="server">
                            <label for="CompanyNameTextBox" class="form__label">Company Name</label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-12">
                        <div class="form-group form__group">
                            <input type="text" class="form-control form__input" id="CompanyTaglineTextBox" placeholder="Company Tagline"
                                required name="" runat="server">
                            <label for="CompanayTaglineTextBox" class="form__label">Companay Tagline</label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-6">
                        <div class="form-group form__group">
                            <input type="text" class="form-control form__input" id="OwnerNameTextBox" placeholder="Owner Name"
                                required name="" runat="server">
                            <label for="OwnerNameTextBox" class="form__label">Owner Name</label>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="email" class="form-control form__input" id="EmailTextBox" placeholder="Email" required
                                name="" runat="server">
                            <label for="EmailTextBox" class="form__label">Email</label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="number" class="form-control form__input" id="ContactTextBox"
                                placeholder="Contact No" required name="" runat="server">
                            <label for="ContactTextBox" class="form__label">Contact No</label>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="text" class="form-control form__input" id="PasswordTextBox"
                                placeholder="Password" required name="" runat="server">
                            <label for="PasswordTextBox" class="form__label">Password</label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="text" class="form-control form__input" id="CompanyCategoryTextBox" placeholder="Companay Category"
                                required name="" runat="server">
                            <label for="CompanyCategoryTextBox" class="form__label">Company Category</label>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="text" class="form-control form__input" id="WorkingTimeTextBox"
                                placeholder="Working Time" required name="" runat="server">
                            <label for="WorkingTimeTextBox" class="form__label">Working Time</label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="text" class="form-control form__input" id="FacebookTextBox"
                                placeholder="Facebook" required name="" runat="server">
                            <label for="FacebookTextBox" class="form__label">Facebook</label>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="text" class="form-control form__input" id="TwitterTextBox"
                                placeholder="Twitter" required name="" runat="server">
                            <label for="TwitterTextBox" class="form__label">Twitter</label>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="text" class="form-control form__input" id="LinkedInTextBox"
                                placeholder="LinkedIn" required name="" runat="server">
                            <label for="LinkedIn" class="form__label">Linked In</label>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="text" class="form-control form__input" id="CityTextBox"
                                placeholder="City" required name="" runat="server">
                            <label for="CityTextBox" class="form__label">City</label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-12">
                        <div class="form-group">
                            <textarea class="form-control form__input" id="AddressTextBox" rows="4"
                                placeholder="Address" required name="" runat="server"></textarea>
                            <label for="AddressTextBox" class="form__label">Address</label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="text" class="form-control form__input" id="StateTextBox" placeholder="State" required
                                name="" runat="server">
                            <label for="StateTextBox" class="form__label">State</label>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="text" class="form-control form__input" id="CountryTextBox" placeholder="Country" required
                                name="" runat="server">
                            <label for="CountryTextBox" class="form__label">Country</label>
                        </div>
                    </div>
                </div>
                <asp:Button ID="Button1" type="submit" class="bttn bttn--green" runat="server" Text="UPDATE INFO" />
            </form>
        </div>



    </div>
        </div>
    </form>
</body>
</html>
