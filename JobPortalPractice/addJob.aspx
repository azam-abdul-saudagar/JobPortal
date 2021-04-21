<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddJob.aspx.cs" Inherits="JobPortalPractice.addJob" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Job</title>
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

        <div class="container">
            <h2 class="heading-secondary">
                Add Job
            </h2>
            <form class="form" action="UploadResume.aspx" method="post">
                <div class="row">
                    <div class="col-lg-12">                      
                        <div class="form-group form__group">
                            <input type="text" class="form-control form__input" id="JobTitleTextBox" placeholder="Job Title"
                                required name="" runat="server" value="">
                            <label for="JobTitleTextBox" class="form__label">Job Title</label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-6">
                        <div class="form-group form__group">
                            <input type="text" class="form-control form__input" id="CompanyNameTextBox" placeholder="Company Name"
                                required name="" runat="server">
                            <label for="CompanyNameTextBox" class="form__label">Company Name</label>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="text" class="form-control form__input" id="CategoryTextBox" placeholder="Category" required
                                name="" runat="server">
                            <label for="CategoryTextBox" class="form__label">Category</label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-12">
                        <div class="form-group form__group">
                            <input type="text" class="form-control form__input" id="DescriptionTextBox" placeholder="Description"
                                required name="" runat="server" value="">
                            <label for="DescriptionTextBox" class="form__label">Description</label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="text" class="form-control form__input" id="SalaryRangeTextBox"
                                placeholder="Salary Range" required name="" runat="server">
                            <label for="SalaryRangeTextBox" class="form__label">Salary Range</label>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="number" class="form-control form__input" id="ExperienceTextBox"
                                placeholder="Experience" required name="" runat="server">
                            <label for="ExperienceTextBox" class="form__label">Experience</label>
                        </div>
                    </div>
                </div>
                
                <div class="row">                   
                    <div class="col-lg-6">
                        <div class="form-group">
                            <select id="JobTypeDropDownList" class="form-control form__input" required name="" runat="server">
                                <option>Part time</option>
                                <option>Full time</option>
                            </select>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="text" class="form-control form__input" id="NoVacancyTextBox"
                                placeholder="No Vacancy" required name="" runat="server">
                            <label for="NoVacancyTextBox" class="form__label">No Vacancy</label>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-lg-12">
                        <div class="form-group">
                            <textarea class="form-control form__input" id="QualificationTextBox" rows="4" placeholder="Qualification Required (separate by commas)"
                                required name="" runat="server"></textarea>
                            <label for="QualificationTextBox" class="form__label">Qualification Required (separate by commas)</label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-12">
                        <div class="form-group">
                            <textarea class="form-control form__input" id="SkillsTextBox" rows="4"
                                placeholder="Skills" required name="" runat="server"></textarea>
                            <label for="SkillsTextBox" class="form__label">Skills</label>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="text" class="form-control form__input" id="EmailTextBox"
                                placeholder="Email" required name="" runat="server">
                            <label for="EmailTextBox" class="form__label">Email</label>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="number" class="form-control form__input" id="ContactTextBox"
                                placeholder="Contact" required name="" runat="server">
                            <label for="ContactTextBox" class="form__label">Contact</label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-12">
                        <div class="form-group">
                            <textarea class="form-control form__input" id="AddressTextBox" rows="4"
                                placeholder="Full Address (separate by commas)" required name="" runat="server"></textarea>
                            <label for="AddressTextBox" class="form__label">Full Address (separate by commas)</label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="text" class="form-control form__input" id="CityTextBox"
                                placeholder="City" required name="" runat="server">
                            <label for="CityTextBox" class="form__label">City</label>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="text" class="form-control form__input" id="StateTextBox"
                                placeholder="State" required name="" runat="server">
                            <label for="StateTextBox" class="form__label">State</label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="text" class="form-control form__input" id="CountryTextBox"
                                placeholder="Country" required name="" runat="server">
                            <label for="CountryTextBox" class="form__label">Country</label>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="form-group">
                            <input type="number" class="form-control form__input" id="ZipCodeTextBox"
                                placeholder="ZipCode" required name="" runat="server">
                            <label for="ZipCodeTextBox" class="form__label">ZipCode</label>
                        </div>
                    </div>
                </div>               
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" class="bttn bttn--green"/>             
            </form>
        </div>
    </div>
        </div>      
    </form>
</body>
</html>
