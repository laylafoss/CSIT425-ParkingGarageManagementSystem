<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dailyInformation.aspx.cs" Inherits="ParkingGarageApp.dailyInformation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center; background-color: #99CCFF; height: 828px;">
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Candara" Text="Daily Parking: Customer Information Needed"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Font-Names="Candara" Text="Last Name:"></asp:Label>
&nbsp;<asp:TextBox ID="lastTxt" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Label ID="Label6" runat="server" Font-Names="Candara" Text="First Name:"></asp:Label>
&nbsp;<asp:TextBox ID="firstTxt" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Font-Names="Candara" Text="License Plate Number:"></asp:Label>
&nbsp;<asp:TextBox ID="licenseTxt" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Font-Names="Candara" Text="Phone Number:"></asp:Label>
&nbsp;<asp:TextBox ID="phoneNumberTxt" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="invalidInputLabel" runat="server" Text="Invalid Input" Visible="False" ForeColor="#CC0000" Font-Names="Candara"></asp:Label>
            <br />
            <br />
            <asp:Button ID="continueBtn" runat="server" Text="Continue" OnClick="continueBtn_Click" Font-Names="Candara" />
            <br />
            <br />
            <asp:Button ID="backBtn" runat="server" Text="Back" OnClick="backBtn_Click" Font-Names="Candara" />
            <br />
        </div>
        <p style="text-align: center">
            &nbsp;</p>
        <p style="text-align: center">
            &nbsp;</p>
        <p style="text-align: center">
            &nbsp;</p>
    </form>
</body>
</html>
