<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminPageLogin.aspx.cs" Inherits="ParkingGarageApp.adminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Administrator Login: Authorized Personnel Only<br />
            <br />
            Password:&nbsp;
            <asp:TextBox ID="adminPasswordTxt" runat="server" OnTextChanged="adminPasswordTxt_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="enterBtn" runat="server" OnClick="enterBtn_Click" Text="Enter" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="backBtn" runat="server" OnClick="backBtn_Click" Text="Back" />
            <br />
            <br />
        </div>
        <asp:Label ID="errorMessageLabel" runat="server" ForeColor="#CC0000" Text="Error Message" Visible="False"></asp:Label>
    </form>
</body>
</html>
