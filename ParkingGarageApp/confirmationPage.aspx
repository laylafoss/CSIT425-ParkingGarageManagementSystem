<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="confirmationPage.aspx.cs" Inherits="ParkingGarageApp.confirmationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 695px;
        }
    </style>
</head>
<body style="text-align: center">
    <form id="form1" runat="server" style="background-color: #99CCFF">
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="You're all set!" Font-Bold="True" Font-Names="Candara"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Font-Names="Candara" Text="Thank you for choosing to park with us,"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Font-Names="Candara" Text="we hope to see you soon."></asp:Label>
        <br />
        <br />
        <asp:Button ID="exitBtn" runat="server" OnClick="exitBtn_Click" Text="EXIT" BackColor="White" BorderColor="#3333FF" Font-Names="Candara" Height="42px" Width="57px" />
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" Height="116px" ImageUrl="~/Images/carimage.png" Width="97px" />
    </form>
</body>
</html>
