<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dailyInformation.aspx.cs" Inherits="ParkingGarageApp.dailyInformation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Daily Parking: Customer Information Needed<br />
            <br />
            Last Name:
            <asp:TextBox ID="lastTxt" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; First Name:&nbsp;
            <asp:TextBox ID="firstTxt" runat="server"></asp:TextBox>
            <br />
            <br />
            License Plate Number:&nbsp;
            <asp:TextBox ID="licenseTxt" runat="server"></asp:TextBox>
            <br />
            <br />
            Phone Number:&nbsp;
            <asp:TextBox ID="phoneNumberTxt" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="invalidInputLabel" runat="server" Text="Invalid Input" Visible="False" ForeColor="#CC0000"></asp:Label>
        </p>
        <p>
            <asp:Button ID="continueBtn" runat="server" Text="Continue" OnClick="continueBtn_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="backBtn" runat="server" Text="Back" OnClick="backBtn_Click" />
        </p>
    </form>
</body>
</html>
