<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewResume.aspx.cs" Inherits="JobPortalPractice.ViewResume" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Resume</title>
    <link rel="stylesheet" href="ViewResume.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="header">
        <div class="box">
            <div class="header__content">
                <h2>Alden Smith</h2>
                <div class="header__features--main">

                    <h4 class="job-title">Front End Designer</h4>
                    <h4>2726 Shinn, New York</h4>
                    <h4>mail@example.com</h4>
                    <h4>91 234 567 8765</h4>
                </div>
                <div class="header__features--sub">
                    <h4>Offered Salary : <span id="job-type">20K To 50K/Month</span></h4>
                    <h4>Experience : <span id="experience">3 Year Exp.</span></h4>
                    <h4>Gender : <span id="age">Male</span></h4>
                    <h4>Qualification : <span id="experience">Masters</span></h4>
                </div>
            </div>
        </div>
    </div>

    </div>

    <div class="body">
        <div class="body__sub-part">
            <h3>About Candidate</h3>
            <p>"On the other hand, we denounce with righteous indignation and dislike men who are so beguiled and
                demoralized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the
                pain and trouble that are bound to ensue.

                At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum
                deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non
                provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga.
            </p>
        </div>
        <div class="body__sub-part">
            <h3>Education</h3>
            <p>
            <ul>
                <li>There are many variations of passages of Lorem Ipsum available</li>
                <li>There are many variations of passages of Lorem Ipsum available</li>
                <li>There are many variations of passages of Lorem Ipsum available</li>
                <li>There are many variations of passages of Lorem Ipsum available</li>
            </ul>
            </p>
        </div>
        <div class="body__sub-part">
            <h3>Work Experience</h3>
            <p>
            <ul>
                <li>There are many variations of passages of Lorem Ipsum available</li>
                <li>There are many variations of passages of Lorem Ipsum available</li>
                <li>There are many variations of passages of Lorem Ipsum available</li>
                <li>There are many variations of passages of Lorem Ipsum available</li>
            </ul>
            </p>
        </div>
        <div class="body__sub-part">
            <h3>Skills</h3>
            <p>
            <ul>

                <li>CSS</li>
                <li>HTML/li>
                <li>JAVASCRIPT</li>
                <li>PHOTOSHOP</li>
            </ul>
            </p>
        </div>
        <div class="body__sub-part">
            <h3>Contact</h3>
            <p>
            <ul>
                <li id="email">mail@example.com</li>
                <li id="contactNo">91 234 567 8765</li>
            </ul>
            </p>
        </div>
        <div class="body__sub-part">
            <h3>Location</h3>
            <p>
            <ul>
                <li>City : <span id="city">City</span></li>
                <li>State : <span id="state">State</span></li>
                <li>Country : <span id="country">Country</span></li>
                <li>Full address : <span id="Fulladdress">Chandigarh Junction railway station
                        Sector 78, Sahibzada Ajit Singh Nagar, Punjab 140308</span></li>
            </ul>
            </p>
        </div>
        <asp:Button ID="SelectCandidateButton" runat="server" type="submit" class="btn btn--green" Text="Select this candidate" OnClick="SelectCandidateButton_Click" />
        </div>
    </form>
</body>
</html>
