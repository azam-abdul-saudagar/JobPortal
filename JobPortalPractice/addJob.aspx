<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddJob.aspx.cs" Inherits="JobPortalPractice.addJob" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Add Job</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Job Title : "></asp:Label>
&nbsp;
            <asp:TextBox ID="JobTitleTextBox" runat="server" Width="227px"></asp:TextBox>
&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Label ID="Label17" runat="server" Text="Company Name : "></asp:Label>
&nbsp;
            <asp:TextBox ID="CompanyNameTextBox" runat="server" Width="242px"></asp:TextBox>
            <br />
            <br />
&nbsp;<asp:Label ID="Label2" runat="server" Text="Category : "></asp:Label>
&nbsp;
            <asp:TextBox ID="CategoryTextBox" runat="server" Width="292px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Description : "></asp:Label>
&nbsp;
            <asp:TextBox ID="DescriptionTextBox" runat="server" TextMode="MultiLine" Width="608px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Salary Range : "></asp:Label>
&nbsp;
            <asp:TextBox ID="SalaryRangeTextBox" runat="server" Width="222px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="Experience : "></asp:Label>
&nbsp;
            <asp:TextBox ID="ExperienceTextBox" runat="server" Width="256px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Job Type : "></asp:Label>
&nbsp;
            <asp:DropDownList ID="JobTypeDropDownList" runat="server" Width="253px">
                <asp:ListItem>Part time</asp:ListItem>
                <asp:ListItem>Full Time</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label7" runat="server" Text="No of vacancy : "></asp:Label>
&nbsp;
            <asp:TextBox ID="NoVacancyTextBox" runat="server" Width="231px" TextMode="Number"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="Qualification Required : "></asp:Label>
&nbsp;
            <asp:TextBox ID="QualificationTextBox" runat="server" TextMode="MultiLine" Width="536px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="Skills (Seprate commas) : "></asp:Label>
&nbsp;
            <asp:TextBox ID="SkillsTextBox" runat="server" TextMode="MultiLine" Width="517px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label10" runat="server" Text="Email : "></asp:Label>
&nbsp;
            <asp:TextBox ID="EmailTextBox" runat="server" Width="261px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label11" runat="server" Text="Contact No. : "></asp:Label>
&nbsp;
            <asp:TextBox ID="ContactTextBox" runat="server" Width="239px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label12" runat="server" Text="Address : "></asp:Label>
&nbsp;
            <asp:TextBox ID="AddressTextBox" runat="server" TextMode="MultiLine" Width="614px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label13" runat="server" Text="City : "></asp:Label>
&nbsp;
            <asp:TextBox ID="CityTextBox" runat="server" Width="286px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label14" runat="server" Text="State : "></asp:Label>
&nbsp;
            <asp:TextBox ID="StateTextBox" runat="server" Width="267px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label15" runat="server" Text="Country : "></asp:Label>
&nbsp;
            <asp:TextBox ID="CountryTextBox" runat="server" Width="257px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label16" runat="server" Text="Zip Code : "></asp:Label>
&nbsp;
            <asp:TextBox ID="ZipCodeTextBox" runat="server" Width="237px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Width="686px" />
        </div>
    </form>
</body>
</html>
