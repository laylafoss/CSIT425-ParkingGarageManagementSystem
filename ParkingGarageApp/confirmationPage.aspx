<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="confirmationPage.aspx.cs" Inherits="ParkingGarageApp.confirmationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="You're all set!"></asp:Label>
        <br />
        Thank you for choosing to park with us,<br />
        we hope to see you soon.<br />
        <br />
        <asp:Button ID="exitBtn" runat="server" OnClick="exitBtn_Click" Text="Exit" />
    </form>
</body>
</html>
