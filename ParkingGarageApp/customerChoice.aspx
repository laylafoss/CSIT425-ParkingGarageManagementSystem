<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customerChoice.aspx.cs" Inherits="ParkingGarageApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title></title>
</head>
<body style="height: 408px">
    <form id="form1" runat="server">
        <div style="background-color: #99CCFF; height: 687px; text-align: center;">
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Candara" Font-Overline="False" Font-Size="XX-Large" ForeColor="Blue" Text="Welcome!"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Font-Names="Candara" Font-Size="Small" Text="Make selection below to access the parking garage:"></asp:Label>
            <br />
            <br />
            <meta charset="utf-8" />
            <asp:Button ID="dailyBtn" runat="server" Text="DAILY" Height="47px" OnClick="dailyBtn_Click" Width="142px" Font-Names="Candara" Font-Size="Large" />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Names="Candara" Font-Size="X-Small" Text="One-Time Parking"></asp:Label>
            <br />
            <br />
        <asp:Button ID="monthlyBtn" runat="server" Text="MONTHLY" Height="45px" OnClick="monthlyBtn_Click" Width="140px" Font-Names="Candara" Font-Size="Large" />
            <br />
            <asp:Label ID="Label4" runat="server" Font-Names="Candara" Font-Size="X-Small" Text="Indefinite Parking"></asp:Label>
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="116px" ImageUrl="~/Images/carimage.png" Width="97px" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/adminPageLogin.aspx" Font-Size="Small">Administrator Access</asp:HyperLink>
        </div>
    <p>
        &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
    </body>
</html>
