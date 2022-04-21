<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="monthlyInformation.aspx.cs" Inherits="ParkingGarageApp.monthlyInformation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Monthly Parking: Customer Information Needed</div>
        <p>
            Last Name:&nbsp;
            <asp:TextBox ID="lastTxt" runat="server"></asp:TextBox>
&nbsp;&nbsp; First Name:
            <asp:TextBox ID="firstTxt" runat="server"></asp:TextBox>
        </p>
        <p>
            License Plate Number:&nbsp;
            <asp:TextBox ID="licenseTxt" runat="server"></asp:TextBox>
        </p>
        <p>
            //MORE INFOMATION TO BE ADDED</p>
        <p>
            <asp:Label ID="invalidInputLabel" runat="server" Text="Invalid Input" Visible="False" ForeColor="#CC0000"></asp:Label>
        </p>
        <asp:Button ID="continueBtn" runat="server" Text="Continue" OnClick="continueBtn_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="backBtn" runat="server" Text="Back" OnClick="backBtn_Click" />
    </form>
</body>
</html>
