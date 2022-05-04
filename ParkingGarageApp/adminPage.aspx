<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminPage.aspx.cs" Inherits="ParkingGarageApp.adminPage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            yay databases!</div>
        <asp:Button ID="btnTestCon" runat="server" OnClick="btnTestCon_Click" Text="Test Connection" />
        <asp:Button ID="btnTestRet" runat="server" OnClick="btnTestRet_Click" Text="Test Retrieve" />
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        <asp:Button ID="btnTestWrit" runat="server" OnClick="btnTestWrit_Click" Text="Test Write" />
        <asp:TextBox ID="txtBxTestWrit" runat="server"></asp:TextBox>
    </form>
</body>
</html>
