<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminPage.aspx.cs" Inherits="ParkingGarageApp.adminPage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            text-align: center;
        }
    </style>
</head>
<body style="height: 594px; background-color: #99CCFF;">
    <form id="form1" runat="server">
        <div>
            </div>
        Database Connection and Management<br />
        <br />
        <br />
        <asp:Button ID="btnTestCon" runat="server" OnClick="btnTestCon_Click" Text="Test Connection" />
        <br />
        <br />
        <asp:Button ID="btnTestRet" runat="server" OnClick="btnTestRet_Click" Text="Test Retrieve" />
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="btnTestWrit" runat="server" OnClick="btnTestWrit_Click" Text="Test Write" />
        &nbsp;
        <asp:TextBox ID="txtBxTestWrit" runat="server"></asp:TextBox>
    </form>
</body>
</html>
