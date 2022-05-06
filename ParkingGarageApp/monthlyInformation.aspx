<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="monthlyInformation.aspx.cs" Inherits="ParkingGarageApp.monthlyInformation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: #99CCFF; height: 720px; text-align: center;">
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Font-Names="Candara" Text="Monthly Parking: Customer Information Needed"></asp:Label>
        <p style="text-align: center">
            <asp:Label ID="Label5" runat="server" Font-Names="Candara" Text="Last Name:"></asp:Label>
&nbsp;<asp:TextBox ID="lastTxt" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Font-Names="Candara" Text="First Name:"></asp:Label>
&nbsp;<asp:TextBox ID="firstTxt" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label7" runat="server" Font-Names="Candara" Text="License Plate Number:"></asp:Label>
&nbsp;
            <asp:TextBox ID="licenseTxt" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label9" runat="server" Font-Names="Candara" Text="Email Address:"></asp:Label>
&nbsp;
            <asp:TextBox ID="emailTxt" runat="server" Width="207px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label8" runat="server" Font-Names="Candara" Text="Phone Number:"></asp:Label>
&nbsp;<asp:TextBox ID="phoneNumberTxt" runat="server"></asp:TextBox>
        </p>
            <p style="text-align: center">
            <asp:Label ID="invalidInputLabel" runat="server" Text="Invalid Input" Visible="False" ForeColor="#CC0000" Font-Names="Candara"></asp:Label>
        </p>
            <p style="text-align: center">
        <asp:Button ID="continueBtn" runat="server" Text="Continue" OnClick="continueBtn_Click" Font-Names="Candara" />
        </p>
            <p style="text-align: center">
        <asp:Button ID="backBtn" runat="server" Text="Back" OnClick="backBtn_Click" Font-Names="Candara" Width="60px" />
        </p>
        </div>
        <p>

        </p>
        <p>
            &nbsp;</p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </form>
</body>
</html>
