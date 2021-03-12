<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanyPersonalDataEntryPg.aspx.cs" Inherits="JobPortalPractice.CompanyPersonalDataEntryPg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Company Name :"></asp:Label>
&nbsp;
            <asp:TextBox ID="CompanyNameTextBox" runat="server" Width="345px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Company Tagline : "></asp:Label>
&nbsp;
            <asp:TextBox ID="CompanyTaglineTextBox" runat="server" Width="391px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Owner Name : "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="NameTextBox" runat="server" Width="344px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Email : "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="EmailTextBox" runat="server" Width="389px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Contact No : "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="ContactTextBox" runat="server" Width="342px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Text="Password : "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="PasswordTextBox" runat="server" Width="386px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Company Category : "></asp:Label>
&nbsp;
            <asp:TextBox ID="CompanyCategoryTextBox" runat="server" Width="318px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label8" runat="server" Text="Working Time : "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="WorkingTimeTextBox" runat="server" Width="387px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="Facebook : "></asp:Label>
&nbsp;
            <asp:TextBox ID="FacebookTextBox" runat="server" Width="374px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label10" runat="server" Text="Twitter : "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TwitterTextBox" runat="server" Width="380px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label11" runat="server" Text="LinkedIn : "></asp:Label>
&nbsp;
            <asp:TextBox ID="LinkedInTextBox" runat="server" Width="380px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label12" runat="server" Text="Instagram : "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="InstagramTextBox" runat="server" Width="381px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label13" runat="server" Text="Address : "></asp:Label>
&nbsp;
            <asp:TextBox ID="AddressTextBox" runat="server" Height="48px" Width="956px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label14" runat="server" Text="State : "></asp:Label>
&nbsp;
            <asp:TextBox ID="StateTextBox" runat="server" Width="398px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label15" runat="server" Text="Country : "></asp:Label>
&nbsp;
            <asp:TextBox ID="CountryTextBox" runat="server" Width="413px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="SaveButton" runat="server" OnClick="SaveButton_Click" Text="Save" Width="80px" />
        </div>
    </form>
</body>
</html>
