<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadResume.aspx.cs" Inherits="JobPortalPractice.UploadResumee1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Resume</title>
    <!--bootstrap-->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css"
        integrity="sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l" crossorigin="anonymous">
    <!--css-->
    <link rel="stylesheet" href="UploadResume.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="resume">
        <div class="resume__form">

        </div>

        <div class="container">
            <h2 class="heading-secondary">
                RESUME
            </h2>
            <form class="form" action="UploadResume.aspx" method="post">
                <div class="row">
                    <div class="col-lg-12">
                        <!--<div class="form__group">
                            <input type="text" class="form__input" placeholder="Full Name" id="name"
                                value="" autocomplete="off">
                            
                        </div>-->
                        <div class="form-group form__group">
                            <input type="text" class="form-control form__input" id="FullName" placeholder="Full Name"
                                required name="" runat="server" value="">
                            <label for="FullName" class="form__label">Full Name</label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-6">
                        <div class="form-group form__group">
                            <input type="text" class="form-control form__input" id="JobTitle" placeholder="Job Title"
                                required name="" runat="server">
                            <label for="JobTitle" class="form__label">Job Title</label>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="email" class="form-control form__input" id="Email" placeholder="Email" required
                                name="" runat="server">
                            <label for="Email" class="form__label">Email</label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="number" class="form-control form__input" id="ContactNo"
                                placeholder="Contact No" required name="" runat="server">
                            <label for="ContactNo" class="form__label">Contact No</label>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="text" class="form-control form__input" id="OfferedSalary"
                                placeholder="Offered Salary(20K To 50K/Month)" required name="" runat="server">
                            <label for="OfferedSalary" class="form__label">Offered Salary(20K To 50K/Month)</label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="number" class="form-control form__input" id="Age" placeholder="Age (in years)"
                                required name="" runat="server">
                            <label for="Age" class="form__label">Age (in years)</label>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="form-group">
                            <select id="InputState" class="form-control form__input" required name="" runat="server">
                                <option>Male</option>
                                <option>Female</option>
                            </select>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="number" class="form-control form__input" id="Experience"
                                placeholder="Experience (in years)" required name="" runat="server">
                            <label for="Experience" class="form__label">Experience (in years)</label>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="text" class="form-control form__input" id="RecentQualification"
                                placeholder="Recent Qualification" required name="" runat="server">
                            <label for="RecentQualification" class="form__label">Recent Qualification</label>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-lg-12">
                        <div class="form-group">
                            <textarea class="form-control form__input" id="AboutYou" rows="4" placeholder="About you"
                                required name="" runat="server"></textarea>
                            <label for="AboutYou" class="form__label">About you</label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-12">
                        <div class="form-group">
                            <textarea class="form-control form__input" id="Education" rows="4"
                                placeholder="Education (separate by commas)" required name="" runat="server"></textarea>
                            <label for="Education" class="form__label">Education (separate by commas)</label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-12">
                        <div class="form-group">
                            <textarea class="form-control form__input" id="WorkExperience" rows="4"
                                placeholder="Work Experience (separate by commas)" required name="" runat="server"></textarea>
                            <label for="WorkExperience" class="form__label">Work Experience (separate by commas)</label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-12">
                        <div class="form-group">
                            <textarea class="form-control form__input" id="Skills" rows="4"
                                placeholder="Skills (separate by commas)" required name="" runat="server"></textarea>
                            <label for="Skills" class="form__label">Skills (separate by commas)</label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-12">
                        <div class="form-group">
                            <textarea class="form-control form__input" id="Contact" rows="4"
                                placeholder="Contact (separate by commas)" required name="" runat="server"></textarea>
                            <label for="Contact" class="form__label">Contact (separate by commas)</label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-4">
                        <div class="form-group">
                            <input type="text" class="form-control form__input" id="City" placeholder="City" required
                                name="" runat="server">
                            <label for="City" class="form__label">City</label>
                        </div>
                    </div>
                    <div class="col-lg-4">
                        <div class="form-group">
                            <input type="text" class="form-control form__input" id="State" placeholder="State" required
                                name="" runat="server">
                            <label for="State" class="form__label">State</label>
                        </div>
                    </div>
                    <div class="col-lg-4">
                        <div class="form-group">
                            <input type="text" class="form-control form__input" id="Country" placeholder="Country"
                                required name="" runat="server">
                            <label for="Country" class="form__label">Country</label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-12">
                        <div class="form-group">
                            <textarea class="form-control form__input" id="FullAddress" rows="4"
                                placeholder="Full Address (separate by commas)" required name="" runat="server"></textarea>
                            <label for="Full Address" class="form__label">Full Address (separate by commas)</label>
                        </div>
                    </div>
                </div>
                <asp:Button ID="UpdateResumeButton" runat="server" type="SUBMIT" Text="UPDATE RESUME" OnClick="UpdateResumeButton_Click" class="bttn bttn--green" />
            </form>
        </div>



    </div>
        </div>
    </form>
</body>
</html>
